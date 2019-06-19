using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_Dryabkov_Cs.Lab1
{
    public partial class Lab1_Title : Form
    {
        public Lab1_Title()
        {
            InitializeComponent();
        }

        private void Lab1_Title_Load(object sender, EventArgs e)
        {
            Label LB_LabText = new Label();
            LB_LabText.Text = "Лаборатоная работа № 1" + "\n" + "Создание методов на языке программирования C#";
            LB_LabText.Font = new Font("Times new roman", 15, FontStyle.Bold);
            LB_LabText.Size = new Size(this.Width, 50);
            LB_LabText.TextAlign = ContentAlignment.TopCenter;
            Controls.Add(LB_LabText);

            //#1
            Label LB_FoP = new Label();
            LB_FoP.Text = "Постановка задачи 1:" + "\n" + "\n" + "Определите углы между тремя векторами, направленными из общей начальной точки с координатами(0, 0) в конечные точки: точку(2; 5); точку(7; 6); точку(9; 3)." + "\n" + "Назначение процедуры: " + "\n" + "Вычисление угла между 2 - мя векторами, проведенными из точки(0, 0) в точки (x1, y1) и(x2, y2) по формуле:";
            LB_FoP.Font = new Font("Times new roman", 13, FontStyle.Bold);
            LB_FoP.Location = new Point(15, LB_LabText.Location.Y + LB_LabText.Height + 100);
            LB_FoP.Size = new Size(1316, 150);
            Controls.Add(LB_FoP);

            PictureBox PB_Formula = new PictureBox();
            PB_Formula.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Formuls\\Formula1.PNG");
            PB_Formula.Size = new Size(250, 100);
            PB_Formula.Location = new Point(15, LB_FoP.Location.Y + LB_FoP.Height + 30);
            Controls.Add(PB_Formula);

            //#2
            Label LB_FoP2 = new Label();
            LB_FoP2.Text = "Постановка задачи 2:" + "\n" + "\n" + "Ниже представлена формула для вычисления:";
            LB_FoP2.Font = new Font("Times new roman", 13, FontStyle.Bold);
            LB_FoP2.Location = new Point(15, PB_Formula.Location.Y + PB_Formula.Height + 10);
            LB_FoP2.Size = new Size(1316, 70);
            Controls.Add(LB_FoP2);

            PictureBox PB_Formula2 = new PictureBox();
            PB_Formula2.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Formuls\\Formula2.PNG");
            PB_Formula2.Size = new Size(250, 100);
            PB_Formula2.Location = new Point(15, LB_FoP2.Location.Y + LB_FoP2.Height + 30);
            Controls.Add(PB_Formula2);
        }

        private void BT_back_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void BT_forward_Click(object sender, EventArgs e)
        {
            Lab1_Main Nf = new Lab1_Main();
            Nf.Owner = this;
            this.Hide();
            Nf.Show();
        }
        private void Lab1_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
