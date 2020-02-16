using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 算術運算子
{
    class Program
    {
        static void Main(string[] args)
        {
            int intX;
            float sngY;
            intX = 1 + 3;
            Console.WriteLine("1 + 3 = " + intX);
            intX = 3 - 2;
            Console.WriteLine("3 - 2 = " + intX);
            intX = 9 * 9;
            Console.WriteLine("9 * 9 = " + intX);
            intX = 10 / 3;
            Console.WriteLine("10 / 3 = " + intX);
            sngY = 10 % 3;
            Console.WriteLine("10 % 3 = " + sngY);
            Console.Read();
        }
    }
}
