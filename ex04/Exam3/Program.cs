using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
  class Program
  {
    static void Main(string[] args)
    {  
        int a, b;
        bool result1;
        a = 13;
        b = 12;
        result1 = (a < b);  //判斷a是否等於b
        Console.WriteLine("a=13");
        Console.WriteLine("b=12");
        Console.WriteLine("a< b的比較結果=" + result1); //將result1顯示出來
        Console.Read(); //暫停
    }
  }
}
