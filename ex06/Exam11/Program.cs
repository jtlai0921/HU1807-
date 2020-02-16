using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam11
{
  class Program
  {
    static void Main(string[] args)
    {
        int intA  = 10;
        int intB  = 3;
        char input;
        Console.Write("請輸入運算元（例如+ - * /）：");
        input = (char) (Console.Read());
        if (input == '+')
            Console.WriteLine("10 + 3 = {0}", intA + intB);
        else if (input == '-' )
            Console.WriteLine("10 - 3 = {0}", intA - intB);
        else if (input == '*' )
            Console.WriteLine("10 * 3 = {0}", intA * intB);
        else if (input == '/' )
            Console.WriteLine("10 / 3 = {0}", (double)intA / (double)intB);
        else
            Console.WriteLine("未知的運算元！");
        Console.ReadLine();
        Console.Read();
    }
  }
}
