using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList類別
{
    class Program
    {
        static void Main(string[] args)
        {      
            ArrayList name = new ArrayList();
            string str_tmp;
                Console.WriteLine("請輸入學生姓名(輸入 . 結束輸入)：");
            do {
                Console.Write(">");
                str_tmp = Console.ReadLine();
                name.Add(str_tmp);
                } while (str_tmp != ".");
            Console.WriteLine("共輸入" + (name.Count - 1) + "筆資料：");
            foreach ( string str_tmp1 in name )
            {
                Console.Write("-->");
                Console.WriteLine(str_tmp1);
            }
             Console.WriteLine();
             Console.Read(); //暫停
        }
    }
}
