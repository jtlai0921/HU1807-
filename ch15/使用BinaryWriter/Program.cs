using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用BinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter objWriter;
            FileStream objStream;
            try
            {
                objStream = new FileStream(args[0], FileMode.Append, FileAccess.Write);
                objWriter = new BinaryWriter(objStream);
                //* 寫入字串
                objWriter.Write("字串");
                //* 寫入數值
                objWriter.Write(640526);
                objWriter.Close();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("沒有指定檔案");
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }      
    }
}
