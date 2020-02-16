using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 日期變數宣告與使用
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeBirth;
            string birthstr= "6/10/1989 3:50:59 AM";
            timeBirth = DateTime.Parse(birthstr);
            Console.WriteLine("日期變數 {0}: ",timeBirth);
            Console.Read(); //暫停
        }
    }
}
