using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 巢狀例外機制
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
            catch (IOException)
            {
                Console.WriteLine("抓到IO的例外");
            }
            finally
            {
                Console.WriteLine("\n結束於cls類別內的finally區塊");
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
			catch(ArithmeticException)
			{
				Console.WriteLine ("抓到Arithmetic例外");
			}
			finally
			{
				Console.WriteLine ("結束於主程式的finally區塊");
			}
            Console.ReadLine();
        }
    }
}
