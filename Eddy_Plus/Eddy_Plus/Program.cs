using Sunny.UI.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eddy_Plus
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            if (fLogin.IsLogin)
            {
                fLogin.Dispose();
                Application.Run(new FHeaderAsideMain());
            }

    
        }
    }
}
