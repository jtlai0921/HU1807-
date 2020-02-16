using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子優先順序
{
    class Program
    {
        static void Main(string[] args)
        {
            int price = 450;
        bool result1, result2, onsale;
        onsale = false;
        result1 = (5 + 11) * 10 / 2 >= 50 / 2 * 3;
        result2 = (price <= 450) || (onsale == true);
        //將運算的結果顯示出來
        Console.WriteLine("(5 + 11) * 10 / 2 >= 50 / 2 * 3=" + result1);
        Console.WriteLine("(price <= 450) Or (onsale == true)=" + result2);
        Console.Read(); //暫停
        }
    }
}
