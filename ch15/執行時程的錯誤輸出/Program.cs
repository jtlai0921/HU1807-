using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 執行時程的錯誤輸出
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 1,y =0;
		   try
		   {
			   Console.Error .NewLine  = "\n\r以上是錯誤訊息\n\r";   
			   x=x/y;
		   }
		   catch(Exception e)
		   {
			   Console.Error.WriteLine (e.ToString ());
               Console.ReadLine();
		   }
        }
    }
}
