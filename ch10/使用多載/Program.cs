using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用多載
{
  class Program
  {
    static void Main(string[] args)
    {
        addition ad=new addition(); //定義ad為addtion類別
        
        string s1= "生日快樂";
        string s2= "我的好友";
        string rd;
        
        Console.WriteLine("您想進行什麼操作(1)數字加法(2)字串連結");
        rd = Console.ReadLine(); //取得所輸入的值
        switch (int.Parse(rd))
        {
          case 1: //執行數字加法
                ad.add(3,5);
                break;
          case 2: //執行字串連結
                ad.add(s1,s2);
                break;
          default://顯示輸入錯誤
                ad.add();
                break;
        }
        Console.ReadLine();
    }
  }
}
