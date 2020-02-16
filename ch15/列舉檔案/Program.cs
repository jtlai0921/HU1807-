using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 列舉檔案
{
    class Program
    {
        static void Main(string[] args)
        {
            string str,str1,str2;
		    int index=0;
	
		    Console.WriteLine ("請輸入您想查閱的目錄完整路徑");
		    str = Console.ReadLine ();
		    Console.WriteLine ("副檔名為");
		    str1 = Console.ReadLine ();
		    str2 = "*."+str1;
		    string[] f = Directory.GetFiles(@str,@str2);
		   
		    Console.WriteLine ("目錄 {0} 內所有副檔名為{1}的檔案如下所列",	str,str1);
	
		    while(index <f.Length )
		    {
			    Console.WriteLine (f[index]);
			    index++;
		    }
            Console.ReadLine();
        }
    }
}
