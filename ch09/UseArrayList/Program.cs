using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace UseArrayList
{
  class Program
  {
    static void Main(string[] args)
    {
        Object Tmp;
        int i;
        int NameCount;
        ArrayList UserName = new ArrayList();
        
        Console.Write("請輸入總人數：");
        NameCount = int.Parse(Console.ReadLine()); //取得所輸入的人數
        for (i=0; i<= NameCount-1;i++)  //依次輸入每一位的姓名
        {
            Console.Write("第 {0} 位姓名：",i+1);
            Tmp = Console.ReadLine();
            UserName.Add(Tmp);
        }
        Console.Write("請輸入您要尋找的名字：");
        Tmp = Console.ReadLine();  //取得所輸入的名字
        if (UserName.IndexOf(Tmp) < 0 )
        //若超過陣列索引值則表示找不到符合的姓名
            Console.WriteLine("找不到您所輸入的名字！");
        else
            Console.WriteLine("您所尋找的名字在第 {0} 位",UserName.IndexOf(Tmp)+1);
        Console.WriteLine("排序後的陣列內容為：");
        UserName.Sort(); //使用Sort方法將陣列元素進行排序
        for (i=0; i<= UserName.Count - 1;i++) //將排序後的陣列元素依序顯示在螢幕上
            Console.WriteLine(UserName[i]);
        Console.WriteLine("在陣列第1位加入一個使用者David後，陣列的內容為：");
        UserName.Insert(1, "David"); //插入一個元素
        for (i=0; i<= UserName.Count - 1;i++)  //重新將陣列元素顯示在螢幕上
            Console.WriteLine(UserName[i]);
        Console.ReadLine();
    }
  }
}
