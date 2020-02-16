using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用一維陣列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArr = new int[4];
            Console.WriteLine("第一個陣列值為 {0} ", myArr[0]);
            Console.WriteLine("第二個陣列值為 {0} ", myArr[1]);
            Console.WriteLine("第三個陣列值為 {0} ", myArr[2]);
            Console.WriteLine("第四個陣列值為 {0} ", myArr[3]);

            myArr = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("第一個陣列值為 {0} ", myArr[0]);
            Console.WriteLine("第二個陣列值為 {0} ", myArr[1]);
            Console.WriteLine("第三個陣列值為 {0} ", myArr[2]);
            Console.WriteLine("第四個陣列值為 {0} ", myArr[3]);
            Console.ReadLine();
        }
    }
}
