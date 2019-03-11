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
        int quiz = 0;
        Button BT_Next = new Button();
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
            GB_Place.Size = new Size(this.Width - 50, this.Height - 200);
            GB_Place.Text = "Что такое машинное обучение?";
            GB_Place.Font = new Font("Times New Roman", 16.0f);
            Controls.Add(GB_Place);

            BT_Next.Location = new Point(20, this.Height - (Math.Abs(GB_Place.Height - this.Height))/2);
            BT_Next.Size = new Size(100, 30);
            BT_Next.Text = "Ответить";
            BT_Next.Click += new EventHandler(BT_Next_Click);
            Controls.Add(BT_Next);

            RB_Ans.Width = 1300;
            RB_Ans2.Width = 1300;
            RB_Ans3.Width = 1300;
            RB_Ans4.Width = 1300;

            RB_Ans.Height = 40;
            RB_Ans2.Height = 40;
            RB_Ans3.Height = 40;
            RB_Ans4.Height = 40;

            ChB_Ans.Width = 1300;
            ChB_Ans2.Width = 1300;
            ChB_Ans3.Width = 1300;
            ChB_Ans4.Width = 1300;

            ChB_Ans.Height = 40;
            ChB_Ans2.Height = 40;
            ChB_Ans3.Height = 40;
            ChB_Ans4.Height = 40;


            int PosY = 40;
            int max = 4;
            int[] x = new int[max];
            Class1.Rand(max , x);
            foreach (int i in x)
            {
                PosY = PosY + 40;
                int rInt = i;
                switch (rInt)
                {
                    case 0:

                        ChB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans.Text = "Методы, которые позволят компьютерам повышать эффективность своих действий с помощью накопленного опыта.";
                        
                         
                        ChB_Ans.Tag = 0;
                        GB_Place.Controls.Add(ChB_Ans);
                        break;
                    case 1:

                        ChB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans2.Text = "Это процесс работы программы для работы с большим обьемом данных";
                         
                         
                        ChB_Ans2.Tag = 1;
                        GB_Place.Controls.Add(ChB_Ans2);
                        break;
                    case 2:

                        ChB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans3.Text = "Это наука об изучении построении логики процессоров";
                         
                         
                        ChB_Ans3.Tag = 2;
                        GB_Place.Controls.Add(ChB_Ans3);
                        break;
                    case 3:

                        ChB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                        ChB_Ans4.Text = "Это способ обучения роботов примитивным действиям";
                         
                         
                        ChB_Ans4.Tag = 3;
                        GB_Place.Controls.Add(ChB_Ans4);
                        break;
                }
            }
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            if (quiz == 0)
            {
                if (ChB_Ans.Checked == true && ChB_Ans2.Checked == false && ChB_Ans3.Checked == false && ChB_Ans4.Checked == false)
                {   corr++; }
                else
                {  wrong++; }
            }
            if (quiz == 1)
            {
                if (RB_Ans2.Checked == true)
                {   corr++; }
                else
                {  wrong++; }
            }
            if (quiz == 2)
            {
                if (ChB_Ans3.Checked == true && ChB_Ans2.Checked == false && ChB_Ans.Checked == false && ChB_Ans4.Checked == false)
                {   corr++; }
                else
                {  wrong++; }
            }
            if (quiz == 3)
            {
                if (RB_Ans3.Checked == true)
                {   corr++; }
                else
                {  wrong++; }
                Button BT_Exit = new Button();
                BT_Exit.Location = new Point(BT_Next.Location.X + BT_Next.Width + 20, BT_Next.Location.Y);
                BT_Exit.Size = new Size(BT_Next.Width,BT_Next.Height);
                BT_Exit.Text = "Выход";
                BT_Exit.Click += new EventHandler(BT_Exit_Click);
                Controls.Add(BT_Exit);
            }
            int AnsCount = wrong + corr;
            if (quiz >=3)
                MessageBox.Show("Правильных ответов: " + corr + "\n" + "Кол-во не правильных ответов: " + wrong + "\n" + "Из " + AnsCount + " вопросов.", "Reuslt:");
            quiz++;
            NextQuas();
        }

        private void NextQuiz()
        {
            GB_Place.Text = "Что такое нейронная сеть?";
            HideAns();
            ChB_Ans.Show();
            ChB_Ans2.Show();
            ChB_Ans3.Show();
            ChB_Ans4.Show();
            {
                int PosY = 40;
                Random r = new Random();
                int max = 4;
                int[] x = new int[max];
                Class1.Rand(max, x);
                foreach (int i in x)
                {
                    PosY = PosY + 40;
                    int rInt = i;
                    switch (rInt)
                    {
                        case 0:

                            ChB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            ChB_Ans.Text = "Отдел головного мозга";
                            
                             
                            ChB_Ans.Tag = 0;
                            GB_Place.Controls.Add(ChB_Ans);
                            break;
                        case 1:

                            ChB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            ChB_Ans2.Text = "Логическая цепочка дынных напоминающая дерево";
                             
                             
                            ChB_Ans2.Tag = 1;
                            GB_Place.Controls.Add(ChB_Ans2);
                            break;
                        case 2:

                            ChB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            ChB_Ans3.Text = "Нейронная сеть — вид вычислительной системы, которая имитирует свойства нейронов в живых организмах.";
                             
                             
                            ChB_Ans3.Tag = 2;
                            GB_Place.Controls.Add(ChB_Ans3);
                            break;
                        case 3:

                            ChB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            ChB_Ans4.Text = "это новый вид компьютеров";
                             
                             
                            ChB_Ans4.Tag = 3;
                            GB_Place.Controls.Add(ChB_Ans4);
                            break;
                    }
                }
            }
        }
        private void HideAns()
        {
            RB_Ans.Hide();
            RB_Ans2.Hide();
            RB_Ans3.Hide();
            RB_Ans4.Hide();
            ChB_Ans.Hide();
            ChB_Ans2.Hide();
            ChB_Ans3.Hide();
            ChB_Ans4.Hide();

            RB_Ans.Checked = false;
            RB_Ans2.Checked = false;
            RB_Ans3.Checked = false;
            RB_Ans4.Checked = false;
            ChB_Ans.Checked = false;
            ChB_Ans2.Checked = false;
            ChB_Ans3.Checked = false;
            ChB_Ans4.Checked = false;
        }
        private void NextQuas()
        {
            if (quiz == 3)
            { NextQiz(); }
            if (quiz == 2)
            { NextQuiz();}
            if (quiz ==1)
            { NextQz(); };
        }
        private void NextQiz()
        {
            GB_Place.Text = "Что такое УИИ?";
            HideAns();

            RB_Ans.Show();
            RB_Ans2.Show();
            RB_Ans3.Show();
            RB_Ans4.Show();
            {
                int PosY = 40;
                Random r = new Random();
                int max = 4;
                int[] x = new int[max];
                Class1.Rand(max, x);
                foreach (int i in x)
                {
                    PosY = PosY + 40;
                    int rInt = i;
                    switch (rInt)
                    {
                        case 0:

                            RB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans.Text = "“Уникальный Индитефикатор Иностранца”";
                             
                             
                            RB_Ans.Tag = 0;
                            GB_Place.Controls.Add(RB_Ans);
                            break;
                        case 1:

                            RB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans2.Text = "Ничего";
                             
                             
                            RB_Ans2.Tag = 1;
                            GB_Place.Controls.Add(RB_Ans2);
                            break;
                        case 2:

                            RB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans3.Text = "“универсальный ИИ”";
                             
                             
                            RB_Ans3.Tag = 2;
                            GB_Place.Controls.Add(RB_Ans3);
                            break;
                        case 3:

                            RB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans4.Text = "Уголовно-исполнительная инспекция";
                             
                             
                            RB_Ans4.Tag = 3;
                            GB_Place.Controls.Add(RB_Ans4);
                            break;
                    }
                }
            }
        }
        private void NextQz()
        {
            GB_Place.Text = "Что такое закон Мура?";
            HideAns();

            RB_Ans.Show();
            RB_Ans2.Show();
            RB_Ans3.Show();
            RB_Ans4.Show();
            {
                int PosY = 40;
                Random r = new Random();
                int max = 4;
                int[] x = new int[max];
                Class1.Rand(max, x);
                foreach (int i in x)
                {
                    PosY = PosY + 40;
                    int rInt = i;
                    switch (rInt)
                    {
                        case 0:

                            RB_Ans.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans.Text = "Сумма всех токов, втекающих в узел, равна сумме всех токов, вытекающих из узла.";
                             
                             
                            RB_Ans.Tag = 0;
                            GB_Place.Controls.Add(RB_Ans);
                            break;
                        case 1:

                            RB_Ans2.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans2.Text = "Скорость вычислений, которую можно получить за определённую сумму, удваивается каждые N месяцев, где N примерно равно 18.";
                             
                             
                            RB_Ans2.Tag = 1;
                            GB_Place.Controls.Add(RB_Ans2);
                            break;
                        case 2:

                            RB_Ans3.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans3.Text = "Закон, определяющий связь электродвижущей силы источника с силой тока, протекающего в проводнике.";
                             
                             
                            RB_Ans3.Tag = 2;
                            GB_Place.Controls.Add(RB_Ans3);
                            break;
                        case 3:

                            RB_Ans4.Location = new Point(GB_Place.Location.X + 10, GB_Place.Location.Y + PosY);
                            RB_Ans4.Text = "Сила взаимодействия между двумя точечными электрическими зарядами пропорциональна величинам этих зарядов .";
                             
                             
                            RB_Ans4.Tag = 3;
                            GB_Place.Controls.Add(RB_Ans4);
                            break;
                    }
                }
            }
        }
        private void BT_Exit_Click(object sender, EventArgs e)
        {
            MainPage fm1 = new MainPage();
            fm1.Show();
            this.Close();
        }
    }
}
