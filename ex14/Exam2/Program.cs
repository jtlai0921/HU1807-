using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
  class Program
  {
    static void Main(string[] args)
    {
        int input;
        try
        {
          try
          {
            Console.Write("請輸入一個整數：");
            input = int.Parse(Console.ReadLine());
            Console.WriteLine("您輸入的整數為：" + input);
          }
          catch (FormatException)
          {
            throw new InvalidCastException("輸入錯誤！");
          }
        }
        catch (InvalidCastException e)
        {
          Console.WriteLine(e.Message);
        }  
        Console.Read();
    }
  }
}
