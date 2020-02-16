using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多載
{
  class addition
  {
    public void add() //宣告一個多載的add函式，但不接收參數
    {
      Console.WriteLine("輸入錯誤");
    }

    public void add(int x, int y) //宣告一個多載的add函式，且接收二個參數
    {
      Console.WriteLine("加法運算結果=" + (x + y));
    }

    public void add(string x, string y) //'宣告一個多載的add函式，且接收二個參數
    {
      Console.WriteLine("字串連結結果=" + (x + y));
    }
  }
}
