using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用Out特徵函式
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string str="Hello",str1="C#";
	
		    Console.Out.NewLine = "\n\r下一行\n\r";
		    Console.WriteLine (str);	
		    Console.Out.Write (str);
		    Console.Out.Write (str1);
		    Console.Out.WriteLine ("\n{0}",str+str1);
            Console.ReadLine();
        }
    }
}
