using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用try_catch
{
    class cls
    {
        public static void testdiv()
        {
            div();
        }

        public static void div()
        {
            for (int index = 5; index >= 0; index--)
            {
                int dob = 10;
                Console.WriteLine(dob / index);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                cls.testdiv();
            }
            catch (Exception e)
            {
                Console.WriteLine("使用toString函式\n{0}", e.ToString());
                Console.WriteLine("\n使用Message特徵函式\n{0}", e.Message);
                Console.WriteLine("\n使用StackTrace特徵函式", e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
