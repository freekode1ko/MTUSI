using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        double y(double x)
        {
            double m1 = 2841293853777390;
            double m2 = -372448727428171;
            double m3 = 2846491805720.19;
            double m4 = -2238527280.58129;
            double m5 = 9396463.10261702;
            double m6 = -25.7869435123593;

            return m1 * (x * x * x * x * x) + m2 * (x * x * x * x) + m3 * (x * x * x) + m4 * (x * x) + m5 * x + m6;
        }
        void dih()
        {
            //МЕТОД ДИХОТОМИИ
            double x1, x2;
            double a = 0;           //Левая граница
            double b = 0.004;           //Правая граница
            double E = Convert.ToDouble(textBox3.Text);        //Заданная точность
            double d = E / 3;// 0.00000002;  //Параметр метода
            int n = 0;          //Кол-во итераций
            listBox4.Items.Add(n);
            listBox5.Items.Add(string.Format("{0:0.000000}", a));
            listBox6.Items.Add(string.Format("{0:0.000000}", b));
            listBox7.Items.Add('*');
            listBox8.Items.Add('*');
            listBox9.Items.Add('*');
            listBox10.Items.Add('*');
            listBox1.Items.Add(string.Format("{0:0.000000}", Math.Abs(a-b)));
            do
            {
                n++;
                x1 = ((a + b) / 2) - d;
                x2 = ((a + b) / 2) + d;
                if (y(x1) < y(x2))//Определение границ нового отрезка неопределённости
                { a = x1; }
                else
                { b = x2; }
                listBox4.Items.Add(n);
                listBox5.Items.Add(string.Format("{0:0.000000}", a));
                listBox6.Items.Add(string.Format("{0:0.000000}", b));
                listBox7.Items.Add(string.Format("{0:0.00000000}", x1));
                listBox8.Items.Add(string.Format("{0:0.00000000}", x2));
                listBox9.Items.Add(string.Format("{0:0.000000}", y(x1)));
                listBox10.Items.Add(string.Format("{0:0.000000}", y(x2)));
                listBox1.Items.Add(string.Format("{0:0.000000}", Math.Abs(a - b)));
            } while (Math.Abs(b - a) >= E);
            double xx = (a + b) / 2;//Абсцисса точки минимума
            textBox1.Text = string.Format("{0:0.000000}", xx);
            textBox2.Text = string.Format("{0:0.000000}", (y(xx)));//вывод координат точки минимума
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            dih();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox7.Items.Clear();
            listBox8.Items.Clear();
            listBox9.Items.Clear();
            listBox10.Items.Clear();
            dih();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
