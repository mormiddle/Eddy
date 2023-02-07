using Eddy_Plus.Page;
using System;
using System.Collections.Generic;
using System.Text;
using Eddy_Plus.Page;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Flfft;
using MathWorks.MATLAB.NET.Arrays;
using Test;
using System.Threading;
using System.IO;

namespace Sunny.UI.Demo
{
    public partial class FHeaderAsideMain : UIHeaderAsideMainFrame
    {
        Setting onlySetting = new Setting();
        ShowPage onlyShowPage = new ShowPage();
        private long receive_count = 0; //接收字节计数
        private StringBuilder sb = new StringBuilder();    //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        private DateTime current_time = new DateTime();    //为了避免在接收处理函数中反复调用，依然声明为一个全局变量
        private bool is_need_time = true;
        private List<byte> buffer = new List<byte>(); //设置缓存处理CRC32串口的校验
        public static bool intimewindowIsOpen = false; //判断波形窗口是否创建
        List<byte> CheckedData = new List<byte>();//申请一个大容量的数组
        //private List<byte> SerialPortReceiveData = new List<byte>(); //用于存储串口的数据
        string timeStart;//采集开始时间
        int start = 0;//充当指针的作用
        int[] Serialport1XyAutoSet = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private Queue<int> Freq1RealDataQueue = new Queue<int>(100);//以下两行为波形显示做准备
        private Queue<int> Freq1ImagDataQueue = new Queue<int>(100);//以下两行为波形显示做准备
        int pointIndex = 0;
        int FlawDetectionCount = 0;//记录探伤次数
        string NumFile = "F:\\涡流项目\\Eddy\\Eddy_Plus\\Eddy_Plus\\Resources\\Num.txt";
        string NumFile1 = "F:\\涡流项目\\Eddy\\Eddy_Plus\\Eddy_Plus\\Resources\\Num1.txt";


        #region 判断串口是否插入
        public bool search_port_is_exist(String item, String[] port_list)
        {
            for (int i = 0; i < port_list.Length; i++)
            {
                if (port_list[i].Equals(item))
                {
                    return true;
                }
            }

            return false;
        }
        #endregion

        #region 扫描串口列表并添加到选择框
        private void Update_Serial_List()
        {
            try
            {
                /* 搜索串口 */
                String[] cur_port_list = System.IO.Ports.SerialPort.GetPortNames();

                /* 刷新串口列表comboBox */
                int count = onlySetting.uiComboBox1.Items.Count;
                if (count == 0)
                {
                    //combox中无内容，将当前串口列表全部加入
                    onlySetting.uiComboBox1.Items.AddRange(cur_port_list);
                    return;
                }
                else
                {
                    //combox中有内容

                    //判断有无新插入的串口
                    for (int i = 0; i < cur_port_list.Length; i++)
                    {
                        if (!onlySetting.uiComboBox1.Items.Contains(cur_port_list[i]))
                        {
                            //找到新插入串口，添加到combox中
                            onlySetting.uiComboBox1.Items.Add(cur_port_list[i]);
                        }
                    }

                    //判断有无拔掉的串口
                    for (int i = 0; i < count; i++)
                    {
                        if (!search_port_is_exist(onlySetting.uiComboBox1.Items[i].ToString(), cur_port_list))
                        {
                            //找到已被拔掉的串口，从combox中移除
                            onlySetting.uiComboBox1.Items.RemoveAt(i);
                        }
                    }
                }

                /* 如果当前选中项为空，则默认选择第一项 */
                if (onlySetting.uiComboBox1.Items.Count > 0)
                {
                    if (onlySetting.uiComboBox1.Text.Equals(""))
                    {
                        //软件刚启动时，列表项的文本值为空
                        onlySetting.uiComboBox1.Text = onlySetting.uiComboBox1.Items[0].ToString();

                    }
                }
                else
                {
                    //无可用列表，清空文本值
                    onlySetting.uiComboBox1.Text = "";
                }


            }
            catch (Exception)
            {
                //当下拉框被打开时，修改下拉框会发生异常
                return;
            }
        }
        #endregion


