using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam10
{
  class Program
  {
    static void Main(string[] args)
    {
      int intTmp;
        Console.Write("請輸入一個英文字母：");
        intTmp = Console.Read();
        if (intTmp > 64 && intTmp < 91) {
          Console.WriteLine("輸入字元為大寫字母。");
            intTmp += 32;
            Console.WriteLine("轉為小寫字母：" + Convert.ToString((char) intTmp));
        }
      else 
      {
        Console.WriteLine("輸入字元不是大寫字母。");
        Console.WriteLine("輸入字元：" + Convert.ToString((char) intTmp));
      } 
        Console.ReadLine();
        Console.Read();
    }
  }
}
