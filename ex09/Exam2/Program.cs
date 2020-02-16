using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
  public class Exam2
  {
    public string Name;
    public int Age;
    
    public int Change_Age() 
    {
        Age = 20;
        return Age;
    }
    public string Change_name()
    {
        Name = "丁大同";
        return Name;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
        Exam2 MyClass1=new Exam2();
        MyClass1.Name = "劉小同";
        MyClass1.Age = 18;

        Console.WriteLine("原本的姓名：" + MyClass1.Name);
        Console.WriteLine("原本的年齡 ：" + MyClass1.Age);
        Console.WriteLine("修改後的姓名：" + MyClass1.Change_name());
        Console.WriteLine("修改後的姓名：" + MyClass1.Change_Age());
        Console.ReadLine();
    }
  }
}
