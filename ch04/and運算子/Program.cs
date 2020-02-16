using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace and運算子
{
    class Program
    {
        static void Main(string[] args)
        {
            bool binResult;
            binResult = (3 > 1) && (5 > 4);
            Console.WriteLine("(3>1) And (5>4) -> " + binResult);
            Console.Read(); //暫停
        }
    }
}
