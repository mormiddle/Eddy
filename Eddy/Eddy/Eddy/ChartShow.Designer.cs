
namespace Eddy
{
    partial class ChartShow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartDataShow = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDataShow
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.Maximum = 38D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.ChartDataShow.ChartAreas.Add(chartArea1);
            this.ChartDataShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartDataShow.Location = new System.Drawing.Point(0, 0);
            this.ChartDataShow.Name = "ChartDataShow";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.ChartDataShow.Series.Add(series1);
            this.ChartDataShow.Size = new System.Drawing.Size(1047, 541);
            this.ChartDataShow.TabIndex = 1;
            this.ChartDataShow.Text = "chart1";
            this.ChartDataShow.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.Normal;
            // 
            // ChartShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 541);
            this.ControlBox = false;
            this.Controls.Add(this.ChartDataShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChartShow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ChartShow";
            this.Load += new System.EventHandler(this.ChartShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartDataShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartDataShow;
    }
}