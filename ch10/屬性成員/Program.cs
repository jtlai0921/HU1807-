using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 屬性成員
{
  class Program
  {
    static void Main(string[] args)
    {
      circle objC1 = new circle();
      Console.Write("請輸入半徑資訊：");
      objC1.radius = float.Parse(Console.ReadLine());
      Console.WriteLine("半徑：" + objC1.radius);
      Console.Read(); //暫停
    }
  }
}
