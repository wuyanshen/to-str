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
        public static String toStr(String str, String packBeforeStr, String packAfterStr, String splitStr=",") {
            String[] charArry = str.Split(new String[] { "\r\n" }, StringSplitOptions.None);
            List<String> list = new List<String>();
            foreach (var item in charArry)
            {
                if(packBeforeStr != null && packBeforeStr.Length!=0 && packAfterStr!=null && packAfterStr.Length!=0)
                {
                    list.Add(packBeforeStr + item + packAfterStr);
                } else
                {
                    list.Add(item);
                }
            }
            String newStr = string.Join(splitStr, list);
            return newStr;
        }
    }
}
