using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam2
{
  class Program
  {
    static void Main(string[] args)
    {
        string[,] student=new string[10,2];
        int i;
        try
        {
           StreamWriter objWriter = new StreamWriter(args[0], true);
            for (i = 0; i<=9; i++)
            {
              Console.Write("姓名>");
                student[i,0] = Console.ReadLine();
                Console.Write("成績>");
                student[i,1] = Console.ReadLine();
            }
            
            for (i = 0;i<=9;i++)
                objWriter.WriteLine("{0,3}  {1,3}", student[i,0], student[i,1]);
            objWriter.Close();
        }       
        catch (IndexOutOfRangeException)
        {
          Console.WriteLine("沒有指定檔案");
        }           
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
        Console.WriteLine("資料輸入完畢");
        Console.Read();
    }
  }
}
