using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam13
{
  class Program
  {
    static void Main(string[] args)
    {
      int input;
      Console.Write("請輸入一個字元：");
      input = Console.Read();
      if (input >= 48 && input <= 57)
      {
        //** Unicode數字編碼範圍
        Console.WriteLine("您所輸入的是數字。");
      }
      else if (input >= 65 && input <= 90)
      {
        //** Unicode大寫字母編碼範圍
        Console.WriteLine("您所輸入的是大寫字母。");
      }
      else if (input >= 97 && input <= 122)
      {
        //** Unicode小寫字母編碼範圍
        Console.WriteLine("您所輸入的是小寫字母。");
      }
      else
        Console.WriteLine("非數字或字母字元。");
      Console.ReadLine();
      Console.Read();
    }
  }
}
