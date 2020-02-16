using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串變數宣告與使用
{
    class Program
    {
        static void Main(string[] args)
        {
            string strHello, strName;
            strHello = "您好！歡迎來到程式語言的世界！";
            strName  = "漸入佳境";
            Console.WriteLine(strHello);
            Console.WriteLine("                       " + strName);
            Console.Read(); //暫停
        }
    }
}
