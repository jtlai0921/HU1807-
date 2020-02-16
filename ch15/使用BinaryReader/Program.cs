using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 使用BinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryReader objReader;
            FileStream objStream;
            int count=0;
   
            try
            {
                objStream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                objReader = new BinaryReader(objStream);
                do
                {
                    //** 以位元組為單位讀取檔案內容，並以16進位方式顯示
                    Console.Write("{0,2:X} ", objReader.ReadByte());
                 count += 1;
                    //'** 換行
                    if (count == 10)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                 } while (true);
                objReader.Close();
             }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("沒有指定檔案");
            }
                
            catch (EndOfStreamException e)
            {
                Console.WriteLine("檔案讀取完畢");
            }
                
            catch  (Exception e )
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
