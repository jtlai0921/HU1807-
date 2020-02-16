using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam15
{
  class Program
  {
    static void Main(string[] args)
    {
      int number, numMod;
        int count= 2;
        Console.Write("請輸入一數字：");
        number = int.Parse(Console.ReadLine());
        if (number != 2) 
        {
           do
           {
             numMod = number % count;
                if ((numMod == 0) && (number != 2)) 
                {
                    Console.WriteLine(number + " 不是質數。");
                    break;
                }
                count += 1;
           } while (count != number);             
        }
           
        if (count == number) 
            Console.WriteLine(number + " 是質數。");   
        Console.Read();
    }
  }
}
