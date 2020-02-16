using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam3
{
  class PortException:ApplicationException
  {
      private string str_message;

      public PortException()
      {
        str_message = "連接埠已佔用";
      }          

      public PortException(string message)
      {
        str_message = message;
      }
         
      public override string Message
      {
        get { return str_message; }
      }         
  }
   
  class Program
  {
    static void Main(string[] args)
    {
      int[] Port  = new int[] {0, 1, 0, 1, 0, 1, 1, 1, 0, 1};
      int i;
      for (i = 0; i<=Port.Length - 1; i++)
      {
          try
          {
              if (Port[i] == 1) 
                    throw new PortException();
          }
          catch (PortException e)
          {
            Console.WriteLine(e.Message + "：" + i);
          }
      }   
      Console.Read();
    }
  }
}
