using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eddy
{
    public partial class ChartShow : Form
    {
        public ChartShow()
        {
            InitializeComponent();
        }

        private void ChartShow_Load(object sender, EventArgs e)
        {

            //设置网格
            this.ChartDataShow.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            this.ChartDataShow.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            this.ChartDataShow.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.FromArgb(64, 64, 64, 64);
            this.ChartDataShow.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            this.ChartDataShow.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            this.ChartDataShow.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;

            //设置直方图柱条宽度
            this.ChartDataShow.Series[0]["PointWidth"] = "1";


            for (int i = 1; i < 38; i++)
            {
                this.ChartDataShow.Series[0].Points.Add(i, i*100);

            }
           
          
        }
    }
}
