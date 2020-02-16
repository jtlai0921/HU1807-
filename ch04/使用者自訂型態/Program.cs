using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用者自訂型態
{
    class Program
    {
         struct circle{
         public int cX, cY;
         public float cRadius;
         public string cColor;
         };
        static void Main(string[] args)
        {      
            circle circle1;
            circle1.cX = 100;
            circle1.cY = 100;
            circle1.cRadius = 1.414f;
            circle1.cColor = "紅色";
            Console.WriteLine("圓心 X 座標：{0}", circle1.cX);
            Console.WriteLine("圓心 Y 座標：{0}", circle1.cY);
            Console.WriteLine("圓半徑：{0}", circle1.cRadius);
            Console.WriteLine("填色：{0}", circle1.cColor);
            Console.Read();
        }
    }
}
