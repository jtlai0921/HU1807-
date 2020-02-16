using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
  class Hello
  {
    public void SayHello()
    {
      Console.WriteLine("Hello！World！");
    }
  }
   
  class Program
  {
    static void Main(string[] args)
    {
      Hello obj =new Hello();
        obj.SayHello();
        Console.Read(); //暫停
    }
  }
}
