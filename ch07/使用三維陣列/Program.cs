using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用三維陣列
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int [, ,] myArr = new int[2, 3, 4];
            for (int index = 0; index < 2; index = index + 1)
            {
                for (int count = 0; count < 3; count = count + 1)
                {
                    for (int idx = 0; idx < 4; idx = idx + 1)
                    {
                        myArr[index, count, idx] = counter;
                        counter = counter + 1;
                    }
                }
            }
            for (int index1 = 0; index1 < 2; index1 = index1 + 1)
            {
                for (int count1 = 0; count1 < 3; count1 = count1 + 1)
                {
                    Console.Write("{");
                    for (int idx1 = 0; idx1 < 4; idx1 = idx1 + 1)
                    {
                        Console.Write(" {0:D2}", myArr[index1, count1, idx1]);
                    }
                    Console.Write("}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
