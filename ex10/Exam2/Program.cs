using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2
{
  public class Bicycle
  {
    private string Color;
    private string Style;
    private int Price;

    public void GetData()
    {
        Console.Write("請輸入顏色：");
        Color = Console.ReadLine();
        Console.Write("請輸入車型：");
        Style = Console.ReadLine();
        Console.Write("請輸入價格：");
        Price = int.Parse(Console.ReadLine());
    }
   
    public void DispData()
    {
        Console.WriteLine("車的顏色為：" + Color);
        Console.WriteLine("車的型式為：" + Style);
        Console.WriteLine("車的價格為：" + Price);
    }
  }
    

  public class RaceBike:Bicycle
  {
      private int Speed;

      public void GetSpeed()
      {
          GetData();
          Console.Write("輸入幾段變速:");
          Speed = int.Parse(Console.ReadLine());
      }
          
      public void DispCarData()
      {
          DispData();
          Console.WriteLine("此車為" + Speed + "段變速車");
      }
  }
    
  class Program
  {
    static void Main(string[] args)
    {
        RaceBike MyCar = new RaceBike();
        MyCar.GetSpeed();
        MyCar.DispCarData();
        Console.ReadLine();
    }
  }
}
