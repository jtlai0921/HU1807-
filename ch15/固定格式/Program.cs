using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 固定格式
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryReader objReader;
            FileStream objStream;
            try
            {
                objStream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
                objReader = new BinaryReader(objStream);
                Console.WriteLine(objReader.ReadString());
                Console.WriteLine(objReader.ReadInt32());
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

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
