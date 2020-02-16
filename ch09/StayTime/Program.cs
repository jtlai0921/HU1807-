using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StayTime
{
  class Program
  {
    static void Main(string[] args)
    {
        DateTime LoginTime;
        DateTime LogoffTime;
        TimeSpan StayTime=new TimeSpan();
        string YesNo;
        int Loop1, Loop2;
        LoginTime = DateTime.Now; //取得目前登入的時間
        Console.WriteLine("登入時間：{0}", LoginTime);
        do
        {
            Console.WriteLine("檔案下載中！請稍待！");
            for( Loop1 = 0; Loop1<= 200000; Loop1++)
            {
                if (Loop1 % 8000 ==0 )
                {
                  for (Loop2 = 0; Loop2 <= 6000000; Loop2++) ;
                       Console.Write(char.ConvertFromUtf32((int) 16));
                }
             }
            Console.Write(char.ConvertFromUtf32((int) 10) + "下載完成！是否繼續下載？(Y/N)");
            YesNo = Console.ReadLine(); //取得所輸入的值
            if (YesNo.ToLower() == "n") 
            {    //假如輸入為「n」時，則顯示登出及停留時間
                LogoffTime = DateTime.Now;
                Console.WriteLine("登出時間：{0}", LogoffTime);
                StayTime = LogoffTime.Subtract(LoginTime);
                Console.WriteLine("您在此停留了" + StayTime.Hours 
                + "小時" + StayTime.Minutes + "分鐘" 
                + StayTime.Seconds + "秒");
            }
          } while (YesNo.ToLower() == "y");
        Console.ReadLine();
    }
  }
}
