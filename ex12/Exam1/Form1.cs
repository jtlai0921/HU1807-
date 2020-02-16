using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1
{
  
  public partial class Form1 : Form
  {
    

    public Form1()
    {
      InitializeComponent();
      ListBox listBox1 = new ListBox();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      
        if ((listBox1.SelectedIndex == -1) && (listBox2.SelectedIndex == -1))  //假如沒有選擇任何項目
            label1.Text ="無法執行交換動作，因為沒有選擇任何項目";

           if ((listBox1.SelectedIndex != -1) && (listBox2.SelectedIndex == -1)) 
             //假如Listbox1有而ListBox2沒有選擇任何項目
           {
             listBox2.Items.Add(listBox1.SelectedItem);
             listBox1.Items.Remove(listBox1.SelectedItem);
           }

        if ((listBox1.SelectedIndex == -1) && (listBox2.SelectedIndex != -1)) 
          //假如Listbox2有而ListBox1沒有選擇任何項目
        {
          listBox1.Items.Add(listBox2.SelectedItem);
          listBox2.Items.Remove(listBox2.SelectedItem);
        }
        
        if ((listBox1.SelectedIndex != -1) && (listBox2.SelectedIndex != -1)) 
          //假如Listbox2有而ListBox1也有有選擇任何項目
        {
          listBox1.Items.Add(listBox2.SelectedItem);
          listBox2.Items.Add(listBox1.SelectedItem);
          listBox2.Items.Remove(listBox2.SelectedItem);
          listBox1.Items.Remove(listBox1.SelectedItem);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        listBox1.Items[0] = "國文";
        listBox1.Items[1] = "英文";
        listBox1.Items[2] = "體育";
        listBox1.Items[3] = "音樂";
        listBox1.Items[4] = "數學";
        listBox2.Items[0] = "科目1";
        listBox2.Items[1] = "科目2";
        listBox2.Items[2] = "科目3";
        listBox2.Items[3] = "科目4";
        listBox2.Items[4] = "科目5";
    }
  }
}
