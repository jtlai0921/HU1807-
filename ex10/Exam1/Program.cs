using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
  public class SetBook
  {
    private string Title;
    private int Price;
    protected void GetInfo()
    {
        Console.Write("請輸入出版品名稱：");
        Title = Console.ReadLine();
        Console.Write("請輸入出版品定價：");
        Price = int.Parse(Console.ReadLine());
    }
        
    protected void DisplayInfo()
    {
        Console.WriteLine("此出版品的名稱為" + Title);
        Console.WriteLine("此出版品的定價為" + Price);
    }
  }
    
  public class Books:SetBook
  {
 
      private string BookName;
      public void GetData()
      {
          GetInfo();
          Console.Write("輸入作者姓名:");
          BookName = Console.ReadLine();
      }
        
      public void DisplayData()
      {
          DisplayInfo();
          Console.WriteLine("此出版品的作者為" + BookName);
      }
  }
 
  class Program
  {
    static void Main(string[] args)
    {
        Books ABook =new Books();
        ABook.GetData();
        ABook.DisplayData();
        Console.Read();
    }
  }
}
