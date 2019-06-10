using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_DryabkovLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {        }
        //Контроль ввода
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !(Char.IsControl(e.KeyChar)))
            {       
                if (!(e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1) && !(e.KeyChar.ToString() == "-"))
                    e.Handled = true;
            }
            if (e.KeyChar.Equals((char)13))
                textBox2.Focus();
        }
        //Анимация появления окна
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Width < 1640)
            {   Width += 20;
                this.Width = Width;}
            else
            {   Width = 1650;
                this.Width = Width;
                this.WindowState = FormWindowState.Maximized;
                this.MaximumSize = this.Size;
                timer1.Enabled = false;
            }
        }
        //Событийная функция
        private void button1_Click(object sender, EventArgs e)
        {   Lab2Class.Class1 tr = new Lab2Class.Class1();
            double m = tr.Vvod(textBox5);
            double n = tr.Vvod(textBox6);
            double c = tr.Vvod(textBox1);
            double b = tr.Vvod(textBox2);
            double h = tr.Vvod(textBox3);
            tr.ResultProc(b, c, m, h, n, listBox1, textBox4);
        }
    }
}
