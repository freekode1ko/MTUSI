using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9P_Project
{
    public partial class LB2_Titul : Form
    {
        public LB2_Titul()
        {
            InitializeComponent();
        }
        Button BT_Next1 = new Button();
        private void LB2_Titul_Load(object sender, EventArgs e)
        {
            BT_Next1.Location = new Point(7, this.Height - 130);
            BT_Next1.Width = 150;
            BT_Next1.Text = "Перейти к решению";
            BT_Next1.Click += new EventHandler(BT_Next1_Click);
            Controls.Add(BT_Next1);

            createDescription();

            Button BT_Exit = new Button();
            BT_Exit.Text = "Назад";
            BT_Exit.Width = 100;
            BT_Exit.Location = new Point(this.Width / 4, this.Height - 130);
            BT_Exit.Click += new EventHandler(LB1_FormClosing);
            Controls.Add(BT_Exit);
        }

        private void BT_Next1_Click(object sende, EventArgs e)
        {
            LB2_Main f2 = new LB2_Main();
            f2.Show();
            this.Hide();
        }

        private void createDescription()
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
        }

        private void LB1_FormClosing(object sende, EventArgs e)
        {
            MainPage MP = new MainPage();
            MP.ShowDialog();
        }

        private void LB2_Titul_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
