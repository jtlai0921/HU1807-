using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用單一傳回值
{
  class intTotal
  {
    static int total, temp;

    //計算整數次方總和的函式,參數i表示次方數
    public static int Total(uint i, params int[] num)
    {
      total = temp = 0;
      if (i == 0)             //0次方
      {
        return num.Length;
      }
      else if (i == 1)        //1次方
      {
        for (int t = 0; t < num.Length; t++)
          total += num[t];

        return total;
      }
      else                   //1次方以上
      {
        for (int t = 0; t < num.Length; t++)  //處理加總的動作
        {
          temp = num[t];
          for (int k = 1; k < i; k++)        //處理次方相乘的動作
          {
            temp *= num[t];
          }
          total += temp;
        }

        return total;
      }
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      //以變數a,b,c儲存函式的單一傳回值
      int a = intTotal.Total(0, 1, 2, 3);
      int b = intTotal.Total(1, 1, 2, 3);
      int c = intTotal.Total(2, 1, 2, 3);

      Console.WriteLine("1,2,3的0~2次方總和: " + (a + b + c));
      Console.ReadLine();
    }
  }
}
