using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HslCommunication;
using HslCommunication.Profinet.Siemens;

namespace Eddy
{
    public partial class MainForm : Form
    {
        
        private Form currentChildForm;//创建子窗体变量
        private IconButton currentBtn;//声明全局按键，用来判断当前哪个按键起作用
        private List<byte> buffer = new List<byte>(); //设置缓存处理CRC32串口的校验
        private int ReceiveDataNum = 40;   //数据位  40 个字节
        private int ReceiveCheckIndex = 42; //检验位一个字节，帧头一字节，len一字节，数据位加校验位41个字节，所以校验位是第43位，即数组index=42
        private List<byte> SerialPortCheckedData = new List<byte>(); //用于存储串口的数据
        private SiemensS7Net plc;//声明plc的连接
        private System.Threading.Thread thread;//声明一个线程，用于实时读取plc

        public MainForm()
        {
            InitializeComponent();
            //设置拖拽分屏
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            Update_Serial_List();

            /*#region PLC连接
            plc = new SiemensS7Net(SiemensPLCS.S300, "192.168.1.188");//输入对应的ip
            OperateResult connect = plc.ConnectServer();
            if (!connect.IsSuccess) MessageBox.Show("Connect Failed: " + connect.Message);
            #endregion*/

        }




        #region 打开子窗口
        private void OpenChildFrom(Form childForm)
        {
            if (currentChildForm != null)
            {
                //确保只有一个窗口
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;//设置并非顶级控件，会导致无法加入到panel中
            childForm.FormBorderStyle = FormBorderStyle.None;//设置窗口没有边框
            childForm.Dock = DockStyle.Fill;//设置满填充
            panelShow.Controls.Add(childForm);//窗口添加到panel中
            panelShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion


        private void iconButton_Table_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new TableShow());
            iconButton_Table.Enabled = false;
           
        }

