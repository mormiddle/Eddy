
namespace Eddy
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton_history = new FontAwesome.Sharp.IconButton();
            this.iconButton_Table = new FontAwesome.Sharp.IconButton();
            this.iconButton_chart = new FontAwesome.Sharp.IconButton();
            this.iconButton_stop = new FontAwesome.Sharp.IconButton();
            this.iconButton_begin = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel_Show = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel_State = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_MaxCrack = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelShow.SuspendLayout();
            this.panel_Show.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel_State.SuspendLayout();
            this.panel_MaxCrack.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.iconButton_history);
            this.panelMenu.Controls.Add(this.iconButton_Table);
            this.panelMenu.Controls.Add(this.iconButton_chart);
            this.panelMenu.Controls.Add(this.iconButton_stop);
            this.panelMenu.Controls.Add(this.iconButton_begin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1047, 60);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton_history
            // 
            this.iconButton_history.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_history.FlatAppearance.BorderSize = 0;
            this.iconButton_history.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButton_history.IconColor = System.Drawing.Color.Black;
            this.iconButton_history.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_history.IconSize = 40;
            this.iconButton_history.Location = new System.Drawing.Point(483, 0);
            this.iconButton_history.Name = "iconButton_history";
            this.iconButton_history.Size = new System.Drawing.Size(80, 60);
            this.iconButton_history.TabIndex = 9;
            this.iconButton_history.UseVisualStyleBackColor = true;
            // 
            // iconButton_Table
            // 
            this.iconButton_Table.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_Table.FlatAppearance.BorderSize = 0;
            this.iconButton_Table.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.iconButton_Table.IconColor = System.Drawing.Color.Black;
            this.iconButton_Table.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Table.IconSize = 40;
            this.iconButton_Table.Location = new System.Drawing.Point(403, 0);
            this.iconButton_Table.Name = "iconButton_Table";
            this.iconButton_Table.Size = new System.Drawing.Size(80, 60);
            this.iconButton_Table.TabIndex = 8;
            this.iconButton_Table.UseVisualStyleBackColor = true;
            // 
            // iconButton_chart
            // 
            this.iconButton_chart.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_chart.FlatAppearance.BorderSize = 0;
            this.iconButton_chart.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButton_chart.IconColor = System.Drawing.Color.Black;
            this.iconButton_chart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_chart.IconSize = 40;
            this.iconButton_chart.Location = new System.Drawing.Point(323, 0);
            this.iconButton_chart.Name = "iconButton_chart";
            this.iconButton_chart.Size = new System.Drawing.Size(80, 60);
            this.iconButton_chart.TabIndex = 7;
            this.iconButton_chart.UseVisualStyleBackColor = true;
            // 
            // iconButton_stop
            // 
            this.iconButton_stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_stop.FlatAppearance.BorderSize = 0;
            this.iconButton_stop.IconChar = FontAwesome.Sharp.IconChar.Pause;
            this.iconButton_stop.IconColor = System.Drawing.Color.Black;
            this.iconButton_stop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_stop.IconSize = 40;
            this.iconButton_stop.Location = new System.Drawing.Point(243, 0);
            this.iconButton_stop.Name = "iconButton_stop";
            this.iconButton_stop.Size = new System.Drawing.Size(80, 60);
            this.iconButton_stop.TabIndex = 6;
            this.iconButton_stop.UseVisualStyleBackColor = true;
            // 
            // iconButton_begin
            // 
            this.iconButton_begin.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton_begin.FlatAppearance.BorderSize = 0;
            this.iconButton_begin.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.iconButton_begin.IconColor = System.Drawing.Color.Black;
            this.iconButton_begin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_begin.IconSize = 40;
            this.iconButton_begin.Location = new System.Drawing.Point(163, 0);
            this.iconButton_begin.Name = "iconButton_begin";
            this.iconButton_begin.Size = new System.Drawing.Size(80, 60);
            this.iconButton_begin.TabIndex = 1;
            this.iconButton_begin.UseVisualStyleBackColor = true;
            this.iconButton_begin.Click += new System.EventHandler(this.iconButton_begin_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(163, 60);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.Image = global::Eddy.Properties.Resources.横板logo;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(163, 60);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 200;
            this.comboBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(116, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.panel_Show);
            this.panelShow.Controls.Add(this.panel_State);
            this.panelShow.Controls.Add(this.panel_MaxCrack);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 60);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1047, 541);
            this.panelShow.TabIndex = 1;
            // 
            // panel_Show
            // 
            this.panel_Show.Controls.Add(this.chart1);
            this.panel_Show.Controls.Add(this.panel1);
            this.panel_Show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Show.Location = new System.Drawing.Point(263, 100);
            this.panel_Show.Name = "panel_Show";
            this.panel_Show.Size = new System.Drawing.Size(784, 441);
            this.panel_Show.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 5D;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.Maximum = 60D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.Maximum = 30D;
            chartArea1.AxisY.Minimum = -30D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Gray;
            series1.Legend = "Legend1";
            series1.Name = "standard";
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series2.Legend = "Legend1";
            series2.Name = "standard2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.MarkerSize = 3;
            series3.Name = "Err";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(644, 441);
            this.chart1.TabIndex = 57;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(644, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 441);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(34, 336);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 40);
            this.button3.TabIndex = 67;
            this.button3.Text = "下移";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(34, 271);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 40);
            this.button2.TabIndex = 66;
            this.button2.Text = "上移";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(34, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 40);
            this.button1.TabIndex = 65;
            this.button1.Text = "自动适应";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(34, 139);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(72, 40);
            this.btnStop.TabIndex = 64;
            this.btnStop.Text = "停止波形";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(34, 64);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(72, 40);
            this.btnStart.TabIndex = 63;
            this.btnStart.Text = "开始波形";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panel_State
            // 
            this.panel_State.Controls.Add(this.label4);
            this.panel_State.Controls.Add(this.label3);
            this.panel_State.Controls.Add(this.label2);
            this.panel_State.Controls.Add(this.comboBox1);
            this.panel_State.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_State.Location = new System.Drawing.Point(0, 100);
            this.panel_State.Name = "panel_State";
            this.panel_State.Size = new System.Drawing.Size(263, 441);
            this.panel_State.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "探伤时长：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "探头状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "设备串口：";
            // 
            // panel_MaxCrack
            // 
            this.panel_MaxCrack.Controls.Add(this.label1);
            this.panel_MaxCrack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_MaxCrack.Location = new System.Drawing.Point(0, 0);
            this.panel_MaxCrack.Name = "panel_MaxCrack";
            this.panel_MaxCrack.Size = new System.Drawing.Size(1047, 100);
            this.panel_MaxCrack.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(235, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大裂纹深度：";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 601);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainFrom";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.panel_Show.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel_State.ResumeLayout(false);
            this.panel_State.PerformLayout();
            this.panel_MaxCrack.ResumeLayout(false);
            this.panel_MaxCrack.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton_begin;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.PictureBox btnHome;
        private System.IO.Ports.SerialPort serialPort1;
        private FontAwesome.Sharp.IconButton iconButton_stop;
        private FontAwesome.Sharp.IconButton iconButton_history;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel_State;
        private System.Windows.Forms.Panel panel_MaxCrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Show;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton_Table;
        private FontAwesome.Sharp.IconButton iconButton_chart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
    }
}

