using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 運算子的多載
{
  class cls
  {
    public int val;
    public bool flag;

    public cls(int count)
    {
      val = count;
    }
    public cls(bool flag1)
    {
      flag = flag1;
    }

    public static cls operator +(cls c1, cls c2)
    {
      return new cls(c1.val + c2.val);
    }
    public static cls operator -(cls c1, cls c2)
    {
      return new cls(c1.val - c2.val);
    }
    public static cls operator *(cls c1, cls c2)
    {
      return new cls(c1.val * c2.val);
    }
    public static cls operator /(cls c1, cls c2)
    {
      return new cls(c1.val / c2.val);
    }
    public static cls operator %(cls c1, cls c2)
    {
      return new cls(c1.val % c2.val);
    }
    public static cls operator ++(cls c1)
    {
      return new cls(c1.val + 1);
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      cls c1 = new cls(5);
      cls c2 = new cls(9);

      c1 += c2;
      Console.WriteLine("算式c1+=c2 c1的值為 {0}", c1.val);
      c1 -= c2;
      Console.WriteLine("算式c1-=c2 c1的值為 {0}", c1.val);
      c1 *= c2;
      Console.WriteLine("算式c1*=c2 c1的值為 {0}", c1.val);
      c1 /= c2;
      Console.WriteLine("算式c1/=c2 c1的值為 {0}", c1.val);
      c1 %= c2;
      Console.WriteLine("算式c1%=c2 c1的值為 {0}", c1.val);
      c1++;
      Console.WriteLine("算式c1++   c1的值為 {0}", c1.val);
      Console.WriteLine("c1.val的值的值為 {0}", c1.val);
      Console.Read();
    }
  }
}
