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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            difur();

        }
        void difur()
        {
            double a = 0;
            double b = 0.004;
            double h = 0.0002;
            double E = Convert.ToDouble(textBox1.Text);
            double x = 0;
            double yi = 0;
            double zi = 0;
            double z, y;
            double r = 10;
            double l = 1;
            double c = 0.000001;
            double e = 10;
             listBox1.Items.Add(0.0);
             listBox2.Items.Add(0.0);
             listBox3.Items.Add(0.0);
            for (double i = a; i <= b; i += h)
            {
                x = x + h;
                z = zi + h * (-(r / l) * zi + (e - yi) / (l * c));
                y = yi + h * zi;
                yi = y;
                zi = z;
                listBox1.Items.Add(string.Format("{0:0.0000}",x));
                listBox2.Items.Add(string.Format("{0:0.00}",y));
                listBox3.Items.Add(string.Format("{0:0.00}",z));
            }
        }
    }
    }
