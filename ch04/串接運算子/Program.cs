using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串接運算子
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            string d, e, f;
            a = 200;
            b = 500;
            c = a + b;
            d = "Happy ";
            e = "New Year";
            f = d + e;
            Console.WriteLine(c); //將變數a與b的相加結果顯示出來
            Console.WriteLine(f); //將變數d與e的字串內容結合在一起並顯示出來
            Console.Read(); //暫停
        }
    }
}
