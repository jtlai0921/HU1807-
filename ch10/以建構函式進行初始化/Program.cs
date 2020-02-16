using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以建構函式進行初始化
{
  class MultiConstructor
  {
    //資料成員
    protected int a;
    protected float b;
    protected string c;

    //多載建構函式
    public MultiConstructor() { }

    public MultiConstructor(int i) : this(i, 0, "") { }

    public MultiConstructor(int i, float f) : this(i, f, "") { }

    public MultiConstructor(int i, float f, string s)
    {
      this.a = i;
      this.b = f;
      this.c = s;
    }

    //函式成員,列印資料成員在螢幕上
    public void PrintDataMember()
    {
      Console.WriteLine("a={0} b={1} c={2}", a, b, c);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      //在生成實體物件時使用多載建構函式
      MultiConstructor instance1 = new MultiConstructor();
      MultiConstructor instance2 = new MultiConstructor(5);
      MultiConstructor instance3 = new MultiConstructor(15, 1.0f, "C#");

      //列印資料成員
      instance1.PrintDataMember();
      instance2.PrintDataMember();
      instance3.PrintDataMember();
      Console.ReadLine();
    }
  }
}
