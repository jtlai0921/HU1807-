using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 使用In特徵函式
{
    class Program
    {
        static void Main(string[] args)
        {
            int x ;
		    char[] ch = new char[50];
		    string str;

	  	    str=Console.In.ReadLine ();
        	Console.WriteLine ("使用ReadLine {0}",str);
       	    x = Console.In.ReadBlock(ch,0,str.Length);
		    Console.WriteLine ("長度為  {0}",x);
	   	    for(int index=0;index<x;index++)
	        {
			    Console.Write("陣列元素 {0} 內容為 {1} \n",index,ch[index]);
	        }
	        x=Console.In.Read ();
	        Console.WriteLine ("使用Read {0}",x);	
	        x=Console.In.Peek ();
		    Console.WriteLine ("使用Peek {0}",x);
            x=Console.In.Read ();
	        Console.WriteLine ("使用Read {0}",x);
            Console.ReadLine();
        }
    }
}
