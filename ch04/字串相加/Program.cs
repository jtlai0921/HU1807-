using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串相加
{
    class Program
    {
        static void Main(string[] args)
        {
            string A, B;
            int a1, a2;
            A = "Hello";
            B = " David";
            A += B; //將字串變數A與B的內容結合在一起
            Console.WriteLine(A); //將變數intB顯示出來
            a1 = 10;
            a2 = 1;
            a2 = a1 + a2;
            Console.WriteLine("a2=" + a2); //將變數a2顯示出來
            Console.WriteLine("a2*6 Mod 2 + 5 *10={0}", a2 * 6 % 2 + 5 * 10);
            Console.Read(); //暫停
        }
    }
}
