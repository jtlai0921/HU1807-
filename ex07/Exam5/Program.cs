using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam5
{
  class Program
  {
    static int count;

    static int Fibonacci(int n) 
    {
      if (n <= 1)
        return n;
      else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
        
     static void Main(string[] args)
     {
        int n;
        Console.Write("請輸入n值：");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("求解費氏數列 F({0}) = {1}", n, Fibonacci(n));
        Console.ReadLine();
     }
  }
}
