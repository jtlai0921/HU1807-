using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重寫
{
  public class Student
  {
    public string name;

    // test_score 被定義為protected,
    // 它只能被此類別或衍生類別存取

    protected decimal test_score;

    // 建構子
    public Student(string name, decimal test_score)
    {
      this.name = name;
      this.test_score = test_score;
    }
    //宣告虛擬函式才可以被重寫
    public virtual decimal grade()
    {
      return test_score;
    }
  }

  // Student的衍生類別
  public class LowScoreStudent : Student
  {
    // 影響分數的新欄位
    private decimal add_score;

    //此建構子會呼叫基底類別的版本,並為add_score設定初值
    public LowScoreStudent(string name, decimal test_score,
              decimal add_score)
      : base(name, test_score)
    {
      this.add_score = add_score;
    }

    //重寫(Override)grade方法,並將add_score加上test_score後回傳
    public override decimal grade()
    {
      return test_score + add_score;
    }
  }

  class Program
  { 
    static void Main(string[] args)
    {
      LowScoreStudent Student1 = new LowScoreStudent("雅芳",
                    50, 20);
      Student Student2 = new Student("志明", 90);

      Console.WriteLine("學生 " + Student1.name +
                " 分數為: " + Student1.grade() + "分");
      Console.WriteLine("學生 " + Student2.name +
                " 分數為: " + Student2.grade() + "分");
      Console.ReadLine();
    }
  }
}