        private void iconButton_chart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new ChartShow());           
            iconButton_chart.Enabled = false;                       
        }

        private void iconButton_history_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildFrom(new HistoryShow());
            iconButton_history.Enabled = false;
        }

        #region 扫描串口
        private void Update_Serial_List()
        {
            try
            {
                /* 搜索串口 */
                String[] cur_port_list = System.IO.Ports.SerialPort.GetPortNames();

                /* 刷新串口列表comboBox */
                int count = comboBox1.Items.Count;
                if (count == 0)
                {
                    //combox中无内容，将当前串口列表全部加入
                    comboBox1.Items.AddRange(cur_port_list);
                    return;
                }
                else
                {
                    //combox中有内容

                    //判断有无新插入的串口
                    for (int i = 0; i < cur_port_list.Length; i++)
                    {
                        if (!comboBox1.Items.Contains(cur_port_list[i]))
                        {
                            //找到新插入串口，添加到combox中
                            comboBox1.Items.Add(cur_port_list[i]);
                        }
                    }

                    //判断有无拔掉的串口
                    for (int i = 0; i < count; i++)
                    {
                        if (!search_port_is_exist(comboBox1.Items[i].ToString(), cur_port_list))
                        {
                            //找到已被拔掉的串口，从combox中移除
                            comboBox1.Items.RemoveAt(i);
                        }
                    }
                }

                /* 如果当前选中项为空，则默认选择第一项 */
                if (comboBox1.Items.Count > 0)
                {
                    if (comboBox1.Text.Equals(""))
                    {
                        //软件刚启动时，列表项的文本值为空
                        comboBox1.Text = comboBox1.Items[0].ToString();
                    }
                }
                else
                {
                    //无可用列表，清空文本值
                    comboBox1.Text = "";
                }


            }
            catch (Exception)
            {
                //当下拉框被打开时，修改下拉框会发生异常
                return;
            }
        }

        private bool search_port_is_exist(String item, String[] port_list)
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

        #region 开始按键
        private void iconButton_begin_Click(object sender, EventArgs e)
        {
            #region 开启串口
            try
            {
                //将可能产生异常的代码放置在try块中
                //根据当前串口属性来判断是否打开
                if (serialPort1.IsOpen)
                {
                    //串口已经处于打开状态
                    serialPort1.Close();    //关闭串口
                    iconButton_begin.BackColor = Color.Transparent;
                    comboBox1.Enabled = true;
                }
                else
                {
                    //串口已经处于关闭状态，则设置好串口属性后打开
                    comboBox1.Enabled = false;
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32("115200");
                    serialPort1.DataBits = Convert.ToInt16("8");
                    serialPort1.Parity = System.IO.Ports.Parity.None;
                    serialPort1.StopBits = System.IO.Ports.StopBits.One;
                    serialPort1.Open();     //打开串口
                    iconButton_begin.BackColor = Color.ForestGreen;
                }
            }
            catch (Exception ex)
            {
                //捕获可能发生的异常并进行处理

                //捕获到异常，创建一个新的对象，之前的不可以再用
                serialPort1 = new System.IO.Ports.SerialPort();
                //刷新COM口选项
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                //响铃并显示异常给用户
                System.Media.SystemSounds.Beep.Play();
                iconButton_begin.BackColor = Color.ForestGreen;
                MessageBox.Show(ex.Message);
                comboBox1.Enabled = true;
            }
            #endregion

            #region 开启plc进程
            /*// 启动线程
            thread = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadRead));
            thread.IsBackground = true;
            thread.Start();
            iconButton_begin.Enabled = false;   // 启动之后，禁用button*/
            #endregion
        }
        #endregion

        #region 线程实时读取函数
        /*private void ThreadRead()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                OperateResult<short> read1 = plc.ReadInt16("DB1.14");//读取short
                if (!read1.IsSuccess) { MessageBox.Show("Read Failed: " + read1.Message); return; }

                OperateResult<float> read2 = plc.ReadFloat("DB1.16");
                if (!read1.IsSuccess) { MessageBox.Show("Read Failed: " + read1.Message); return; }


                // 下面需要使用跨UI线程来更新界面，不然会报错
                *//*Invoke(new Action(() =>
                {
                    if (read1.IsSuccess)
                    {
                        textBox1.Text = $"Value[{DateTime.Now:HH:mm:ss}]：" + read1.Content;
                        // 为了看清楚是否发生了读取，显示时候顺便显示下时间
                        textBox2.Text = $"Value[{DateTime.Now:HH:mm:ss}]：" + read2.Content;
                        // 为了看清楚是否发生了读取，显示时候顺便显示下时间
                    }
                    else
                    {
                        textBox1.Text = $"Read failed[{DateTime.Now:HH:mm:ss}]: " + read1.Message;
                    }
                }));*//*
            }

        }*/
        #endregion

        #region 按键切换设置
        /// <summary>
        /// 改变点击之后的按键颜色
        /// </summary>
        /// <param name="senderBtn">按键控件</param>
        private void ActivateButton(object senderBtn)
        {
            if ( senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.ForestGreen;
            }
        }

        /// <summary>
        /// 重置上一个按键
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Enabled = true;
                currentBtn.BackColor = Color.Transparent;
            }
        }
        #endregion

        #region 串口接收函数
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int num = serialPort1.BytesToRead;      //获取接收缓冲区中的字节数
            if (num == 0)
            {
                return;
            }
            byte[] received_buf = new byte[num];    //声明一个大小为num的字节数据用于存放读出的byte型数据

            serialPort1.Read(received_buf, 0, num);   //读取接收缓冲区中num个字节到byte数组中
         
            buffer.AddRange(received_buf); //缓存数据

            int index = 1;
            while (buffer.Count > 0x2C) //最短协议长度
            {
                if (buffer[0] == 0xAA) //协议头
                {
                    if (buffer[index] != 0x80) //查询协议尾
                    {
                        index++;

                        if (index > buffer.Count) //没有接收到0x80协议尾
                        {
                            break; //退出继续接收 
                        }
                    }
                    else //接收到协议尾  得到完整一帧数据
                    {
                        byte[] ReceiveBytes = new byte[ReceiveDataNum];//数据位
                        buffer.CopyTo(2, ReceiveBytes, 0, ReceiveDataNum);

                        var randomCrc = CRC8(ReceiveBytes);//上位机计算的校验位
                        if (randomCrc == buffer[ReceiveCheckIndex]) //和传入的校验位进行校验
                        {
                            foreach (byte item in ReceiveBytes)
                            {

                                SerialPortCheckedData.Add(item);
                            }
                        }

                        buffer.RemoveRange(0, index);
                    }
                }
                else
                {
                    buffer.RemoveAt(0);
                }
            }
        }
        #endregion

        #region CRC8校验函数
        public static byte CRC8(byte[] buffer)
        {
            byte crc = 0;
            for (int j = 0; j < buffer.Length; j++)
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
    }
}
