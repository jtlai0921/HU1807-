using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 宣告類別成員
{
  class Program
  {
    static void Main(string[] args)
    {
      foo obj1 = new foo();
      obj1.strData = "字串資料設定";
      obj1.intData = 100;
      Console.WriteLine("foo 類別的 strData 成員：" + obj1.strData);
      Console.WriteLine("foo 類別的 intData 成員：" + obj1.intData);
      Console.Read();
    }
  }
}
