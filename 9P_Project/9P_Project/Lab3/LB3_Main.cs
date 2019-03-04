using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary2;

namespace _9P_Project
{
    public partial class LB3_Main : Form
    {
        public LB3_Main()
        {
            InitializeComponent();
        }

        int corr = 0;
        int wrong = 0;
        int quiz = 1;
        GroupBox GB_Place = new GroupBox();
        CheckBox ChB_Ans = new CheckBox();
        CheckBox ChB_Ans2 = new CheckBox();
        CheckBox ChB_Ans3 = new CheckBox();
        CheckBox ChB_Ans4 = new CheckBox();
        RadioButton RB_Ans = new RadioButton();
        RadioButton RB_Ans2 = new RadioButton();
        RadioButton RB_Ans3 = new RadioButton();
        RadioButton RB_Ans4 = new RadioButton();


        private void LB3_Main_Load(object sender, EventArgs e)
        {
            GB_Place.Location = new Point(20, 20);
            GB_Place.Size = new Size(this.Width - 200, this.Height - 200);
            GB_Place.Text = "Продолжите фразу: Саня, Cаня ...";
            Controls.Add(GB_Place);

            Button BT_Next = new Button();
            BT_Next.Location = new Point(20, this.Height - (Math.Abs(GB_Place.Height - this.Height))/2);
            BT_Next.Size = new Size(100, 30);
            BT_Next.Text = "Ответить";
            BT_Next.Click += new EventHandler(button1_Click);
            Controls.Add(BT_Next);

            int PosY = 20;
            int max = 4;
            int[] x = new int[max];
            Class1.Rand(max , x);
            foreach (int i in x)
            {
                PosY = PosY + 20;
                int rInt = i;
                switch (rInt)
                {
                    case 0:

                        ChB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans.Text = "Хуй соси";
                        ChB_Ans.Width = 100;
                        ChB_Ans.Height = 20;
                        ChB_Ans.Tag = 0;
                        GB_Place.Controls.Add(ChB_Ans);
                        break;
                    case 1:

                        ChB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans2.Text = "Ты впорядке?";
                        ChB_Ans2.Width = 100;
                        ChB_Ans2.Height = 20;
                        ChB_Ans2.Tag = 1;
                        GB_Place.Controls.Add(ChB_Ans2);
                        break;
                    case 2:

                        ChB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans3.Text = "Я незнаю";
                        ChB_Ans3.Width = 100;
                        ChB_Ans3.Height = 20;
                        ChB_Ans3.Tag = 2;
                        GB_Place.Controls.Add(ChB_Ans3);
                        break;
                    case 3:

                        ChB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans4.Text = "Я Саня";
                        ChB_Ans4.Width = 100;
                        ChB_Ans4.Height = 20;
                        ChB_Ans4.Tag = 3;
                        GB_Place.Controls.Add(ChB_Ans4);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (quiz == 1)
            {
                if (ChB_Ans.Checked == true && ChB_Ans2.Checked == false && ChB_Ans3.Checked == false && ChB_Ans4.Checked == false)
                { MessageBox.Show("Correct!"); corr++; }
                else
                { MessageBox.Show("Wrong!"); wrong++; }
            }
            if (quiz == 2)
            {
                if (RB_Ans2.Checked == true)
                { MessageBox.Show("Correct!"); corr++;  }
                else
                { MessageBox.Show("Wrong!"); wrong++; }
                Application.Exit();
            }
            if (quiz == 3)
            {
                if (RB_Ans2.Checked == true)
                { MessageBox.Show("Correct!"); corr++; }
                else
                { MessageBox.Show("Wrong!"); wrong++; }
                Application.Exit();
            }
            if (quiz == 4)
            {
                if (RB_Ans2.Checked == true)
                { MessageBox.Show("Correct!"); corr++; }
                else
                { MessageBox.Show("Wrong!"); wrong++; }
                Application.Exit();
            }
            NextQuas();
            //MessageBox.Show("Правильных ответов: " + corr + "/n" + "Кол-во не правильных ответов: " + wrong, "Reuslt:");
        }
        private void NextQuas()
        {
            GB_Place.Text = "Продолжите фразу: Лично мне ...";
            quiz = 2;
            ChB_Ans.Hide();
            ChB_Ans2.Hide();
            ChB_Ans3.Hide();
            ChB_Ans4.Hide();
            {
                int PosY = 20;
                Random r = new Random();
                int max = 4;
                int[] x = new int[max];
                Class1.Rand(max, x);
                foreach (int i in x)
                {
                    PosY = PosY + 20;
                    int rInt = i;
                    switch (rInt)
                    {
                        case 0:

                            RB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans.Text = "Все равно";
                            RB_Ans.Width = 100;
                            RB_Ans.Height = 20;
                            RB_Ans.Tag = 0;
                            GB_Place.Controls.Add(RB_Ans);
                            break;
                        case 1:

                            RB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans2.Text = "Поебать";
                            RB_Ans2.Width = 100;
                            RB_Ans2.Height = 20;
                            RB_Ans2.Tag = 1;
                            GB_Place.Controls.Add(RB_Ans2);
                            break;
                        case 2:

                            RB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans3.Text = "Я незнаю";
                            RB_Ans3.Width = 100;
                            RB_Ans3.Height = 20;
                            RB_Ans3.Tag = 2;
                            GB_Place.Controls.Add(RB_Ans3);
                            break;
                        case 3:

                            RB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans4.Text = "Я Саня";
                            RB_Ans4.Width = 100;
                            RB_Ans4.Height = 20;
                            RB_Ans4.Tag = 3;
                            GB_Place.Controls.Add(RB_Ans4);
                            break;
                    }
                }
            }
        }
    }
}
