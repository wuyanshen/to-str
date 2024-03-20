using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToStr
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }


        //static void Main()
        //{
        //    String str = "958\r\n881\r\n862\r\n3958\r\n3869\r\n3833";
        //    ToStrHandler.toStr(str);
        //}
    }
}
