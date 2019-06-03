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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            Label LB_VUZ = new Label();
                LB_VUZ.Text = "     Федеральное агентство связи ордена Трудового Красного знамени Федеральное государственное бюджетное "+ "\n" +" образовательное учреждениевысшего образования Московский технический университет связи и информатики";
                LB_VUZ.Font = new Font("Times new roman", 15, FontStyle.Bold);
                LB_VUZ.Size = new Size(this.Width, 50);
                LB_VUZ.TextAlign = ContentAlignment.TopCenter;
                Controls.Add(LB_VUZ);

            Label Disc = new Label();
                Disc.Text = "Лабораторнае работы по дисциплине:"+"\n"+"Языки программирования";
                Disc.Font = new Font("Times new roman", 15, FontStyle.Bold);
                Disc.Size = new Size(this.Width, 50);
                Disc.Location = new Point(0,LB_VUZ.Height+ 20);
                Disc.TextAlign = ContentAlignment.MiddleCenter;
                Controls.Add(Disc);

            Label WhoMadeYou = new Label();
                WhoMadeYou.Text = "Выполнил студент группы БСТ-1703:" + "\n" + "Дрябков Олег";
                WhoMadeYou.Font = new Font("Times new roman", 15, FontStyle.Bold);
                WhoMadeYou.Size = new Size(400, 50);
                WhoMadeYou.Location = new Point(this.Width-WhoMadeYou.Width - 50, (this.Height/ 2)-WhoMadeYou.Height);
                WhoMadeYou.TextAlign = ContentAlignment.MiddleRight;
                Controls.Add(WhoMadeYou);

            int X = 7;
            int nn = 0;
            while (nn != 7)
            {
                nn++;
                Button BT_LB = new Button();
                    BT_LB.Name = "BT_LB"+nn;
                    BT_LB.Location = new Point(X, this.Height - 130);
                    BT_LB.Width = 180;
                    BT_LB.Text = "Лабораторная работа № "+nn;
                    BT_LB.Click += new EventHandler(LabSelector);
                    Controls.Add(BT_LB);
                X = X + 195;
                if (nn == 7)
                {
                    Button BT_Exit = new Button();
                    BT_Exit.Location = new Point(this.Width - BT_Exit.Width - 50, BT_LB.Location.Y + BT_LB.Height + 10);
                    BT_Exit.Width = 100;
                    BT_Exit.Text = "Выход";
                    BT_Exit.Click += new EventHandler (ExitApp);
                    Controls.Add(BT_Exit);
                }
            }
        }
        private void ExitApp(object sende, EventArgs e)
        {
            Application.Exit();
        }
        private void LabSelector(object sender, EventArgs e)
        {
            string tt = sender.ToString();
            switch (tt)
            {
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 1":
                    LB1_Titul f1 = new LB1_Titul();
                    this.Hide();
                    f1.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 2":
                    LB2_Titul f2 = new LB2_Titul();
                    this.Hide();
                    f2.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 3":
                    LB3_Titul f3 = new LB3_Titul();
                    this.Hide();
                    f3.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 4":
                    LB9_Main f4 = new LB9_Main();
                    this.Hide();
                    f4.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 5":
                    LB5_Titul f5 = new LB5_Titul();
                    this.Hide();
                    f5.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 6":
                    LB6_Titul f6 = new LB6_Titul();
                    this.Hide();
                    f6.Show();
                    break;
                case "System.Windows.Forms.Button, Text: Лабораторная работа № 7":
                    LB7_Titul f7 = new LB7_Titul();
                    this.Hide();
                    f7.Show();
                    break;
                default:
                    MessageBox.Show("Somthing went wrong!","Error");
                    break;
            }
          
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
            Application.Exit(); 

        }
    }
}
