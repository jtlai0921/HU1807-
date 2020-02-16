using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property函式
{
  class circle
  {
    private float r;
    private float Pi = 3.14F;
    private float a;
    public float radius
    {
      get
      {
        return r;
      }
      set
            {
                r = value;
                a = Pi * r * r;
            }
    }
    public float area
    {
      get
      {
        return a;
      }
      set
      {
        a = value;
        r = (float) Math.Sqrt(a / Pi);
      }
    }
  }
}
