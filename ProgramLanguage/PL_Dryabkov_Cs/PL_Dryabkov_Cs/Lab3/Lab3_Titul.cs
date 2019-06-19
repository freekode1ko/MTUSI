using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PL_Dryabkov_Cs.Lab3
{
    public partial class Lab3_Titul : Form
    {
        public Lab3_Titul()
        {
            InitializeComponent();
        }

        private void Title_Load(object sender, EventArgs e)
        {}

        private void Title_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath z = new GraphicsPath();
            z.AddEllipse(-200, -200, this.Width + 400, this.Height + 200);
            this.Region = new Region(z);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab3_Main Nf = new Lab3_Main();
            Nf.Owner = this;
            this.Hide();
            Nf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.iprbookshop.ru/52144.html");
            webBrowser1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }
    }
}
