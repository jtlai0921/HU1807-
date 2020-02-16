using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam19
{
  class Program
  {
    static void Main(string[] args)
    {
      char input;
        Console.Write("請輸入選項 A - D：");
        input = (char) (Console.Read());
        switch (input)
        {
          case 'A':
          case 'a':
                Console.WriteLine("Apple");
                break;
          case 'B':
          case 'b':
                Console.WriteLine("Banana");
                break;
          case 'C':
          case 'c':
                Console.WriteLine("Candice");
                break;
          case 'D':
          case 'd':
                Console.WriteLine("Dig");
                break;
          default:
                Console.WriteLine("選項超出範圍！");
                break;
        }       
        Console.ReadLine();
        Console.Read();
    }
  }
}
