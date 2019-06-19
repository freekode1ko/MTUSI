using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PL_Dryabkov_Cs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Label LB_VUZ = new Label();
            LB_VUZ.Text = "     Федеральное агентство связи ордена Трудового Красного знамени Федеральное государственное бюджетное " + "\n" + " образовательное учреждениевысшего образования Московский технический университет связи и информатики";
            LB_VUZ.Font = new Font("Times new roman", 15, FontStyle.Bold);
            LB_VUZ.Size = new Size(this.Width, 50);
            LB_VUZ.TextAlign = ContentAlignment.TopCenter;
            Controls.Add(LB_VUZ);

            Label Disc = new Label();
            Disc.Text = "Лабораторнае работы по дисциплине:" + "\n" + "Языки программирования";
            Disc.Font = new Font("Times new roman", 15, FontStyle.Bold);
            Disc.Size = new Size(this.Width, 50);
            Disc.Location = new Point(0, LB_VUZ.Height + 20);
            Disc.TextAlign = ContentAlignment.MiddleCenter;
            Controls.Add(Disc);

            Label WhoMadeYou = new Label();
            WhoMadeYou.Text = "Выполнил студент группы БСТ-1703:" + "\n" + "Дрябков Олег";
            WhoMadeYou.Font = new Font("Times new roman", 15, FontStyle.Bold);
            WhoMadeYou.Size = new Size(400, 50);
            WhoMadeYou.Location = new Point(this.Width - WhoMadeYou.Width - 50, (this.Height / 2) - WhoMadeYou.Height);
            WhoMadeYou.TextAlign = ContentAlignment.MiddleRight;
            Controls.Add(WhoMadeYou);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_LAB1_Click(object sender, EventArgs e)
        {
            Lab1.Lab1_Title Nf = new Lab1.Lab1_Title();         
            this.Hide();
            Nf.Owner = this;
            Nf.Show();
        }

        private void BT_LAB2_Click(object sender, EventArgs e)
        {
            Lab2.Lab2_Title Nf = new Lab2.Lab2_Title();
            this.Hide();
            Nf.Owner = this;
            Nf.Show();
        }

        private void BT_LAB3_Click(object sender, EventArgs e)
        {
            Lab3.Lab3_Titul Nf = new Lab3.Lab3_Titul();
            this.Hide();
            Nf.Owner = this;
            Nf.Show();
        }

        private void BT_LAB7_Click(object sender, EventArgs e)
        {
            Lab7.Lab7_Main Nf = new Lab7.Lab7_Main();
            this.Hide();
            Nf.Owner = this;
            Nf.Show();
        }

        private void BT_LAB9_Click(object sender, EventArgs e)
        {
            Lab9.Lab9_Main Nf = new Lab9.Lab9_Main();
            this.Hide();
            Nf.Owner = this;
            Nf.Show();
        }
    }
}
