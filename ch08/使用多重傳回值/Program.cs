using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多重傳回值
{
  class Call_By_Refrence
  {
    public static void ReturnMultipleValue(out int j, out int k)
    {
      j = k = 100;  //指定多重傳回值
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      int a, b;   //請注意變數a和b並沒有指定初值

      Call_By_Refrence.ReturnMultipleValue(out b, out a);
      Console.WriteLine("a={0} b={1}", a, b);
      Console.ReadLine();
    }
  }
}
