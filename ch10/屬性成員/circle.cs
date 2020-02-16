using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 屬性成員
{
  class circle
  {
    private float r;
    public float radius
        {
            get
            {
                return r;
            }
            set
            {
                r = value;
            }
        }
  }
}
