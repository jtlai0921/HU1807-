using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用new修飾詞
{
  class SuperClass
  {
    public virtual void PrintString(string s)     //虛擬函式
    {
      Console.Write("virtual修飾詞:" + s + "\n");
    }
  }

  class DerivedClass1 : SuperClass
  {
    public override void PrintString(string s)    //再定函式
    {
      Console.Write("override修飾詞:" + s + "\n");
    }
  }

  class DerivedClass2 : DerivedClass1
  {
    new public void PrintString(string s)         //新定函式
    {
      Console.Write("new修飾詞:" + s + "\n");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      //在繼承關係下這樣的指定是合法的
      DerivedClass2 a = new DerivedClass2();
      DerivedClass1 b = a;
      SuperClass c = a;

      a.PrintString("測試字串");   //呼叫DerivedClass2.PrintString()
      b.PrintString("測試字串");   //呼叫DerivedClass1.PrintString()
      c.PrintString("測試字串");   //呼叫DerivedClass1.PrintString()
      Console.ReadLine();
    }
  }
}
