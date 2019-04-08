using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryLab2;

namespace _9P_Project
{
    public partial class LB2_Main : Form
    {
        //Exp text (description task 1)
        Label Desc1 = new Label();

        //Point B
        Label LB_B = new Label();
        TextBox TB_B = new TextBox();

        //Point C
        Label LB_C = new Label();
        TextBox TB_C = new TextBox();

        //Point X(start,end)
        Label LB_X_S = new Label();
        TextBox TB_Xs = new TextBox();
        TextBox TB_Xe = new TextBox();
        Label LB_S_E = new Label();

        //Step H
        Label LB_H = new Label();
        TextBox TB_H = new TextBox();

        //Exp text (description)
        Label Desc2 = new Label();

        //Ans to ListBox
        ListBox LB_MoreThanOne = new ListBox();
        ListBox LB_LessThanZero = new ListBox();
        ListBox LB_EqualZero = new ListBox();

        //Max(Z)
        TextBox TB_Max = new TextBox();

        //Exp text (description task 2)
        Label Desc3 = new Label();

        //Point B
        Label LB_B2 = new Label();
        TextBox TB_B2 = new TextBox();

        //Point C
        Label LB_C2 = new Label();
        TextBox TB_C2 = new TextBox();

        //End of Segment
        Label LB_Se = new Label();
        TextBox TB_Se = new TextBox();

        //Ans to TextBox
        Label LB_Ans = new Label();
        TextBox TB_Ans = new TextBox();

        public LB2_Main()
        {
            InitializeComponent();
        }

        private void LB2_Main_Load(object sender, EventArgs e)
        {
            
            Desc1.Location = new Point(10, 30);
            Desc1.Size = new Size(250, 15);
            Desc1.Text = "Задание 1: Задайте B,C, Отрезок и шаг:";
            Controls.Add(Desc1);

            CreatePointB();
            CreatePointC();
            CreatePointX();
            CreateStepH();

            Desc3.Location = new Point(TB_H.Location.X + TB_H.Width + 150, Desc1.Location.Y);
            Desc3.Size = new Size(350, 15);
            Desc3.Text = "Задание 2: Задайте Свободные переменный и конец отрезка:";
            Controls.Add(Desc3);

            CreatePointB2();
            CreatePointC2();
            CreatePointSe();
            CreateTBAns();

            Desc2.Location = new Point(Desc1.Location.X, LB_X_S.Location.Y + LB_X_S.Height + 80);
            Desc2.Size = new Size(165, 15);
            Desc2.Text = "Результат работы программы: ";
            Controls.Add(Desc2);

            CreateListBoxes();

            Button BT_Run = new Button();
            BT_Run.Text = "Выполнить расчет";
            BT_Run.Width = 150;
            BT_Run.Location = new Point(this.Width / 10, this.Height - 100);
            BT_Run.Click += new EventHandler(Run_click);
            Controls.Add(BT_Run);

            Button BT_Exit = new Button();
            BT_Exit.Text = "Назад";
            BT_Exit.Width = 100;
            BT_Exit.Location = new Point(this.Width / 4, this.Height - 100);
            BT_Exit.Click += new EventHandler(LB1_main_FormClosing);
            Controls.Add(BT_Exit);
        }

