using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 邏輯運算子
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a, b, c, d;
            a = (3 > 5) || (15 < 40);
            b = (3 > 5) && (15 < 40);
            c = (3 > 5) ^ (15 < 40);
            d = ! (3 > 5);
            Console.WriteLine("a=" + a); //將變數a顯示出來
            Console.WriteLine("b=" + b); //將變數b顯示出來
            Console.WriteLine("c=" + c); //將變數c顯示出來
            Console.WriteLine("d=" + d); //將變數d顯示出來
            Console.Read(); //暫停
        }
    }
}
