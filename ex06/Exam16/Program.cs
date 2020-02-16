using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam16
{
  class Program
  {
    static void Main(string[] args)
    {
      int input;
        Console.Write("請輸入西元年份：");
        input = int.Parse(Console.ReadLine());
        if( (input % 4 == 0) && (input % 100 != 0) )
            Console.WriteLine(input + " 為閏年");
        else if ((input % 100 == 0) && (input % 400 == 0))
            Console.WriteLine(input + " 為閏年");
        else
            Console.WriteLine(input + " 不為閏年");
        Console.Read();
    }
  }
}
