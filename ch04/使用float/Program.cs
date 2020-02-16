using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用float
{
  class Program
  {
    static void Main(string[] args)
    {
      float a = 1f,b=0f,c=-1f,d=-0f,f=3.0f;
			float e=99999999999999f,g=1e5f;

			Console.WriteLine ("a= {0}",a);
			Console.WriteLine ("b= {0}",b);
			Console.WriteLine ("c= {0}",c);
			Console.WriteLine ("d= {0}",d);
			Console.WriteLine ("e= {0}",e);
			Console.WriteLine ("f= {0}",f);
			Console.WriteLine ("g= {0}",g);
			Console.WriteLine ("a/b = {0}",a/b);
			Console.WriteLine ("c/b = {0}",c/b);
			Console.WriteLine ("c/d = {0}",c/d);
			Console.WriteLine ("e*e = {0}",e*e);
			Console.WriteLine ("e*e*e*e = {0}",e*e*e*e);
			Console.WriteLine ("a/e = {0:N}",a/e);
			Console.WriteLine ("c/f = {0:N8}",c/f);
      Console.Read();
    }
  }
}
