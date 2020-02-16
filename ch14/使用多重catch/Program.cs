using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多重catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] index = new int[4] { 2, 4, 6, 8 };
            try
            {
                Console.Write("輸入一個數字");
                int x = Convert.ToInt32(Console.ReadLine());

                for (int count = 0; count < index.Length; count++)
                {
                    Console.Write(" {0}", index[count] / x);
                }
                index[5] = x;
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("\n發生Arithmetic例外");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("\n發生超出陣列索引例外");
            }
            finally
            {
                Console.WriteLine("結束於主程式的finally區塊");
            }
            Console.ReadLine();
        }
    }
}
