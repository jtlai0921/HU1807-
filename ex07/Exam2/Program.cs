using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
  class Program
  {
    static void Main(string[] args)
    {
        int[] score =new int[] {99, 100, 59, 58, 75};
        double total=0, avg;
        int i;
        for (i = 0; i<=score.Length-1 ;i++)
            total += score[i]; //進行成績相加的運算
        avg = total / score.Length; //求出平均成績
        //將結果顯示出來
        Console.WriteLine("共有" + score.Length + "位同學");
        Console.WriteLine("國文總成績度為： " + total);
        Console.WriteLine("國文總平均為： " + avg);
        Console.Read(); 
    }
  }
}
