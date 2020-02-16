using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比較運算子
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool result1, result2, result3;
            a = 10;
            b = 30;
            c = 10;
            result1 = (a ==b);  //判斷a是否等於b
            result2 = (b != c); //判斷b是否不等於c
            result3 = (a >= c); //判斷a是否大於等於c
            Console.WriteLine(result1); //將result1顯示出來
            Console.WriteLine(result2); //將result2顯示出來
            Console.WriteLine(result3);//將result3顯示出來
            Console.Read(); //暫停
        }
    }
}