        private void timer1_Tick(object sender, EventArgs e)
        {
            Update_Serial_List();
        }



        #region 串口接收数据
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            /* 串口接收事件处理 */



            int num = serialPort1.BytesToRead;      //获取接收缓冲区中的字节数
            if (num == 0)
            {
                return;
            }
            byte[] received_buf = new byte[num];    //声明一个大小为num的字节数据用于存放读出的byte型数据


            receive_count += num;                   //接收字节计数变量增加nun
            serialPort1.Read(received_buf, 0, num);   //读取接收缓冲区中num个字节到byte数组中

            #region 数据校验
            buffer.AddRange(received_buf); //缓存数据

            // resize arr
            int count = buffer.Count;

            while (start + 44 <= count)
            {
                // head, tail
                if (buffer[start] != 0xAA || buffer[start + 1] != 0x29 || buffer[start + 43] != 0x80)
                {
                    start += 2;
                    continue;
                }

                // CRC8: from  start + 2  to start + 41, check by start + 42
                if (CRC8(buffer, start + 2, 40) != buffer[start + 42])
                {
                    start += 2;
                    continue;
                }

                // append data
                {
                    // copy 40 bytes from start
                    for (int i = start + 2; i < start + 42; i++)
                    {
                        CheckedData.Add(buffer[i]);
                    }


                    //show bytes
                    ShowSerialPortReceive(buffer, start);
                }

                start += 44;
            }

            #endregion

        }
        #endregion

        #region 显示串口接收的数据
        private void ShowSerialPortReceive(List<byte> showbuffer, int start)
        {


        }

        #endregion



        #region CRC8校验函数
        public static byte CRC8(List<byte> buffer, int start, int length)
        {
            byte crc = 0;// Initial value

            for (int j = start; j < start + length; j++)
            {
                crc ^= buffer[j];
                for (int i = 0; i < 8; i++)
                {
                    if ((crc & 0x80) != 0)
                    {
                        crc <<= 1;
                        crc ^= 0x07;
                    }
                    else
                    {
                        crc <<= 1;
                    }
                }
            }
            return crc;
        }


        #endregion


        #region 右上角串口连接开关
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态

                    serialPort1.Close();    //关闭串口
                    button1.BackgroundImage = global::Eddy_Plus.Properties.Resources.connect;
                    onlySetting.uiComboBox1.Enabled = true;
                    onlySetting.uiComboBox2.Enabled = true;
                    onlySetting.uiComboBox3.Enabled = true;
                    onlySetting.uiComboBox4.Enabled = true;
                    onlySetting.uiComboBox5.Enabled = true;
                    onlySetting.uiLabel6.Text = "串口已关闭!";
                    onlySetting.uiLabel6.ForeColor = Color.Red;
                    //button5.Enabled = false;        //失能发送按钮
                    onlySetting.uiComboBox4.Enabled = false;

                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    onlyShowPage.uiLedStopwatch1.Active = false;
                    onlyShowPage.uiLedStopwatch1.Text = "00";

                    uiButton2.Enabled = false;
                    uiButton1.Enabled = true;
                    CheckedData.Clear();
                    start = 0;
                    onlyShowPage.uiLabel2.Text = "尚未进行探伤";

                    string information1 = "设备已断开连接";
                    current_time = System.DateTime.Now;     //获取当前时间
                    onlyShowPage.uiTextBox1.AppendText("\r\n[" + current_time.ToString("HH:mm:ss") + "]" + information1.ToString());
                    

