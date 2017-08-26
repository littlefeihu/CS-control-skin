using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace wind
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
            DevComponents.DotNetBar.LocalizationKeys.LocalizeString += new DevComponents.DotNetBar.DotNetBarManager.LocalizeStringEventHandler(LocalizeString);
            Application.Run(new FrmTest());
        }

        private static void LocalizeString(object sender, DevComponents.DotNetBar.LocalizeEventArgs e)
        {
            if (e.Key == LocalizationKeys.MessageBoxOkButton)
            {
                e.LocalizedValue = "自定义";
                e.Handled = true;
            }
        }

    }
}
