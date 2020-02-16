using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 執行時程的錯誤
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int index = 5;index>=0;index--)
			{
				int dob = 10;
				Console.WriteLine (dob/index);
			}
	   }
    }
}
