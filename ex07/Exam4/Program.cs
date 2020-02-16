using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam4
{
  class Program
  {
     static int count;

     static void  Hanoi(char sMove , char sTo , char sAux , int n ) 
     {
       if (n == 1) 
       {
          count += 1;
          Console.Write("步驟 {0,-3:D}：", count);
          Console.WriteLine("盤 {0,-2:D} 由 {1} 移至 {2}", n, sMove, sTo);
       }
       else
       {
          Hanoi(sMove, sAux, sTo, n - 1);
          count += 1;
          Console.Write("步驟 {0,-3:D}：", count);
          Console.WriteLine("盤 {0,-2:D} 由 {1} 移至 {2}", n, sMove, sTo);
          Hanoi(sAux, sTo, sMove, n - 1);
       }
     }
   
    static void Main(string[] args)
    {
        int sheet;
        Console.Write("請輸入盤數：");
        sheet = int.Parse(Console.ReadLine());
        Console.WriteLine("河內塔解答：");
        Hanoi('A', 'C', 'B', sheet);
        Console.ReadLine();
    }
  }
}
