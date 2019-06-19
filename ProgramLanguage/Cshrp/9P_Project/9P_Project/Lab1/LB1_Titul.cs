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
    public partial class LB1_Titul : Form
    {
        public LB1_Titul()
        {
            InitializeComponent();
        }
        Button BT_Next1 = new Button();
        Button BT_Next2 = new Button();

        private void LB1_Load(object sender, EventArgs e)
        {
            BT_Next1.Location = new Point(7, this.Height - 130);
            BT_Next1.Width = 150;
            BT_Next1.Text = "Перейти к решению №1";
            BT_Next1.Click += new EventHandler(BT_Next1_Click);
            Controls.Add(BT_Next1);

            BT_Next2.Location = new Point(BT_Next1.Location.X + BT_Next1.Width + 10, this.Height - 130);
            BT_Next2.Width = 150;
            BT_Next2.Text = "Перейти к решению №2";
            BT_Next2.Click += new EventHandler(BT_Next1_Click);
            Controls.Add(BT_Next2);

            createDescription();

            Button BT_Exit = new Button();
                BT_Exit.Text = "Назад";
                BT_Exit.Width = 100;
                BT_Exit.Location = new Point(this.Width / 4, this.Height - 130);
                BT_Exit.Click += new EventHandler(LB1_FormClosing);
                Controls.Add(BT_Exit);

        }

        private void createDescription()
        {
        Label LB_LabText = new Label();
            LB_LabText.Text = "Лаборатоная работа № 1"+"\n"+"Создание методов на языке программирования C#";
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

        private void BT_Next1_Click(object sende, EventArgs e)
        {
            bool RESH;
            if (sende.ToString() != "System.Windows.Forms.Button, Text: Перейти к решению №1")
            { RESH = true; } else { RESH = false; }
            LB1_main f1 = new LB1_main(RESH);
            f1.Show();
            this.Hide();
        }

        private void LB1_FormClosing(object sende, EventArgs e)
        {
            MainPage MP = new MainPage();
            MP.ShowDialog();
        }

        private void LB1_Titul_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
