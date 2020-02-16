using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 存放小數的差異
{
  class Program
  {
    static void Main(string[] args)
    {
      float a;
			double b;
			decimal c;
			a = 3.22222222222222222222222f;
			b = 3.22222222222222222222222;
			c = 3.22222222222222222222222m;
			
			Console.WriteLine ("使用單精度   a={0}",a);
			Console.WriteLine ("使用倍精度   a={0}",b);
			Console.WriteLine ("使用精確小數 a={0}",c);
      Console.Read();
    }
  }
}
