using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i=2;i<=9;i++)
            { 
                for(j=2;j<=9;j++)
                    Console.Write("{0:D}*{1:D}={2,2:D} ", j, i, i * j);
                Console.WriteLine();
            }
        Console.Read(); //暫停
        }
    }
}
