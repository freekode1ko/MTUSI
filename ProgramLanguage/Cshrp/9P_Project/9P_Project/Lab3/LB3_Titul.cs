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
    public partial class LB3_Titul : Form
    {
        public LB3_Titul()
        {
            InitializeComponent();
        }
        Button BT_Next1 = new Button();
        private void LB3_Titul_Load(object sender, EventArgs e)
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

        private void createDescription()
        {
            Label LB_LabText = new Label();
            LB_LabText.Text = "Лаборатоная работа № 3" + "\n" + "Тестирование по книге на тему: "+"\n"+"Системы искуственного интелекта. Часть 2.";
            LB_LabText.Font = new Font("Times new roman", 15, FontStyle.Bold);
            LB_LabText.Size = new Size(this.Width, 80);
            LB_LabText.TextAlign = ContentAlignment.TopCenter;
            Controls.Add(LB_LabText);

            WebBrowser WB_Book = new WebBrowser();
            WB_Book.Navigate(System.IO.Directory.GetCurrentDirectory() + "\\BookFolder\\Book.html");
            WB_Book.Location = new Point(LB_LabText.Location.X+10,LB_LabText.Location.Y + LB_LabText.Height + 20);
            WB_Book.Size = new Size(this.Width -30, this.Height - LB_LabText.Height - 150);
            Controls.Add(WB_Book);
        }
        
        private void BT_Next1_Click(object sende, EventArgs e)
        {
            LB3_Main f2 = new LB3_Main();
            f2.Show();
            this.Hide();
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
