using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法成員
{
  class MyString
  {
    private int MyLength;

        public void HowLong(string str)
        {
            strLen(str);
            Console.WriteLine("輸入的字串長度為：" + MyLength);
        }

        private void strLen(string str)
        {
            int Count=0;
            for (int i = 1; i <= str.Length;i++)
              Count += 1;
            MyLength = Count;
        }
  }
}
