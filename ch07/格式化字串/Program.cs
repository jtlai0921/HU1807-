using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 格式化字串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2, str3;
            str1 = "機車";
            str2 = "飛機";
            str3 = "火車";
            Console.WriteLine("一部{0}，一架{1}，一列{2}！", str1, str2, str3);
            Console.WriteLine("一部{1}，一架{2}，一列{0}！", str1, str2, str3);
            Console.WriteLine("一部{2}，一架{0}，一列{1}！", str1, str2, str3);
            Console.Read(); //暫停
        }
    }
}
