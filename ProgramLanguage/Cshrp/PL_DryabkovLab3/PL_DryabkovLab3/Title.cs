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

namespace PL_DryabkovLab3
{
    public partial class Title : Form
    {
        public Title()
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
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.iprbookshop.ru/52144.html");
            webBrowser1.Visible = true;
        }
    }
}
