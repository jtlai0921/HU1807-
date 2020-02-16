using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam3
{
  class Program
  {
    static void Main(string[] args)
    {
        string[] name=new string[3];
        int[] score =new int[3];
        BinaryWriter objWriter;
        BinaryReader objReader;
        FileStream objStream;
        int i;
        try
        {
            objStream = new FileStream(args[0], FileMode.Append, FileAccess.Write);
            objWriter = new BinaryWriter(objStream);
            for (i = 0;i<=2;i++)
            {
                Console.Write("姓名>");
                name[i] = Console.ReadLine();
                Console.Write("成績>");
                score[i] = int.Parse(Console.ReadLine());
            }
                
            for (i = 0;i<=2;i++)
            {
                objWriter.Write(name[i]);
                objWriter.Write(score[i]);
            }
   
            objWriter.Close();

            objStream = new FileStream(args[0], FileMode.Open, FileAccess.Read);
            objReader = new BinaryReader(objStream);

            do
            {
              Console.WriteLine("{0,3}  {1,3}", objReader.ReadString(), objReader.ReadInt32());
            } while (true);

            objReader.Close();
        }
            
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine("沒有指定檔案");
        }
            
        catch (EndOfStreamException)
        {
          Console.WriteLine("檔案讀取完畢");
        }
            
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        Console.Read();
    }
  }
}
