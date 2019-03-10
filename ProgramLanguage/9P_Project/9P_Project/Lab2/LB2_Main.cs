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
        public LB2_Main()
        {
            InitializeComponent();
        }
        //Exp text (description)
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

        private void LB2_Main_Load(object sender, EventArgs e)
        {
            
            Desc1.Location = new Point(10, 30);
            Desc1.Size = new Size(165, 15);
            Desc1.Text = "Задайте B,C, Отрезок и шаг:";
            Controls.Add(Desc1);

            CreatePointB();
            CreatePointC();
            CreatePointX();
            CreateStepH();

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

        private void Run_click(object sender, EventArgs e)
        {   
            double B, C, Xs, Xe, H;
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

                LB_MoreThanOne.Items.Add("Значения при Х > 1");
                LB_LessThanZero.Items.Add("Значения при Х < 0");
                LB_EqualZero.Items.Add("Значения при других Х");
                for(;Xs<=Xe;Xs=Xs+H)
               // while (Xs<=Xe)
                {
                    if (Xs > 1)
                    // LB_MoreThanOne.Items.Add(Ans(B,C,Xs));
                    { LB_MoreThanOne.Items.Add(Class1.Ans(B, C, Xs)); }
                    else
                    {
                        if (Xs < 0)
                        // LB_LessThanZero.Items.Add(Ans(B, C, Xs));
                        { LB_LessThanZero.Items.Add(Class1.Ans(B, C, Xs)); }
                        else
                        {
                            //LB_EqualZero.Items.Add(Ans(B, C, Xs));
                            LB_EqualZero.Items.Add(Class1.Ans(B, C, Xs));
                        }
                    }
                    //Xs = Xs + H;
                }
                int nn1 = LB_MoreThanOne.Items.Count; int nn2 = LB_LessThanZero.Items.Count; int nn3 = LB_EqualZero.Items.Count;
                double MaxTable1 =0, MaxTable2=0, MaxTable3=0;
                while (nn1 != 1)
                {
                    LB_MoreThanOne.SelectedIndex = nn1-1;
                    if (MaxTable1 < Convert.ToDouble(LB_MoreThanOne.GetItemText(LB_MoreThanOne.SelectedItem)))
                    { MaxTable1 = Convert.ToDouble(LB_MoreThanOne.GetItemText(LB_MoreThanOne.SelectedItem)); }
                    else { nn1--; }
                }
                while (nn2 != 1)
                {
                    LB_LessThanZero.SelectedIndex = nn2 - 1;
                    if (MaxTable2 < Convert.ToDouble(LB_LessThanZero.GetItemText(LB_LessThanZero.SelectedItem)))
                    { MaxTable2 = Convert.ToDouble(LB_LessThanZero.GetItemText(LB_LessThanZero.SelectedItem)); }
                    else { nn2--; }
                }

                while (nn3 != 1)
                {
                    LB_EqualZero.SelectedIndex = nn3 - 1;
                    if (MaxTable3 < Convert.ToDouble(LB_EqualZero.GetItemText(LB_EqualZero.SelectedItem)))
                    { MaxTable3 = Convert.ToDouble(LB_EqualZero.GetItemText(LB_EqualZero.SelectedItem)); }
                    else { nn3--; }
                }

                if (MaxTable1 > MaxTable2)
                { TB_Max.Text = MaxTable1.ToString(); }
                else { TB_Max.Text = MaxTable2.ToString(); }
                

                if (Convert.ToDouble(TB_Max.Text) < MaxTable3)
                { TB_Max.Text = MaxTable3.ToString(); }
            }
            catch
            { MessageBox.Show("Проверьте данные и попробуйте еще раз.", "Что то пошло не так при попытке расчета.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /*   private double Ans(double B, double C, double X)
           {
               double LocalPEr;
                   if (X > 1)
                   {return X * (Math.Sqrt(B * B + C * C)); }
                   if (X < 0)
                   {
                   LocalPEr = Math.Min(Math.Sqrt(B), X * X);
                       return Math.Min(LocalPEr, X + C);
                   }
               return Math.Max(Math.Log(B), X + C);
           }*/

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
