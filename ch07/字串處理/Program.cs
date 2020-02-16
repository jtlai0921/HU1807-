using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串處理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Visual Basic";
            string str2 = "程式設計實務";
            string str3 = ".NET";
            string str4 = "C#";
            string str;
            str = str1 + str2;
            Console.WriteLine("字串串接：" + str);
            Console.WriteLine("字串長度：" + str.Length);
            str = str.Insert(12, str3);
            Console.WriteLine("字串插入：" + str);
            Console.WriteLine("字串長度：" + str.Length);
            str = str.Replace(str1, str4);
            Console.WriteLine("字串取代：" + str);
            Console.WriteLine("字串長度：" + str.Length);
            str = str.Remove(2, 4);
            Console.WriteLine("字串刪除：" + str);
            Console.WriteLine("字串長度：" + str.Length);
            Console.Read(); //暫停
        }
    }
}
