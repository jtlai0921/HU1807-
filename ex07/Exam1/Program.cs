using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] temp= new int[] {26, 28, 29, 31, 35, 34, 36, 37, 36, 32, 28, 18};
        double total=0, avg;
        int i;
        for (i = 0; i <= temp.Length-1; i++)
            total += temp[i]; //進行溫度相加的運算
        avg = total / (temp.Length ); //求出平均溫度
        //將結果顯示出來
        Console.WriteLine("共有" + temp.Length + "月份");
        Console.WriteLine("年度總溫度為： " + total);
        Console.WriteLine("年度平均溫度為： " + avg);
        Console.Read(); //暫時
    }
  }
}