                    //开启端口扫描
                    timer1.Interval = 1000;
                    timer1.Start();
                }
                else
                {
                    /* 串口已经处于关闭状态，则设置好串口属性后打开 */
                    //停止串口扫描
                    timer1.Stop();

                    onlySetting.uiComboBox1.Enabled = false;
                    onlySetting.uiComboBox2.Enabled = false;
                    onlySetting.uiComboBox3.Enabled = false;
                    onlySetting.uiComboBox4.Enabled = false;
                    onlySetting.uiComboBox5.Enabled = false;
                    serialPort1.PortName = onlySetting.uiComboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(onlySetting.uiComboBox2.Text);
                    serialPort1.DataBits = Convert.ToInt16(onlySetting.uiComboBox3.Text);

                    if (onlySetting.uiComboBox4.Text.Equals("None"))
                        serialPort1.Parity = System.IO.Ports.Parity.None;
                    else if (onlySetting.uiComboBox4.Text.Equals("Odd"))
                        serialPort1.Parity = System.IO.Ports.Parity.Odd;
                    else if (onlySetting.uiComboBox4.Text.Equals("Even"))
                        serialPort1.Parity = System.IO.Ports.Parity.Even;
                    else if (onlySetting.uiComboBox4.Text.Equals("Mark"))
                        serialPort1.Parity = System.IO.Ports.Parity.Mark;
                    else if (onlySetting.uiComboBox4.Text.Equals("Space"))
                        serialPort1.Parity = System.IO.Ports.Parity.Space;

                    if (onlySetting.uiComboBox5.Text.Equals("1"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    else if (onlySetting.uiComboBox5.Text.Equals("1.5"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.OnePointFive;
                    else if (onlySetting.uiComboBox5.Text.Equals("2"))
                        serialPort1.StopBits = System.IO.Ports.StopBits.Two;

                    //打开串口，设置状态
                    serialPort1.Open();
                    button1.BackgroundImage = global::Eddy_Plus.Properties.Resources.disconnect;
                    onlySetting.uiLabel6.Text = "串口已打开!";
                    onlySetting.uiLabel6.ForeColor = Color.Green;

                    string information1 = "设备已连接";
                    current_time = System.DateTime.Now;     //获取当前时间
                    onlyShowPage.uiTextBox1.AppendText("\r\n[" + current_time.ToString("HH:mm:ss") + "]" + information1.ToString());


                    //使能发送按钮
                    //button5.Enabled = true;

                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用  
                serialPort1 = new System.IO.Ports.SerialPort(components);
                serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);

                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                button1.BackgroundImage = global::Eddy_Plus.Properties.Resources.connect;
                MessageBox.Show(ex.Message);
                onlySetting.uiComboBox1.Enabled = true;
                onlySetting.uiComboBox2.Enabled = true;
                onlySetting.uiComboBox3.Enabled = true;
                onlySetting.uiComboBox4.Enabled = true;
                onlySetting.uiComboBox5.Enabled = true;
                onlySetting.uiLabel6.Text = "串口已关闭!";
                onlySetting.uiLabel6.ForeColor = Color.Red;

                //开启串口扫描
                timer1.Interval = 1000;
                timer1.Start();
            }
        }
        #endregion


        public FHeaderAsideMain()
        {
            InitializeComponent();

            //设置关联
            Aside.TabControl = MainTabControl;

            //增加页面到Main
            AddPage(onlyShowPage, 1001);
            AddPage(onlySetting, 1003);
            //AddPage(new FTitlePage3(), 1003);

            //设置Header节点索引
            Aside.CreateNode("主页", 1001);
            Aside.CreateNode("设置", 1003);
            //Aside.CreateNode("Page3", 1003);

            //显示默认界面
            Aside.SelectFirst();
        }

        private void FHeaderAsideMain_Load(object sender, EventArgs e)
        {
            /* 添加串口选择列表 */
            Update_Serial_List();

            /* 添加波特率列表 */
            string[] baud = { "9600", "38400", "57600", "115200" };
            onlySetting.uiComboBox2.Items.AddRange(baud);

            /* 添加数据位列表 */
            string[] data_length = { "5", "6", "7", "8", "9" };
            onlySetting.uiComboBox3.Items.AddRange(data_length);

            /* 添加校验位列表 */
            string[] verification_mode = { "None", "Odd", "Even", "Mark", "Space" };
            onlySetting.uiComboBox4.Items.AddRange(verification_mode);

            /* 添加停止位列表 */
            string[] stop_length = { "1", "1.5", "2" };
            onlySetting.uiComboBox5.Items.AddRange(stop_length);

            /* 设置默认选择值 */
            onlySetting.uiComboBox2.Text = "115200";
            onlySetting.uiComboBox3.Text = "8";
            onlySetting.uiComboBox4.Text = "None";
            onlySetting.uiComboBox5.Text = "1";

            /* 在串口未打开的情况下每隔1s刷新一次串口列表框 */
            timer1.Interval = 1000;
            timer1.Start();

            uiButton2.Enabled = false;
            uiButton1.Enabled = true;

            //初始化波形显示队列
            for (int cache1 = 0; cache1 < 100; cache1++)
            {
                UpdateSerialport1DataQueueValue(0);
                onlyShowPage.chart_real1.Series[0].Points.AddXY((cache1 + 1), Freq1RealDataQueue.ElementAt(cache1));
            }

            if (onlySetting.uiComboBox1.Items.Count > 0)
            {
                string information = "设备已准备就绪，请连接设备";
                try
                {
                    //因为要访问UI资源，所以需要使用invoke方式同步ui
                    Invoke((EventHandler)(delegate
                    {
                        if (is_need_time)
                        {
                            /* 需要加时间戳 */
                            is_need_time = false;   //清空标志位
                            current_time = System.DateTime.Now;     //获取当前时间
                            onlyShowPage.uiTextBox1.AppendText("\r\n[" + current_time.ToString("HH:mm:ss") + "]" + information.ToString());
                        }

                    }
                      )
                    );
                }
                catch (Exception ex)
                {
                    //响铃并显示异常给用户
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);

                }
            }

            Thread th = new Thread(MyStart);
            th.IsBackground = true;
            th.Start();

        }

        public void MyStart()
        {
            Mytest mystart = new Mytest();
            MWArray a = 1, b = 2, c;
            c = mystart.Test(a, b);
            return;
        }

        public void UpdateSerialport1DataQueueValue(int data1)
        {
            if (Freq1RealDataQueue.Count > 100)
            {
                //先出列
                for (int i = 0; i < 1; i++)
                {
                    Freq1RealDataQueue.Dequeue();//出队
                }
            }
            for (int i = 0; i < 1; i++)
            {
                Freq1RealDataQueue.Enqueue(data1);//进队
            }/////////
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // button5_Click(button5, new EventArgs());    //调用发送按钮回调函数
            onlyShowPage.chart_real1.Series[0].Points.Clear();
            while (CheckedData.Count() < 200)
            {
                continue;
            }

            for (int i = 0; i < 20; i++)
            {
                Serialport1XyAutoSet[i] = CheckedData[i * 2 + pointIndex + 2] * 256 + CheckedData[i * 2 + 1 + pointIndex + 2];
            }
            UpdateSerialport1DataQueueValue(Serialport1XyAutoSet[0]);


            for (int i = 0; i < 100; i++)
            {
                onlyShowPage.chart_real1.Series[0].Points.AddXY((i + 1), Freq1RealDataQueue.ElementAt(i));

            }//
            pointIndex += 40;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            /* 设置时间内未收到数据，分包，加入时间戳 */
            is_need_time = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            onlyShowPage.chart_real1.ChartAreas[0].AxisY.Minimum = Serialport1XyAutoSet[0] - 100;
            onlyShowPage.chart_real1.ChartAreas[0].AxisY.Maximum = Serialport1XyAutoSet[0] + 100;

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                timeStart = System.DateTime.Now.ToString();
                timer2.Enabled = true;
                timer3.Enabled = true;
                onlyShowPage.uiLedStopwatch1.Text = "00";
                onlyShowPage.uiLedStopwatch1.Active = true;
                onlyShowPage.uiLabel2.Text = "探伤进行中...";
                FlawDetectionCount++;
                string information = "开始第 " + FlawDetectionCount.ToString() + " 轮探伤";
                try
                {
                    //因为要访问UI资源，所以需要使用invoke方式同步ui
                    Invoke((EventHandler)(delegate
                    {
                            current_time = System.DateTime.Now;     //获取当前时间
                            onlyShowPage.uiTextBox1.AppendText("\r\n[" + current_time.ToString("HH:mm:ss") + "]" + information.ToString());
                    }
                      )
                    );
                }
                catch (Exception ex)
                {
                    //响铃并显示异常给用户
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);

                }
                uiButton2.Enabled = true;
                uiButton1.Enabled = false;
            }
            else
            {
                MessageBox.Show("请打开连接开关！");
            }
            
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            double span1 = (DateTime.Now - DateTime.Parse(timeStart)).Ticks / 10000000;
            if (span1 > 90)
            {
                timer2.Enabled = false;
                timer3.Enabled = false;
                onlyShowPage.uiLedStopwatch1.Active = false;
                bool FlawDetection = false;
                double[] realmax = new double[10];
                string information;

                realmax[0] = GetMax(CheckedData, 0);
                realmax[1] = GetMax(CheckedData, 2);
                realmax[2] = GetMax(CheckedData, 4);
                realmax[3] = 0;
                realmax[4] = GetMax(CheckedData, 8);
                realmax[5] = 0;
                realmax[6] = GetMax(CheckedData, 12);
                realmax[7] = GetMax(CheckedData, 14);
                realmax[8] = GetMax(CheckedData, 16);
                realmax[9] = GetMax(CheckedData, 18);
                for (int i = 0; i < 10; i++)
                {
                    if (realmax[i] > 2.3)
                    {
                        FlawDetection = true;
                    }
                }
                if (FlawDetection == true)
                {
                    onlyShowPage.uiLabel2.Text = "有伤损！";
                    information = "开始第 " + FlawDetectionCount.ToString() + " 轮探伤的结果为：有伤损！";
                }
                else
                {
                    onlyShowPage.uiLabel2.Text = "无伤损！";
                    information = "开始第 " + FlawDetectionCount.ToString() + " 轮探伤的结果为：无伤损！";
                }


                try
                {
                    //因为要访问UI资源，所以需要使用invoke方式同步ui
                    Invoke((EventHandler)(delegate
                    {

                        current_time = System.DateTime.Now;     //获取当前时间
                        onlyShowPage.uiTextBox1.AppendText("\r\n[" + current_time.ToString("HH:mm:ss") + "]" + information.ToString());

                    }
                      )
                    );
                }
                catch (Exception ex)
                {
                    //响铃并显示异常给用户
                    System.Media.SystemSounds.Beep.Play();
                    MessageBox.Show(ex.Message);

                }

                uiButton2.Enabled = false;
                uiButton1.Enabled = true;
                CheckedData.Clear();
                start = 0;
            }
            else
            {
                MessageBox.Show("请保持一分半以上探伤时间");
            }
            
        }

        private double GetMax(List<byte> Data, int num)
        {
            double[] signal = new double[Data.Count()/40];
            for (int i = 0; i < (Data.Count() / 40); i++)
            {
                signal[i] = Data[num * 2 + i * 40] * 256 + Data[num * 2 + 1 + i * 40];
            }

            double[] Num = ReadTextFileToArray(NumFile);
            double[] Num1 = ReadTextFileToArray(NumFile1);

            MWArray signalMW = doubleToMWArray(signal);
            MWArray NumMW = doubleToMWArray(Num);
            MWArray Num1MW = doubleToMWArray(Num1);

            Class1 flfft = new Class1();

            object outputFlfftTmp = flfft.Flfft(NumMW, Num1MW, signalMW);

            double[] outputFlfft = (double[])((MWNumericArray)outputFlfftTmp).ToVector(MWArrayComponent.Real);

            double max = outputFlfft.Max();

            return max;

        }

        #region 将滤波器参数转化为double数组
        public double[] ReadTextFileToArray(string filePath)
        {
            double[] data;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                List<double> numbers = new List<double>();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(','); // split the line on commas
                    for (int i = 0; i < values.Length; i++)
                    {
                        numbers.Add(double.Parse(values[i]));
                    }
                }
                data = numbers.ToArray();
            }

            return data;
        }
        #endregion

        #region double转MWArray
        public MWArray doubleToMWArray(double[] inputArray)
        {
            double[,] temp = new double[inputArray.Length, 1];
            for (int i = 0; i < inputArray.Length; i++)
            {
                temp[i, 0] = inputArray[i];
            }
            MWArray mwArray = new MWNumericArray(temp);
            return mwArray;
        }
        #endregion
    }
}
