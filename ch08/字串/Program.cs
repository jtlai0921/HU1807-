using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 字串
{
  class Program
  {
    static void Main(string[] args)
    {
      string Str1 = " abcDef ";
      Str1 = Str1.Insert(4, "-Mickey-");
      Console.WriteLine(" Str1={0} ", Str1);
      Console.WriteLine(" Str1取出的第5個字元={0} ", Str1[5].ToString());
      Str1 = Str1.ToUpper();
      Console.WriteLine(" Str1轉換為大寫={0} ", Str1);
      Str1 = Str1.ToLower();
      Console.WriteLine(" Str1轉換為小寫={0} ", Str1);　
      Str1 = Str1.Trim();
      Console.WriteLine(" Str1去掉前後空白={0} ", Str1);
      string s1 = "mickey";
      Console.WriteLine(" mickey在Str1的索引位置={0} ", Str1.IndexOf(s1));
      Console.WriteLine(" Str1字串長度={0} ", Str1.Length);
      Console.ReadLine();
    }
  }
}
