using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
  class Program
  {
    static void Main(string[] args)
    {
      bool binResult;
      int  numResult;
        
        binResult = (8 > 3) && (9 > 12);
        Console.WriteLine("(8 > 3) && (9 > 12) -> " + binResult.ToString());
        numResult = 20 & 21;
        Console.WriteLine("20 & 21 -> " + numResult.ToString());
        Console.Read(); //暫停
    }
  }
}
