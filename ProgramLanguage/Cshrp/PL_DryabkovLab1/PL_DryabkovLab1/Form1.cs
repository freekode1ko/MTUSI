using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_DryabkovLab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Task1
        class solver
        {
            //Создание функции класса для вычисления значения функции
            public static double Fr(double x, double y)
            {
                double k = (x * y + Math.Sin(x)) / (Math.Abs(1 - y) * Math.Log10(x)); 
                return k;
            }
            //Создание процедуры для решения задачи
            public void Famp(double x, double y, ref double k)
            {
                //Вычисление значения уравнения
                k = (x * y + Math.Sin(x)) / (Math.Abs(1 - y) * Math.Log10(x)); 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Получение значений переменных
            double x1 = System.Convert.ToDouble(textBox1.Text);
            double y1 = System.Convert.ToDouble(textBox2.Text);
            //Вычисление значений функции
            double k1 = solver.Fr(x1, y1);
            double z1 = Math.Round(k1);
            float d1 = Convert.ToSingle(k1);
            int l1 = Convert.ToInt32(k1);
            double t1 = Math.Floor(k1);
            //Вывод значений
            textBox3.Text = System.Convert.ToString(k1);
            textBox4.Text = System.Convert.ToString(d1);
            textBox5.Text = Convert.ToString(l1);
            textBox23.Text = Convert.ToString(z1);
            textBox24.Text = Convert.ToString(t1);
            textBox25.Text = Convert.ToString(k1 + d1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //получение значений переменных
            double x2 = Convert.ToDouble(textBox6.Text);
            double y2 = Convert.ToDouble(textBox7.Text);
            //создание объекта класса solver
            solver sol = new solver();
            //Создание переменных и вызов функции решения
            double k2 = 0;
            sol.Famp(x2, y2, ref k2);
            double z2 = Math.Round(k2);
            float d2 = Convert.ToSingle(k2);
            int l2 = Convert.ToInt32(k2);
            double t2 = Math.Floor(k2);
            //Вывод ответа
            textBox8.Text = Convert.ToString(k2);
            textBox9.Text = Convert.ToString(d2);
            textBox10.Text = Convert.ToString(l2);
            textBox26.Text = Convert.ToString(z2);
            textBox27.Text = Convert.ToString(t2);
            textBox28.Text = Convert.ToString(k2 + d2);
        }

        //Task 2
        class searcher
        {
            public static double calcr(double x1, double y1, double x2, double y2)
            {
                double r1 = (x1 * x2) + (y1 * y2) / (Math.Sqrt((x1 * x1) * (y1 * y1)))*(Math.Sqrt((x2*x2)*(y2*y2)));
                return r1;
            }
            public static void recaller(double A1, double A2, double B1, double B2, double C1, double C2,
                ref double r11, ref double r12, ref double r13)
            {
                r11 = calcr(A1, B1, A2, B2);
                r12 = calcr(B1, C1, B2, C2);
                r13 = calcr(A1, C1, A2, C2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double r1 = 0, r2 = 0, r3 = 0; 
            double A1, A2, B1, B2, C1, C2;
            A1 = System.Convert.ToDouble(textBox11.Text);
            A2 = System.Convert.ToDouble(textBox12.Text);
            B1 = System.Convert.ToDouble(textBox13.Text);
            B2 = System.Convert.ToDouble(textBox14.Text);
            C1 = System.Convert.ToDouble(textBox15.Text);
            C2 = System.Convert.ToDouble(textBox16.Text);
            searcher.recaller(A1, A2, B1, B2, C1, C2, ref r1, ref r2, ref r3);
            textBox17.Text = System.Convert.ToString(r1);
            textBox18.Text = System.Convert.ToString(r2);
            textBox19.Text = System.Convert.ToString(r3);        
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }                
        }
    }

}
