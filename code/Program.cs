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
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainFrm());
        }


        //static void Main()
        //{
        //    String str = "958\r\n881\r\n862\r\n3958\r\n3869\r\n3833";

        //    //ToStrHandler.toStr(str);

        //    String newStr = "126\t44\t23\t832\t个\t黑色\tiphone14\r\n127\t44\t23\t833\t台\t黑色\t联想ThinkPad";

        //    String ss = ToStrHandler.toStr(newStr, "'", "'");
        //    Console.WriteLine(ss);
        //}
    }
}
