using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam14
{
  class Program
  {
    static void Main(string[] args)
    {
        char input=' ';
        string str;
        int count = 1;
        str = "";
        Console.WriteLine("請輸入一句英文：");
        while (input!= '.')
        {
          input = (char) (Console.Read());
            //** 利用空白判斷是否為一個單字
            if (input == ' ') 
                count += 1;
            str += input;
        }
        Console.WriteLine("所輸入的句子為：" + str);
        Console.WriteLine("共有" + count + "英文單字。");
        Console.ReadLine();
        Console.Read();
    }
  }
}
