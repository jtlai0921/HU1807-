using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 左側結合的比較
{
  class Program
  {
    static void Main(string[] args)
    {
      int A,B=10,C=2,D=5,E=15;		

			Console.WriteLine ("B={0} C={1} D={2} E={3}",B,C,D,E);
			A=B*C%E/D;
			Console.WriteLine ("算式 B*C%D/E= {0}",A);
			A=B*(C%D)/E;
			Console.WriteLine ("算式 B*(C%D)/E= {0}",A);
			A=((B*C)%E)/D;
			Console.WriteLine ("算式 ((B*C)%D)/E= {0}",A);
			A=(B*C)%(E/D);
			Console.WriteLine ("算式 (B*C)%(D/E)= {0}",A);
      Console.Read();
    }
  }
}
