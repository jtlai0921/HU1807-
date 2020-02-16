using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 巢狀自訂型態
{
    class Program
    {
        struct circle {
        public float cRadius;
        public string cColor;
        }
        struct wheel {
        public circle circle1;
        public string usage;
        };
        static void Main(string[] args)
        {  
            wheel wheel1;
            wheel1.circle1.cRadius = 50;
            wheel1.circle1.cColor = "黑色";
            wheel1.usage = "汽車";
            Console.WriteLine("輪胎半徑：{0}",wheel1.circle1.cRadius);
            Console.WriteLine("輪胎顏色：{0}",wheel1.circle1.cColor);
            Console.WriteLine("輪胎用途：{0}",wheel1.usage);
            Console.Read();
        }
    }
}
