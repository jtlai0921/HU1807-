using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法成員
{
  class Program
  {
    static void Main(string[] args)
    {
      MyString objStr = new MyString();
      Console.Write("請輸入一字串：");
      objStr.HowLong(Console.ReadLine());
      Console.Read(); //暫停
    }
  }
}
