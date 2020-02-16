using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 變數的宣告與使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int intX, intY, intZ;
            intX = 10;
            intY = 20;
            intZ = intX + intY;
            Console.WriteLine("intX + intY = {0}" , intZ);
            Console.Read(); //暫停
        }
    }
}