        void TB_KeuPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 45) // цифры, BackSpace и запятая
            {
                e.Handled = true;
            }
        }
        //Обработчик события нажатия кнопки 
        private void Run_click(object sender, EventArgs e)
        {   
            double B, C, Xs, Xe, H; //task1
            double B2, C2, Xe2; //task2
            try
            {
                LB_MoreThanOne.Items.Clear();
                LB_LessThanZero.Items.Clear();
                LB_EqualZero.Items.Clear();
                TB_Max.Text = null;

                B = Convert.ToDouble(TB_B.Text);
                C = Convert.ToDouble(TB_C.Text);
                Xs = Convert.ToDouble(TB_Xs.Text);
                Xe = Convert.ToDouble(TB_Xe.Text);
                H = Convert.ToDouble(TB_H.Text);
                //task1
                LB_MoreThanOne.Items.Add("Значения при Х > 1");
                LB_LessThanZero.Items.Add("Значения при Х < 0");
                LB_EqualZero.Items.Add("Значения при других Х");
                for (; Xs <= Xe; Xs = Xs + H)
                { TB_Max.Text = Resh(B, C, Xs, Xe, H).ToString(); }
                //task2
                B2 = Convert.ToDouble(TB_B2.Text);
                C2 = Convert.ToDouble(TB_C2.Text);
                Xe2 = Convert.ToDouble(TB_Se.Text);
                double VivvTask2 = Class1.Ans(B2, C2, Xe2);
                Class1.Viv2(TB_Ans, VivvTask2);
            }
            catch
            { MessageBox.Show("Проверьте данные и попробуйте еще раз.", "Что то пошло не так при попытке расчета.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Метод определения вывода табуляции в нужный блок
        private double Resh(double B, double C, double Xs, double Xe, double H)
        {
           
                double LocPer = double.MinValue;
                if (Xs > 1)
                {
                    double Vivv = Class1.Ans(B, C, Xs);
                    Class1.Viv(LB_MoreThanOne, Vivv);
                if (Vivv > LocPer) // Поиск максимума на отрезке [1; double.MaxValue]
                    LocPer = Vivv;
                return LocPer;
                }
                else
                {
                    if (Xs < 0)
                    {
                        double Vivv = Class1.Ans(B, C, Xs);
                        Class1.Viv(LB_LessThanZero, Vivv);
                    if (Vivv > LocPer) // Поиск максимума на отрезке [double.MinValue; 0]
                        LocPer = Vivv;
                    return LocPer;
                    }
                    else
                    {
                        double Vivv = Class1.Ans(B, C, Xs);
                        Class1.Viv(LB_EqualZero, Vivv);
                    if (Vivv > LocPer) // Поиск максимума на отрезке [0;1]
                        LocPer = Vivv;
                    return LocPer;
                    } 
                }
        }

        private void CreatePointB()
        {
            // B
            LB_B.Location = new Point(Desc1.Location.X, Desc1.Location.Y + Desc1.Height + 20);
            LB_B.Width = 20;
            LB_B.Text = "B: ";
            Controls.Add(LB_B);

            TB_B.Size = new Size(55, 20);
            TB_B.Location = new Point(LB_B.Location.X + LB_B.Width + 1, LB_B.Location.Y - 3);
            TB_B.KeyPress += TB_KeuPress;
            Controls.Add(TB_B);
        }
        private void CreatePointC()
        {
            // C
            LB_C.Location = new Point(LB_B.Location.X + LB_C.Width + 10, Desc1.Location.Y + Desc1.Height + 20);
            LB_C.Width = 20;
            LB_C.Text = "C: ";
            Controls.Add(LB_C);

            TB_C.Size = new Size(55, 20);
            TB_C.Location = new Point(LB_C.Location.X + LB_C.Width + 1, LB_C.Location.Y - 3);
            TB_C.KeyPress += TB_KeuPress;
            Controls.Add(TB_C);
        }
        private void CreatePointX()
        {
            //point X
            LB_X_S.Location = new Point(LB_C.Location.X + LB_X_S.Width + 10, Desc1.Location.Y + Desc1.Height + 20);
            LB_X_S.Width = 55;
            LB_X_S.Text = "Отрезок(";
            Controls.Add(LB_X_S);

            TB_Xs.Size = new Size(55, 20);
            TB_Xs.Location = new Point(LB_X_S.Location.X + LB_X_S.Width + 1, LB_X_S.Location.Y - 3);
            TB_Xs.KeyPress += TB_KeuPress;
            Controls.Add(TB_Xs);

            TB_Xe.Size = new Size(55, 20);
            TB_Xe.Location = new Point(TB_Xs.Location.X + TB_Xs.Width + 5, LB_X_S.Location.Y - 3);
            TB_Xe.KeyPress += TB_KeuPress;
            Controls.Add(TB_Xe);

            LB_S_E.Location = new Point(TB_Xe.Location.X + TB_Xe.Width + 1, LB_X_S.Location.Y);
            LB_S_E.Text = ")";
            LB_S_E.Width = 20;
            Controls.Add(LB_S_E);
        }
        private void CreateStepH()
        {
            // Step H
            LB_H.Location = new Point(LB_S_E.Location.X + LB_S_E.Width + 10, Desc1.Location.Y + Desc1.Height + 20);
            LB_H.Width = 30;
            LB_H.Text = "Шаг: ";
            Controls.Add(LB_H);

            TB_H.Size = new Size(55, 20);
            TB_H.Location = new Point(LB_H.Location.X + LB_H.Width + 1, LB_H.Location.Y - 3);
            TB_H.KeyPress += TB_KeuPress;
            Controls.Add(TB_H);
        }

        private void CreateListBoxes()
        {
            //LB_MoreThanOne
            LB_MoreThanOne.Height = this.Height / 3;
            LB_MoreThanOne.Width = 155;
            LB_MoreThanOne.Location = new Point(Desc2.Location.X+3, Desc2.Location.Y + Desc2.Height + 10);
            Controls.Add(LB_MoreThanOne);
            //LB_LessThanZero
            LB_LessThanZero.Height = this.Height / 3;
            LB_LessThanZero.Width = 155;
            LB_LessThanZero.Location = new Point(LB_MoreThanOne.Location.X + LB_MoreThanOne.Width + 10, Desc2.Location.Y + Desc2.Height + 10);
            Controls.Add(LB_LessThanZero);
            //LB_EqualZero
            LB_EqualZero.Height = this.Height / 3;
            LB_EqualZero.Width = 155;
            LB_EqualZero.Location = new Point(LB_LessThanZero.Location.X + LB_LessThanZero.Width + 10, Desc2.Location.Y + Desc2.Height + 10);
            Controls.Add(LB_EqualZero);
            //Label for desc
            Label desc = new Label();
            desc.Location = new Point(LB_MoreThanOne.Location.X+50, LB_MoreThanOne.Location.Y + LB_MoreThanOne.Height + 20);
            desc.Text = "Наибольшее значение функции: ";
            desc.Width = 200;
            Controls.Add(desc);

            //TextBox for Max(Z)
            TB_Max.Location = new Point(desc.Location.X+desc.Width+10,LB_MoreThanOne.Location.Y + LB_MoreThanOne.Height + 17);
            TB_Max.Enabled = false;
            Controls.Add(TB_Max);
        }

        private void CreatePointB2()
        {
            //B2
            LB_B2.Location = new Point(Desc3.Location.X, Desc3.Location.Y + Desc3.Height + 20);
            LB_B2.Width = 20;
            LB_B2.Text = "B: ";
            Controls.Add(LB_B2);

            TB_B2.Size = new Size(55, 20);
            TB_B2.Location = new Point(LB_B2.Location.X + LB_B2.Width + 1, LB_B2.Location.Y - 3);
            TB_B2.KeyPress += TB_KeuPress;
            Controls.Add(TB_B2);
        }
        private void CreatePointC2()
        {           
            // C2
            LB_C2.Location = new Point(LB_B2.Location.X + LB_C2.Width + 10, Desc3.Location.Y + Desc3.Height + 20);
            LB_C2.Width = 20;
            LB_C2.Text = "C: ";
            Controls.Add(LB_C2);

            TB_C2.Size = new Size(55, 20);
            TB_C2.Location = new Point(LB_C2.Location.X + LB_C2.Width + 1, LB_C2.Location.Y - 3);
            TB_C2.KeyPress += TB_KeuPress;
            Controls.Add(TB_C2);
        }
        private void CreatePointSe()
        {
            //End of segment
            LB_Se.Location = new Point(Desc3.Location.X, LB_B2.Location.Y + LB_B2.Height + 20);
            LB_Se.Width = 20;
            LB_Se.Text = "Х: ";
            Controls.Add(LB_Se);

            TB_Se.Size = new Size(55, 20);
            TB_Se.Location = new Point(LB_Se.Location.X + LB_Se.Width + 1, LB_Se.Location.Y - 3);
            TB_Se.KeyPress += TB_KeuPress;
            Controls.Add(TB_Se);
        }
        private void CreateTBAns()
        {
            //End of segment
            LB_Ans.Location = new Point(Desc3.Location.X, LB_Se.Location.Y + LB_Se.Height + 20);
            LB_Ans.Width = 20;
            LB_Ans.Text = "Z: ";
            Controls.Add(LB_Ans);

            TB_Ans.Size = new Size(255, 20);
            TB_Ans.Location = new Point(LB_Ans.Location.X + LB_Ans.Width + 1, LB_Ans.Location.Y - 3);
            TB_Ans.Enabled = false;
            Controls.Add(TB_Ans);
        }
        
        private void LB1_main_FormClosing(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            MP.Show();
        }
        private void LB2_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
