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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

private void button12_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox3.Text);
            double y0 = Convert.ToDouble(textBox4.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double eps = Convert.ToDouble(textBox7.Text);
        }
        double f1(double z, double u)
        {
            return 10000000 - 10 * z - 1000000 * u;
        }
        double f(double t, double u) => Math.Exp(-5*t)*Math.Sin(5*Math.Sqrt(39999)*t)-10*Math.Exp(-5*t)*Math.Cos(5 * Math.Sqrt(39999) * t)+10;
        double rung(double x, double y, double h, int m)
        {
            double k1, k2, k3, k4;
            for (int i = 1; i <= m; i++)
            {
                k1 = f(x,y);
                k2 = f(x + h / 2,y);
                k3 = f(x + h / 2,y);
                k4 = f(x + h,y);
                y = y + h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
            }
            return y;
        }

        void dif(double x0, double y0, double b, double h0, double E)
        {
            int n = Convert.ToInt32((b - x0) / h0);
            double h, x, y, y1;
            int m;
            for (int i = 0; i < n; i++)
            {
                h = h0;
                m = 1;
                y = rung(x0, y0, h, m);
                do
                {
                    y1 = y;
                    h = h / 2;
                    x = x0;
                    y = y0;
                    m = m * 2;
                    y = rung(x, y, h, m);
                } while (Math.Abs(y - y1) >= E);
                x0 += h0;
                y0 = y;
                listBox12.Items.Add(string.Format("{0:0.0000}", x0));
                listBox13.Items.Add(string.Format("{0:0.000000}", f(x0,y)));
                listBox1.Items.Add(string.Format("{0:0.000000}", f(x0, y)));
                listBox14.Items.Add(string.Format("{0:0.00000}", h));
                listBox15.Items.Add(m);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox3.Text);
            double y0 = Convert.ToDouble(textBox4.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double b = Convert.ToDouble(textBox6.Text);
            double eps = Convert.ToDouble(textBox7.Text);
            dif(x0, y0, b, h, eps);
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBox4.Visible = true;
            listBox5.Visible = true;
            listBox6.Visible = true;
        }
    }
}
