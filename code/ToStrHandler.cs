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
            String newStr = "";
            if(charArry != null && charArry.Length > 0 )
            {
                List<String> list = new List<String>();
                // 判断是否每行多余一个字段
                String[] rowArrZero = charArry[0].Split(new String[] {"\t"}, StringSplitOptions.None);
                // 多列的情况
                if(rowArrZero != null && rowArrZero.Length > 1 ) {
                    foreach (var row in charArry)
                    {
                        String[] rowArr = row.Split(new String[] { "\t" }, StringSplitOptions.None);
                        List<String> colList = new List<String>();
                        foreach (var col in rowArr)
                        {
                            colList.Add(packBeforeStr + col + packAfterStr);
                        }
                        String result = "(" + string.Join(splitStr, colList) + ")";
                        list.Add(result);
                    }
                    newStr = string.Join(splitStr, list);

                } else
                // 单列的情况
                {
                    foreach (var item in charArry)
                    {
                        if (packBeforeStr != null && packBeforeStr.Length != 0 && packAfterStr != null && packAfterStr.Length != 0)
                        {
                            list.Add(packBeforeStr + item + packAfterStr);
                        }
                        else
                        {
                            list.Add(item);
                        }
                    }
                    newStr = string.Join(splitStr, list);
                }
            }
            return newStr;
        }
    }
}
