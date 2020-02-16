using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 測試自訂例外類別
{
    class WeightHigh : Exception
    {
        public WeightHigh()
            : base()
        { }
        public WeightHigh(string String)
            : base(String)
        { }

        public string testWeight(int weight, int high)
        {
            if (weight > 250)
            {
                throw new WeightHigh("有那麼重的體重嗎");
            }
            else if (weight < 40)
            {
                throw new WeightHigh("有那麼輕的體重嗎");
            }
            else if (high > 300)
            {
                throw new WeightHigh("有那麼高的嗎");
            }
            else if (high < 50)
            {
                throw new WeightHigh("有那麼矮的嗎");
            }

            double diff = weight - ((high - 80) * 0.7);
            if (diff > 10)
            {
                return ("你太重囉");
            }
            else if (diff < -10)
            {
                return ("你太輕囉");
            }
            else return ("保持下去，很正常喔");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入體重  ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("請輸入身高  ");
            int y = Convert.ToInt32(Console.ReadLine());

            try
            {
                WeightHigh test = new WeightHigh();
                Console.WriteLine(test.testWeight(x, y));
            }
            catch (WeightHigh e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
