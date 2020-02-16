using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用建構函式
{
  class SuperClass : Object //System.Object類別為所有類別之父類別
  {
    public SuperClass() //建構函式,預設是使用base()初始函式
    {
      Console.WriteLine("I'm SuperClass...");
    }
  }

  class ChildClass1 : SuperClass
  {
    //不顯性定義,使用預設的建構函式    
  }

  class ChildClass2 : ChildClass1
  {
    public ChildClass2(): base()
    {
      Console.WriteLine("I'm ChildClass2...");
    }

    //this()等於ChildClass2.ChildClass2()
    public ChildClass2(string s): this()   
    {
      Console.WriteLine("回應: " + s);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      new ChildClass2();
      new ChildClass2("C#愛大家...");
      Console.ReadLine();
    }
  }
}
