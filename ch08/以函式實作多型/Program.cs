using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 以函式實作多型
{
  class Fruit   //父類別
  {
    public virtual void calorie()
    {
      Console.WriteLine("水果的熱量");
    }
  }

  class Apple : Fruit  //Apple子類別
  {
    public override void calorie()
    {
      Console.WriteLine("蘋果的熱量");
    }
  }

  class Banana : Fruit  //Banana子類別
  {
    public override void calorie()
    {
      Console.WriteLine("香蕉的熱量");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Apple A = new Apple();    //生成Apple類別物件
      Banana B = new Banana();  //生成Banana類別物件

      Fruit F1 = new Fruit();     //生成Fruit類別物件 
      Fruit F2 = A;             //將Apple類別物件指定給Fruit類別物件
      Fruit F3 = B;             //將Banana類別物件指定給Fruit類別物件

      F1.calorie();             //呼叫函式==>Fruit.calorie()
      F2.calorie();             //呼叫函式==>Apple.calorie()
      F3.calorie();             //呼叫函式==>Banana.calorie()
      Console.ReadLine();
    }
  }
}
