using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 指定數值顯示
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 1433545;

			Console.WriteLine ("使用貨幣表示      ：{0:C2}",a);
			Console.WriteLine ("使用十進位表示    ：{0:D2}",a);
			Console.WriteLine ("使用十六進位表示  ：{0:X2} {1:x2}",a,a);
			Console.WriteLine ("使用數字表示      ：{0:N2}",a);
			Console.WriteLine ("使用科學表示式表示：{0:G2} {1:g2}",a,a);
			Console.WriteLine ("使用指數表示      ：{0:E2} {1:e2}",a,a);
			Console.WriteLine ("使用浮點數表示    ：{0:F2}",a);
      Console.Read();
    }
  }
}
