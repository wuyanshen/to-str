using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToStr
{
    internal class ToStrHandler
    {
        public static String toStr(string str) {

            String[] charArry = str.Split(new String[] { "\r\n" }, StringSplitOptions.None);
            Console.WriteLine(charArry);

            List<String> list = new List<String>();
            foreach (var item in charArry)
            {
                list.Add("'"+item+"'");
            }
            String newStr = string.Join(",", list);
            Console.WriteLine(newStr);
            return newStr;
        }
        
    }
}
