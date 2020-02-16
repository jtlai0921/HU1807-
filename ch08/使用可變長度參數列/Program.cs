using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用可變長度參數列
{
  class Call_By_Value
  {
    public static void EchoParamters(params string[] args)
    {
      for (int i = 0; i < args.Length; i++)    //args.Length為傳入參數個數  
      {
        Console.Write("參數{0}:" + args[i] + " ", i);
      }
      Console.WriteLine("\n回應" + args.Length + "個參數");
    }
  }

  class Program
  {
    static void Main()
    {
      string[] args = { "香蕉", "鳳梨" };

      Call_By_Value.EchoParamters();                  //傳入零個參數
      Call_By_Value.EchoParamters(args);               //傳入參數陣列
      Call_By_Value.EchoParamters("我", "LOVE", "C#..."); //傳入三個參數
      Console.ReadLine();

    }
  }
}
