using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property函式
{
  class Program
  {
    static void Main(string[] args)
    {
        circle objC1 = new circle();
        Console.Write("請輸入半徑資訊：");
        objC1.radius = float.Parse(Console.ReadLine());
        Console.WriteLine("半徑：" + objC1.radius);
        Console.WriteLine("面積：" + objC1.area);
        Console.Write("請輸入面積資訊：");
        objC1.area = float.Parse(Console.ReadLine());
        Console.WriteLine("半徑：" + objC1.radius);
        Console.WriteLine("面積：" + objC1.area);
        Console.Read(); //暫停
    }
  }
}
