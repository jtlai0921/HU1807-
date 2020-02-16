using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1
{
  public class Exam1
  {
    public string Name;
    public int Age;
  }

  class Program
  {
    static void Main(string[] args)
    {
        Exam1 E1 =new Exam1();
        E1.Name = "劉超仁";
        E1.Age = 18;
        Console.WriteLine("姓名為：" + E1.Name);
        Console.WriteLine("年齡為：" + E1.Age.ToString());
        Console.ReadLine();
    }
  }
}
