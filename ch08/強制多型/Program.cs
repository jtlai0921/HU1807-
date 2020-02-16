using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 強制多型
{
  class SuperClass   //父類別
  {
    public virtual void EchoString(string s)
    {
      Console.WriteLine("多型父類別: " + s);
    }
  }

  class DerivedClass1 : SuperClass  //子類別1
  {
    //在繼承下,此子類別直接包含了父類別的虛擬函式
  }

  class DerivedClass2 : SuperClass  //子類別2
  {
    public override void EchoString(string s)
    {
      base.EchoString(s);         //呼叫SuperClass.EchoString()函式
    }
  }

  abstract class ForcedPolymorphism : SuperClass  //實作強制多型
  {
    public abstract override void EchoString(string s);
  }

  class DerivedClass3 : ForcedPolymorphism  //子類別3
  {
    public override void EchoString(string s)    //一定得重新定義
    {
      Console.WriteLine("多型子類別: " + s);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      SuperClass[] instance = {new DerivedClass1(),
                          new DerivedClass2(),
                          new DerivedClass3()};
      
      //測試多型結果 
      instance[0].EchoString("測試字串");  
      instance[1].EchoString("測試字串"); 
      instance[2].EchoString("測試字串");
      Console.ReadLine();
    }
  }
}
