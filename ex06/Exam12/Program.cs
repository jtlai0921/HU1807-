using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam12
{
  class Program
  {
    static void Main(string[] args)
    {
      int intA = 10;
      int intB = 3;
      char input;
      Console.Write("請輸入運算元（例如+ - * /）：");
      input = (char)(Console.Read());
      switch (input)
      {
        case '+':
          Console.WriteLine("10 + 3 = {0}", intA + intB);
          break;
        case '-':
          Console.WriteLine("10 - 3 = {0}", intA - intB);
          break;
        case '*':
          Console.WriteLine("10 * 3 = {0}", intA * intB);
          break;
        case '/':
          Console.WriteLine("10 / 3 = {0}", (double)intA / (double)intB);
          break;
        default:
          Console.WriteLine("未知的運算元！");
          break;
      } 
      Console.ReadLine();
      Console.Read();
    }
  }
}
