using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 函式的存取修飾詞
{
  class SuperClass        //父類別
  {
    public void F1()     //公開函式成員
    { Console.WriteLine("我是F1()函式==>公開的"); }

    private void F2()    //私有函式成員
    { Console.WriteLine("我是F2()函式==>私有的"); }

    protected void F3()  //保護函式成員
    { Console.WriteLine("我是F3()函式==>保護的"); }

    internal void F4()   //內部函式成員
    { Console.WriteLine("我是F4()函式==>內部的"); }
  }

  class DerivedClass : SuperClass  //子類別
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(args[0] + "類別");

      DerivedClass instance = new DerivedClass();
      instance.F1();   //無法存取父類別的私有成員
      instance.F3();
      instance.F4();
      Console.ReadLine();
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(args[0] + "類別");

      DerivedClass instance = new DerivedClass();
      instance.F1();   //僅能存取公開和內部成員
      instance.F4();
      Console.ReadLine();
    }
  }
}
