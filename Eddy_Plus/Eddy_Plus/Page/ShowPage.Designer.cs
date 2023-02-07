
namespace Eddy_Plus.Page
{
    partial class ShowPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.chart_real1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.uiLedStopwatch1 = new Sunny.UI.UILedStopwatch();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTextBox1 = new Sunny.UI.UITextBox();
            this.uiPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_real1)).BeginInit();
            this.uiPanel1.SuspendLayout();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.chart_real1);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(256, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(544, 450);
            this.uiPanel2.TabIndex = 1;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // chart_real1
            // 
            chartArea11.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea11.AxisX.LabelStyle.Enabled = false;
            chartArea11.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea11.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea11.AxisX.MajorTickMark.Enabled = false;
            chartArea11.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea11.AxisX.MinorGrid.Enabled = true;
            chartArea11.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea11.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea11.AxisX.ScaleView.Size = 100D;
            chartArea11.AxisX.ScaleView.Zoomable = false;
            chartArea11.AxisX.ScrollBar.BackColor = System.Drawing.Color.Red;
            chartArea11.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Lime;
            chartArea11.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.SmallScroll;
            chartArea11.AxisX.ScrollBar.Enabled = false;
            chartArea11.AxisX.ScrollBar.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea11.AxisY.IsStartedFromZero = false;
            chartArea11.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisY.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea11.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea11.AxisY.MajorTickMark.Enabled = false;
            chartArea11.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea11.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea11.AxisY.MinorGrid.Enabled = true;
            chartArea11.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea11.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDot;
            chartArea11.Name = "ChartArea1";
            this.chart_real1.ChartAreas.Add(chartArea11);
            this.chart_real1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend11.Enabled = false;
            legend11.Name = "Legend1";
            this.chart_real1.Legends.Add(legend11);
            this.chart_real1.Location = new System.Drawing.Point(0, 0);
            this.chart_real1.Name = "chart_real1";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.MarkerSize = 3;
            series11.Name = "Err";
            this.chart_real1.Series.Add(series11);
            this.chart_real1.Size = new System.Drawing.Size(544, 450);
            this.chart_real1.TabIndex = 63;
            this.chart_real1.Text = "chart1";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiTextBox1);
            this.uiPanel1.Controls.Add(this.uiPanel3);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 0);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(256, 450);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.uiLedStopwatch1);
            this.uiPanel3.Controls.Add(this.uiLabel3);
            this.uiPanel3.Controls.Add(this.uiLabel2);
            this.uiPanel3.Controls.Add(this.uiLabel1);
            this.uiPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiPanel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(256, 203);
            this.uiPanel3.TabIndex = 5;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedStopwatch1
            // 
            this.uiLedStopwatch1.BackColor = System.Drawing.Color.Black;
            this.uiLedStopwatch1.ForeColor = System.Drawing.Color.Lime;
            this.uiLedStopwatch1.Location = new System.Drawing.Point(34, 149);
            this.uiLedStopwatch1.Name = "uiLedStopwatch1";
            this.uiLedStopwatch1.Size = new System.Drawing.Size(190, 34);
            this.uiLedStopwatch1.TabIndex = 8;
            this.uiLedStopwatch1.Text = "00:00";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(34, 102);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(129, 23);
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "该轮探伤用时：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(34, 47);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(165, 31);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "尚未开始探伤";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(34, 9);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "探伤结果：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBox1
            // 
            this.uiTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTextBox1.Location = new System.Drawing.Point(0, 203);
            this.uiTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBox1.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBox1.Multiline = true;
            this.uiTextBox1.Name = "uiTextBox1";
            this.uiTextBox1.ShowText = false;
            this.uiTextBox1.Size = new System.Drawing.Size(256, 247);
            this.uiTextBox1.TabIndex = 6;
            this.uiTextBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTextBox1.Watermark = "";
            this.uiTextBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ShowPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiPanel1);
            this.Name = "ShowPage";
            this.PageIndex = 1001;
            this.Text = "ShowPage";
            this.uiPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_real1)).EndInit();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel2;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart_real1;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIPanel uiPanel3;
        public Sunny.UI.UILedStopwatch uiLedStopwatch1;
        private Sunny.UI.UILabel uiLabel3;
        public Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        public Sunny.UI.UITextBox uiTextBox1;
    }
}