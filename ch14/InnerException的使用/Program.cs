using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException的使用
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
            catch (Exception)
            {
                Console.WriteLine("在類別內的catch區塊內發生例外");
                throw new ArithmeticException("抓到 Arthmetic 例外",
                      new DivideByZeroException("這是除零錯誤"));
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
                Exception DB = e.InnerException;
                Console.WriteLine(e.Message);
                Console.WriteLine(DB.Message);
            }
            Console.ReadLine();
        }
    }
}
