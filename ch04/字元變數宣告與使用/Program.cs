using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字元變數宣告與使用
{
    class Program
    {
        static void Main(string[] args)
        {
            char chrA, chrB, chrC;
            chrA = 'A';
            chrB = 'B';
            chrC = 'C';
            Console.WriteLine("{0} 的Unicode編碼為 {1}",chrA,(int)chrA);
            Console.WriteLine("{0} 的Unicode編碼為 {1}",chrB, (int)chrB);
            Console.WriteLine("{0} 的Unicode編碼為 {1}",chrC, (int)chrC);
            Console.Read(); //暫停
        }
    }
}
