using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Dryabkov_Cs.Lab2
{
    public partial class Lab2_Title : Form
    {
        public Lab2_Title()
        {
            InitializeComponent();
        }
        int defWeightF;
        private void Lab2_Title_Load(object sender, EventArgs e)
        {


            Label LB_LabText = new Label();
            LB_LabText.Text = "Лаборатоная работа № 2" + "\n" + "Программирование алгоритмов разветвляющихся структур";
            LB_LabText.Font = new Font("Times new roman", 15, FontStyle.Bold);
            LB_LabText.Size = new Size(this.Width, 50);
            LB_LabText.TextAlign = ContentAlignment.TopCenter;
            Controls.Add(LB_LabText);

            Label LB_FoP = new Label();
            LB_FoP.Text = "Постановка задачи:" + "\n" + "\n" + "Постройте таблицу и найдите наибольшее значение функции z=f(x) при изменении x на отрезке [a;b]c шагом h.";
            LB_FoP.Font = new Font("Times new roman", 13, FontStyle.Bold);
            LB_FoP.Location = new Point(15, LB_LabText.Location.Y + LB_LabText.Height + 100);
            LB_FoP.Size = new Size(this.Width, 150);
            Controls.Add(LB_FoP);

            PictureBox PB_Formula = new PictureBox();
            PB_Formula.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Formuls\\Formula3.PNG");
            PB_Formula.Size = new Size(370, 100);
            PB_Formula.Location = new Point(15, LB_FoP.Location.Y + LB_FoP.Height + 30);
            Controls.Add(PB_Formula);

            defWeightF = this.Width;
            int defHeightF = this.Height;
            this.WindowState = FormWindowState.Normal;
            this.Width = 5;
            this.Height = defHeightF;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Width != defWeightF)
                this.Width = this.Width + 100;
            if (this.Width >= defWeightF)
                this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2_Main Nf = new Lab2_Main();
            this.Hide();
            Nf.Owner = this;
            Nf.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void Lab2_Title_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
