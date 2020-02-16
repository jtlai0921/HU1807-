using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 唯讀與唯寫
{
  class Program
  {
    static void Main(string[] args)
    {
      square objS1 = new square();
      Console.Write("請輸入邊長資訊：");
      objS1.length = float.Parse(Console.ReadLine());
      Console.WriteLine("面積：" + objS1.area);
      Console.Read(); //暫停
    }
  }
}
