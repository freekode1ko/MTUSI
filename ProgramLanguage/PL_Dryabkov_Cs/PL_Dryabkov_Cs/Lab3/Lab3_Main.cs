using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Dryabkov_Cs.Lab3
{
    public partial class Lab3_Main : Form
    {
        public Lab3_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(this.Width -40, this.Height -100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = 0;
            int nn = 0;

            if (radioButton1.Checked) { n++; } //1
            else { nn++;}

            if (radioButton8.Checked) { n++; } //2
            else { nn++; }

            if (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked && !checkBox4.Checked && !checkBox5.Checked) //3
            {n++;} else { nn++;  }

            if (checkBox6.Checked && checkBox10.Checked) //4
            { n++; }else { nn++; }

            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1){ nn += 2; ;} //5 
            else { if (comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex != 1) { nn += 2; ;  } }
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex != 1 || comboBox1.SelectedIndex != 0 && comboBox2.SelectedIndex == 1)
                {n++;nn++;}
                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {n += 2;}


            if (checkedListBox1.CheckedItems.Count == 0)//6
            { nn++; }
            else {if (checkedListBox1.GetItemChecked(0) && checkedListBox1.GetItemChecked(2))
                {  n++; } else { nn++;  }
            }

            if (hScrollBar1.Value >= 1940 && hScrollBar1.Value <= 1950)//7
                n++;
            else { nn++; }

            if (listBox2.Text == "" && listBox3.Text == "" && listBox4.Text == "")//8
            { nn++; }
            else
            {
                if (listBox2.Items[0] == "Постановка задачи" && listBox3.Items[0] == "Построение моделей" && listBox4.Items[0] == "Развертывание и обновление моделей")
                { n++; }
                else { nn++; };
            }

            tabControl1.Visible = false;
            {
                Class3Library.Class1.Vivod(n, textBox2);
                Class3Library.Class1.Vivod(nn, textBox3);
                int rating = Class3Library.Class1.rating(n);
                Class3Library.Class1.Vivod(rating, textBox4);
                Class3Library.Class1.Viv(n, "Правильные", chart1);
                Class3Library.Class1.Viv(nn, "Неправильные", chart1);
            }

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        { textBox1.Text = string.Format("{0}", hScrollBar1.Value);}

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add(listBox1.Text);
                listBox2.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox3.Items.Add(listBox1.Text);
                listBox3.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(0);
            }
            if (listBox1.SelectedIndex == 1)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(1);
            }
            if (listBox1.SelectedIndex == 2)
            {
                listBox4.Items.Add(listBox1.Text);
                listBox4.Text = Convert.ToString(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(2);
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
