using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
  interface Car //定義一個名為Car介面
  {
    int Carwool();  //定義成員
  }

  class bike:Car //定義一個名為bike類別
  {
    public int Carwool()
    {
       return 2;
    }
  }

  class race:Car //定義一個名為race 類別  
  {
      public int Carwool() 
      {
        return 4;
      }
  }
   
  class Program
  {
    static void Main(string[] args)
    {
        int input;
        Console.Write("您想瞭解那一種車型的輪胎數呢？(1)腳踏車(2)汽車？");
        input = int.Parse(Console.ReadLine()); //取得所輸入的值
        switch (input)
        {
           case 1 : //腳踏車
                bike bike1=new bike();
                Console.WriteLine("腳踏車的輪胎數為：" + bike1.Carwool());
                break;
           case 2: //汽車
                race race1 =new race();
                Console.WriteLine("汽車的輪胎數為：" + race1.Carwool());
                break;
        }
        Console.Read();
    }
  }
}
