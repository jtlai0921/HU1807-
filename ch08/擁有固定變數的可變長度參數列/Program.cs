using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 擁有固定變數的可變長度參數列
{
  class Call_By_Value
  {
    public static void EchoString(string s, params string[] args)
    {
      Console.WriteLine(s);
      foreach (string p in args)
        Console.WriteLine(p);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      //使用命令列參數當作函式的可變長度參數
      Call_By_Value.EchoString("我愛C#...");
      Call_By_Value.EchoString("我愛C#...", args);
      Console.ReadLine();
    }
  }
}
