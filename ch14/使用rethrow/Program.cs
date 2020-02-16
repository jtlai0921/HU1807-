using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用rethrow
{
    class cls
    {
        public static void div()
        {
            try
            {
                int index = 0;
                index = 10 / index;
            }
            catch (Exception e)
            {
                Console.WriteLine("在類別內的catch區塊");
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                cls.div();
            }
            catch (Exception e)
            {
                Console.WriteLine("在Main函式的catch區塊");
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
