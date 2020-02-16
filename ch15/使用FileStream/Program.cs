﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            FileStream fs = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
            Console.WriteLine("請輸入您想儲存的文字");
            str = Console.ReadLine();
            sw.WriteLine(str);			//將資料寫入檔案
            sw.Close();			//關閉sw資料流
            Console.WriteLine("您於檔案內所輸入的文字為");
            FileStream f = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(f, Encoding.Unicode);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine()); 	//讀出檔案
            }
            sr.Close();										//關閉資料流
            Console.ReadLine();
        }
    }
}
