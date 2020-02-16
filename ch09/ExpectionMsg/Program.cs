using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpectionMsg
{
  class Program
  {
    static void Divide(int x , byte y) 
    {
      try 
      {
          //建立Divide程序來截取例外狀況
          Console.WriteLine(x / y);
      }
      
        catch (Exception e1)  //當發生例外狀況時顯示相關訊息
        {
          Console.WriteLine("例外類型：" + e1.GetType().ToString());
          Console.WriteLine("錯誤訊息：" + e1.Message);
          Console.WriteLine("程式或物件名稱：" + e1.Source);
          Console.WriteLine("產生錯誤的模組：" + e1.TargetSite.Name);
        }
   }

    static void Main(string[] args)
    {
      Divide(33, 0); //呼叫Divide程序
      Console.ReadLine();
    }
  }
}
