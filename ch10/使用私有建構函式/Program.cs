using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用私有建構函式
{
  class PrivateConstructor
  {
    private PrivateConstructor() { }     //僅包含私有建構函式

    static void EchoString(string s)    //私有靜態函式成員,輸出字串
    {
      Console.WriteLine("回應: " + s);
    }

    static string GetString()           //私有靜態函式成員,讀取字串
    {
      Console.Write("輸入: ");
      return Console.ReadLine();
    }

    public static void StringIO()      //公開靜態成員,字串IO
    {
      EchoString(GetString());
    }
  }

  class UseStringIO_1
  {
    public UseStringIO_1()
    {
      Console.WriteLine("UseStringIO_1類別");
      PrivateConstructor.StringIO(); //呼叫共用函式 
    }
  }

  class UseStringIO_2
  {
    public UseStringIO_2()
    {
      Console.WriteLine("UseStringIO_2類別");
      PrivateConstructor.StringIO(); //呼叫共用函式
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      new UseStringIO_1();
      new UseStringIO_2();
      Console.ReadLine();
    }
  }
}
