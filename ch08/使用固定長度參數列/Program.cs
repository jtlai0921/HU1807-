using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用固定長度參數列
{
  class Call_By_Value
  {
    public static void Zero(int a, int b, int c)
    {
      a = b = c = 0;  //將傳入參數設定為0 
      Console.WriteLine("a={0} b={1} c={2}", a, b, c);
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      int a=1;        //a,b,c為Main()函式中的區域變數
      int b=2;
      int c=3;

      Call_By_Value.Zero(a,b,c);   //傳入固定長度參數
      Console.WriteLine("a={0} b={1} c={2}",a,b,c);
      Console.Read();
    }
  }
}
