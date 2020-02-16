using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam20
{
  class Program
  {
    static void Main(string[] args)
    {
      int Day=0, Height=0;
        while (true)
        {
           Day += 1;
            Height += 5;
            if (Height < 15)
                Height -= 2;
            else
                break;
        }
        Console.WriteLine("蝸牛共花 " + Day + " 天爬上牆頭。");
        Console.Read();
    }
  }
}
