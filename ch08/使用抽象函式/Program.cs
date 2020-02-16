using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用抽象函式
{
  abstract class AbstractClass1                  //抽象父類別
  {
    public abstract void EchoString(string s);
  }

  abstract class AbstractClass2 : AbstractClass1    //抽象子類別
  {
    public abstract string GetString();
  }

  class Implement : AbstractClass2               //繼承抽象類別
  {
    public override void EchoString(string s)     //實作抽象父類別之抽象函式
    {
      Console.WriteLine("您輸入的是: " + s);
    }

    public override string GetString()           //實作抽象子類別之抽象函式
    {
      Console.Write("請輸入字串: ");
      return Console.ReadLine();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Implement i = new Implement();

      i.EchoString(i.GetString());              //呼叫實作後的函式
      Console.ReadLine();
    }
  }
}
