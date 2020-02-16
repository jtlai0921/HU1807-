using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam17
{
  class Program
  {
    static void Main(string[] args)
    {
      int input;
        float sngX1 = 0;
        float sngX2 = 15;
        float middle;
        do
        {
          Console.Write("請輸入開根號數字（0～15）：");
            input = int.Parse(Console.ReadLine());
        } while (input>15);
                 
        do
        {
          middle = (sngX1 + sngX2) / 2;
            if (middle * middle > input)
                sngX2 = middle;
            else
                sngX1 = middle;
        } while (sngX2 - sngX1 > 0.00001);

        Console.WriteLine(input + " 開根號值：" + middle);
        Console.Read();
    }
  }
}
