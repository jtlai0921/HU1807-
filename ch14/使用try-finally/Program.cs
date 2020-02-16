using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用try_finally
{
    class cls
    {
        public static void div()
        {
            try
            {
                for (int index = 5; index >= 0; index--)
                {
                    int dob = 10;
                    Console.Write(" {0}", dob / index);
                }
            }
            finally
            {
                Console.WriteLine("在finally區塊");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cls.div();
        }
    }
}
