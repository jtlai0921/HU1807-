using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用鋸齒陣列
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] ch = new char[][] 
			{	new char[] {'a','b','c'},
				new char[] {'c','d','e','f','g','h'},
				new char[] {'w','x','y','z'}};

            for (int index = 0; index < 3; index = index + 1)
            {
                for (int count = 0; count < ch[index].Length; count = count + 1)
                {
                    Console.Write(" {0}", ch[index][count]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
