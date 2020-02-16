using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 唯讀與唯寫
{
  class square
  {
    private float a; //私有欄位
        
    public float area //公用屬性
    {
        get { return a; }
    }

    public float length  //公用屬性
    {
        set  { a = value * value ; }
    }
  }
}
