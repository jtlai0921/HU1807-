using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
  class Program
  {
    static string strReverse(string str)
    {
        char[] charArray;
        string strR = "";
        int i;
        charArray = str.ToCharArray();
        for (i = charArray.Length - 1; i >= 0; i--)
          strR += charArray[i];
        return strR;
    }

    static void Main(string[] args)
    {
        string str;
        Console.Write("請輸入字串：");
        str = Console.ReadLine();
        Console.WriteLine("反轉字串：" + strReverse(str));
        Console.ReadLine();    
    }
  }
}
