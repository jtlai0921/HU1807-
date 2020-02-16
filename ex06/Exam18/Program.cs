using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam18
{
  class Program
  {
    static void Main(string[] args)
    {
        int intA, intB;
        int i, j;
        int intAns=0 ;
        Console.Write("請輸入數字一：");
        intA = int.Parse(Console.ReadLine());
        Console.Write("請輸入數字二：");
        intB = int.Parse(Console.ReadLine());
        for (i = 1 ;i<=intB ;i++)
            intAns += intA;
        Console.WriteLine(intA + " * " + intB + " = " + intAns);
        Console.Read();
    }
  }
}
