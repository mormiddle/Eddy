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
    public partial class TableShow : Form
    {
        public TableShow()
        {
            InitializeComponent();
        }

        private void TableShow_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“crackDataDataSet.crackdata”中。您可以根据需要移动或删除它。
            this.crackdataTableAdapter.Fill(this.crackDataDataSet.crackdata);

        }
    }
}
