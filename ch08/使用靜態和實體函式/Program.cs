using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用靜態和實體函式
{
  class StaticMethod
  {
    //在程式開始執行時即配置好記憶體
    public static void SayHello(string yourName)
    {
      Console.WriteLine("C# say Hello to " + yourName);
    }
  }

  class InstanceMethod
  {
    //在函式呼叫前才進行配置記憶體的動作
    public void SayHello(string yourName)
    {
      Console.WriteLine("C# say Hello to " + yourName);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      //注意實體函式和靜態函式的呼叫方式
      InstanceMethod instance = new InstanceMethod();
      instance.SayHello("初學者");

      StaticMethod.SayHello("程式老手");
      Console.ReadLine();
    }
  }
}
