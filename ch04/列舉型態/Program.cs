using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 列舉型態
{
    class Program
    {
        enum Seasons { Spring, Summer, Autumn,Winter };
        static void Main(string[] args)
        {
            Seasons today = Seasons.Spring;
            int seasonNumber = (int) today;
            Console.WriteLine("{0} 的列舉值為 {1}", today, seasonNumber);
            Console.ReadLine();
        }
    }
}
