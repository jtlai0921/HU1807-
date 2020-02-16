using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //** 日期時間格式化輸出
        Console.WriteLine(String.Format("{0:D}", DateTime.Now));
        Console.WriteLine(String.Format("{0:T}", DateTime.Now));
        Console.WriteLine(String.Format("{0:h:m:s}", DateTime.Now));
        Console.WriteLine(String.Format("{0:hh:mm:ss tt}", DateTime.Now));
        Console.WriteLine(String.Format("{0:dddd, MMM d yyyy}", DateTime.Now));
        Console.WriteLine(String.Format("{0:HH:mm:ss}", DateTime.Now));

        //** 自訂數值格式化輸出
        Console.WriteLine(String.Format("{0:##,##0.00}", 5459.4));
        Console.WriteLine(String.Format("{0:###0.00}", 334.9));
        Console.WriteLine(String.Format("{0:0.00%}", 5));
        Console.Read(); //暫停
        }
    }
}
