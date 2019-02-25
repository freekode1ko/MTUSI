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
    public partial class LB1_main : Form
    {
        bool Test;
        public LB1_main(bool RESH)
        {
            InitializeComponent();
            Test = RESH;
        }
// Task #1

        //Exp text (description)
        Label Desc1 = new Label();
        
        //Point A(x,y)
        Label LB_A_S = new Label();
        TextBox TB_Ax = new TextBox();
        TextBox TB_Ay = new TextBox();
        Label LB_A_E = new Label();

        //Point B(x,y)
        Label LB_B_S = new Label();
        TextBox TB_Bx = new TextBox();
        TextBox TB_By = new TextBox();
        Label LB_B_E = new Label();

        //Point C(x,y)
        Label LB_C_S = new Label();
        TextBox TB_Cx = new TextBox();
        TextBox TB_Cy = new TextBox();
        Label LB_C_E= new Label();

        //Exp text (description)
        Label Desc2 = new Label();
        Label Desc3 = new Label();

        //return
        TextBox TB_L12 = new TextBox();
        TextBox TB_L23 = new TextBox();
        TextBox TB_L13 = new TextBox();

        //ref
        TextBox TB_L12Ref = new TextBox();
        TextBox TB_L23Ref = new TextBox();
        TextBox TB_L13Ref = new TextBox();

// Task #2

        //Isxod X:
        Label LB_X = new Label();
        TextBox TB_X = new TextBox();

        //Isxod Y:
        Label LB_Y = new Label();
        TextBox TB_Y = new TextBox();

        //return
        TextBox TB_Ans = new TextBox();

        //ref
        TextBox TB_AnsRef = new TextBox();

        //other ans 
        //return
        TextBox TB_Cint = new TextBox();
        TextBox TB_Csng = new TextBox();
        TextBox TB_Fix = new TextBox();
        TextBox TB_Int = new TextBox();
        TextBox TB_DoubFloat = new TextBox();
        //ref
        TextBox TB_CintRef = new TextBox();
        TextBox TB_CsngRef = new TextBox();
        TextBox TB_FixRef = new TextBox();
        TextBox TB_IntRef = new TextBox();
        TextBox TB_DoubFloatRef = new TextBox();

        private void LB1_main_Load(object sender, EventArgs e)
        {
            if (Test == false)
            {

            Desc1.Location = new Point(10, 30);
            Desc1.Size = new Size(165, 15);
            Desc1.Text = "Задайте конечные точки А,B,C:";
            Controls.Add(Desc1);

            CreatePointA();
            CreatePointB();
            CreatePointC();

            Desc2.Location = new Point(Desc1.Location.X, LB_A_S.Location.Y+ LB_A_S.Height + 80);
            Desc2.Size = new Size(165, 15);
            Desc2.Text = "Результат работы программы: ";
            Controls.Add(Desc2);

            Desc3.Location = new Point(Desc2.Location.X + Desc2.Width + 55, LB_A_S.Location.Y + LB_A_S.Height + 80);
            Desc3.Size = new Size(165, 15);
            Desc3.Text = "Результат работы программы: ";
            Controls.Add(Desc3);

            CreateAns();
            CreateAnsRef();

            Button BT_Run = new Button();
                BT_Run.Text = "Выполнить расчет";
                BT_Run.Width = 150;
                BT_Run.Location = new Point(this.Width / 10, this.Height - 100);
                BT_Run.Click += new EventHandler(Run_click);
                Controls.Add(BT_Run);
            }
            else
            {
                Desc1.Location = new Point(10, 30);
                Desc1.Size = new Size(165, 15);
                Desc1.Text = "Задайте X и Y:";
                Controls.Add(Desc1);

                CreateX();
                CreateY();

                Desc2.Location = new Point(Desc1.Location.X, LB_A_S.Location.Y + LB_A_S.Height + 80);
                Desc2.Size = new Size(200, 15);
                Desc2.Text = "Результат работы программы (return): ";
                Controls.Add(Desc2);

                Desc3.Location = new Point(Desc2.Location.X + Desc2.Width + 55, LB_A_S.Location.Y + LB_A_S.Height + 80);
                Desc3.Size = new Size(190, 15);
                Desc3.Text = "Результат работы программы (ref): ";
                Controls.Add(Desc3);

                CreateAnsTask2();
                CreateAnsRefTask2();
                CreateOtherAns();
                CreateOtherAnsRef();

                Button BT_Run = new Button();
                BT_Run.Text = "Выполнить расчет";
                BT_Run.Width = 150;
                BT_Run.Location = new Point(this.Width / 10, this.Height - 100);
                BT_Run.Click += new EventHandler(Run2_click);
                Controls.Add(BT_Run);
            }

            Button BT_Exit = new Button();
                BT_Exit.Text = "Назад";
                BT_Exit.Width = 100;
                BT_Exit.Location = new Point(this.Width / 4, this.Height - 100);
                BT_Exit.Click += new EventHandler(LB1_main_FormClosing);
                Controls.Add(BT_Exit);
        }
        private void CreateX()
        {
            // X
            LB_X.Location = new Point(Desc1.Location.X, Desc1.Location.Y + Desc1.Height + 20);
            LB_X.Width = 50;
            LB_X.Text = "X: ";
            Controls.Add(LB_X);

            TB_X.Size = new Size(55, 20);
            TB_X.Location = new Point(LB_X.Location.X + LB_X.Width + 1, LB_X.Location.Y - 3);
            Controls.Add(TB_X);
        }
        private void CreateY()
        {
            // Y
            LB_Y.Location = new Point(TB_X.Location.X + TB_X.Width + 10, Desc1.Location.Y + Desc1.Height + 20);
            LB_Y.Width = 50;
            LB_Y.Text = "Y: ";
            Controls.Add(LB_Y);

            TB_Y.Size = new Size(55, 20);
            TB_Y.Location = new Point(LB_Y.Location.X + LB_Y.Width + 1, LB_Y.Location.Y - 3);
            Controls.Add(TB_Y);
        }

        private void CreateAnsTask2 ()
        {
            TB_Ans.Size = new Size(100, 20);
            TB_Ans.Location = new Point(Desc2.Location.X+30, Desc2.Location.Y + Desc2.Height + 20 );
            TB_Ans.Enabled = false;
            Controls.Add(TB_Ans);
        }
        private void CreateAnsRefTask2()
        {
            TB_AnsRef.Size = new Size(100, 20);
            TB_AnsRef.Location = new Point(Desc3.Location.X + 30, Desc2.Location.Y + Desc2.Height + 20);
            TB_AnsRef.Enabled = false;
            Controls.Add(TB_AnsRef);
        }

        private void CreateOtherAns()
        {
            Label LB_Cint = new Label();
            LB_Cint.Size = new Size(100, 12);
            LB_Cint.Location = new Point(Desc2.Location.X + 30, TB_AnsRef.Location.Y + TB_AnsRef.Height+8);
            LB_Cint.Text = "Double to int:";
            Controls.Add(LB_Cint);

            TB_Cint.Size = new Size(100, 20);
            TB_Cint.Location = new Point(Desc2.Location.X + 30, TB_AnsRef.Location.Y + TB_AnsRef.Height + 20);
            TB_Cint.Enabled = false;
            Controls.Add(TB_Cint);

            Label LB_Csng = new Label();
            LB_Csng.Size = new Size(100, 12);
            LB_Csng.Location = new Point(Desc2.Location.X + 30, TB_Cint.Location.Y + TB_Cint.Height + 8);
            LB_Csng.Text = "Double to float:";
            Controls.Add(LB_Csng);

            TB_Csng.Size = new Size(100, 20);
            TB_Csng.Location = new Point(Desc2.Location.X + 30, TB_Cint.Location.Y + TB_Cint.Height + 20);
            TB_Csng.Enabled = false;
            Controls.Add(TB_Csng);

            Label LB_Fix = new Label();
            LB_Fix.Size = new Size(100, 12);
            LB_Fix.Location = new Point(Desc2.Location.X + 30, TB_Csng.Location.Y + TB_Csng.Height + 8);
            LB_Fix.Text = "Целое, без дроби:";
            Controls.Add(LB_Fix);

            TB_Fix.Size = new Size(100, 20);
            TB_Fix.Location = new Point(Desc2.Location.X + 30, TB_Csng.Location.Y + TB_Csng.Height + 20);
            TB_Fix.Enabled = false;
            Controls.Add(TB_Fix);

            Label LB_Int = new Label();
            LB_Int.Size = new Size(100, 12);
            LB_Int.Location = new Point(Desc2.Location.X + 30, TB_Fix.Location.Y + TB_Fix.Height + 8);
            LB_Int.Text = "Округление:";
            Controls.Add(LB_Int);

            TB_Int.Size = new Size(100, 20);
            TB_Int.Location = new Point(Desc2.Location.X + 30, TB_Fix.Location.Y + TB_Fix.Height + 20);
            TB_Int.Enabled = false;
            Controls.Add(TB_Int);

            Label LB_DoubFloat = new Label();
            LB_DoubFloat.Size = new Size(100, 12);
            LB_DoubFloat.Location = new Point(Desc2.Location.X + 30, TB_Int.Location.Y + TB_Int.Height + 8);
            LB_DoubFloat.Text = "Double + Float:";
            Controls.Add(LB_DoubFloat);

            TB_DoubFloat.Size = new Size(100, 20);
            TB_DoubFloat.Location = new Point(Desc2.Location.X + 30, TB_Int.Location.Y + TB_Int.Height + 20);
            TB_DoubFloat.Enabled = false;
            Controls.Add(TB_DoubFloat);
        }

        private void CreateOtherAnsRef()
        {
            Label LB_CintRef = new Label();
            LB_CintRef.Size = new Size(100, 12);
            LB_CintRef.Location = new Point(Desc3.Location.X + 30, TB_AnsRef.Location.Y + TB_AnsRef.Height + 8);
            LB_CintRef.Text = "Double to int:";
            Controls.Add(LB_CintRef);

            TB_CintRef.Size = new Size(100, 20);
            TB_CintRef.Location = new Point(Desc3.Location.X + 30, TB_AnsRef.Location.Y + TB_AnsRef.Height + 20);
            TB_CintRef.Enabled = false;
            Controls.Add(TB_CintRef);

            Label LB_CsngRef = new Label();
            LB_CsngRef.Size = new Size(100, 12);
            LB_CsngRef.Location = new Point(Desc3.Location.X + 30, TB_CintRef.Location.Y + TB_CintRef.Height + 8);
            LB_CsngRef.Text = "Double to float:";
            Controls.Add(LB_CsngRef);

            TB_CsngRef.Size = new Size(100, 20);
            TB_CsngRef.Location = new Point(Desc3.Location.X + 30, TB_CintRef.Location.Y + TB_CintRef.Height + 20);
            TB_CsngRef.Enabled = false;
            Controls.Add(TB_CsngRef);

            Label LB_FixRef = new Label();
            LB_FixRef.Size = new Size(100, 12);
            LB_FixRef.Location = new Point(Desc3.Location.X + 30, TB_CsngRef.Location.Y + TB_CsngRef.Height + 8);
            LB_FixRef.Text = "Целое, без дроби:";
            Controls.Add(LB_FixRef);

            TB_FixRef.Size = new Size(100, 20);
            TB_FixRef.Location = new Point(Desc3.Location.X + 30, TB_CsngRef.Location.Y + TB_CsngRef.Height + 20);
            TB_FixRef.Enabled = false;
            Controls.Add(TB_FixRef);

            Label LB_IntRef = new Label();
            LB_IntRef.Size = new Size(100, 12);
            LB_IntRef.Location = new Point(Desc3.Location.X + 30, TB_FixRef.Location.Y + TB_FixRef.Height + 8);
            LB_IntRef.Text = "Округление:";
            Controls.Add(LB_IntRef);

            TB_IntRef.Size = new Size(100, 20);
            TB_IntRef.Location = new Point(Desc3.Location.X + 30, TB_FixRef.Location.Y + TB_FixRef.Height + 20);
            TB_IntRef.Enabled = false;
            Controls.Add(TB_IntRef);

            Label LB_DoubFloatRef = new Label();
            LB_DoubFloatRef.Size = new Size(100, 12);
            LB_DoubFloatRef.Location = new Point(Desc3.Location.X + 30, TB_IntRef.Location.Y + TB_IntRef.Height + 8);
            LB_DoubFloatRef.Text = "Double + Float:";
            Controls.Add(LB_DoubFloatRef);

            TB_DoubFloatRef.Size = new Size(100, 20);
            TB_DoubFloatRef.Location = new Point(Desc3.Location.X + 30, TB_IntRef.Location.Y + TB_IntRef.Height + 20);
            TB_DoubFloatRef.Enabled = false;
            Controls.Add(TB_DoubFloatRef);
        }

        private void Run2_click(object sender, EventArgs e)
        {
            double X, Y, Ans = 0;
            try
            {
                X = Convert.ToDouble(TB_X.Text);
                Y = Convert.ToDouble(TB_Y.Text);

                TB_Ans.Text = An(X,Y).ToString();
                TB_Cint.Text = Convert.ToString(Convert.ToInt32(An(X, Y)));
                TB_Csng.Text = Convert.ToString(Convert.ToSingle(An(X, Y)));
                TB_Fix.Text = Convert.ToString(Math.Truncate(An(X,Y)));
                TB_Int.Text = Convert.ToString(Math.Round(An(X, Y)));
                TB_DoubFloat.Text = Convert.ToString(Convert.ToDouble(TB_Ans.Text) + Convert.ToDouble(TB_Csng.Text));

                AnRef(ref Ans, X, Y);
                TB_AnsRef.Text = Ans.ToString();
                TB_CintRef.Text = Convert.ToString(Convert.ToInt32(Ans));
                TB_CsngRef.Text = Convert.ToString(Convert.ToSingle(Ans));
                TB_FixRef.Text = Convert.ToString(Math.Truncate(Ans));
                TB_IntRef.Text = Convert.ToString(Math.Round(Ans));
                TB_DoubFloatRef.Text = Convert.ToString(Convert.ToDouble(TB_AnsRef.Text) + Convert.ToDouble(TB_CsngRef.Text));

            }
            catch
            { MessageBox.Show("Проверьте данные и попробуйте еще раз.", "Что то пошло не так при попытке расчета.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private double An(double X, double Y)
        {return (X*Y)+Math.Sin(X)/((Math.Abs(1-Y))*(Math.Log(X)));}
        private void AnRef(ref double Ans, double X, double Y)
        {Ans = An(X, Y);}
        private void Run_click(object sender, EventArgs e)
        {
            double X1, Y1, X2, Y2, Ans=0;
            try
            {
                //A-B
                X1 = Convert.ToDouble(TB_Ax.Text);
                Y1 = Convert.ToDouble(TB_Ay.Text);
                X2 = Convert.ToDouble(TB_Bx.Text);
                Y2 = Convert.ToDouble(TB_By.Text);
                TB_L12.Text = Ugol(X1, Y1, X2, Y2).ToString();
                UgolRef(ref Ans, X1, Y1, X2, Y2);
                TB_L12Ref.Text = Ans.ToString();

                //B-C
                X1 = Convert.ToDouble(TB_Bx.Text);
                Y1 = Convert.ToDouble(TB_By.Text);
                X2 = Convert.ToDouble(TB_Cx.Text);
                Y2 = Convert.ToDouble(TB_Cy.Text);
                TB_L23.Text = Ugol(X1, Y1, X2, Y2).ToString();
                UgolRef(ref Ans, X1, Y1, X2, Y2);
                TB_L23Ref.Text = Ans.ToString();

                //A-C
                X1 = Convert.ToDouble(TB_Ax.Text);
                Y1 = Convert.ToDouble(TB_Ay.Text);
                X2 = Convert.ToDouble(TB_Cx.Text);
                Y2 = Convert.ToDouble(TB_Cy.Text);
                TB_L13.Text = Ugol(X1, Y1, X2, Y2).ToString();
                UgolRef(ref Ans, X1, Y1, X2, Y2);
                TB_L13Ref.Text = Ans.ToString();
            } catch
            {MessageBox.Show("Проверьте данные и попробуйте еще раз.", "Что то пошло не так при попытке расчета.",MessageBoxButtons.OK,MessageBoxIcon.Error);}
        }
        private void CreatePointA()
        {
            //point A
            LB_A_S.Location = new Point(Desc1.Location.X, Desc1.Location.Y+Desc1.Height + 20);
            LB_A_S.Width = 50;
            LB_A_S.Text = "Точка A(";
            Controls.Add(LB_A_S);

            TB_Ax.Size = new Size(55, 20);
            TB_Ax.Location = new Point(LB_A_S.Location.X + LB_A_S.Width + 1, LB_A_S.Location.Y - 3);
            Controls.Add(TB_Ax);

            TB_Ay.Size = new Size(55, 20);
            TB_Ay.Location = new Point(TB_Ax.Location.X + TB_Ax.Width + 5, LB_A_S.Location.Y - 3);
            Controls.Add(TB_Ay);

            LB_A_E.Location = new Point(TB_Ay.Location.X + TB_Ay.Width + 1, LB_A_S.Location.Y);
            LB_A_E.Text = ")";
            Controls.Add(LB_A_E);
        }

        private void CreatePointB()
        {
            //point B
            LB_B_S.Location = new Point(LB_A_E.Location.X + 100, LB_A_E.Location.Y);
            LB_B_S.Width = 50;
            LB_B_S.Text = "Точка B(";
            Controls.Add(LB_B_S);

            TB_Bx.Size = new Size(55, 20);
            TB_Bx.Location = new Point(LB_B_S.Location.X + LB_B_S.Width + 1, LB_B_S.Location.Y - 3);
            Controls.Add(TB_Bx);

            TB_By.Size = new Size(55, 20);
            TB_By.Location = new Point(TB_Bx.Location.X + TB_Bx.Width + 5, LB_B_S.Location.Y - 3);
            Controls.Add(TB_By);

            LB_B_E.Location = new Point(TB_By.Location.X + TB_By.Width + 1, LB_B_S.Location.Y);
            LB_B_E.Text = ")";
            Controls.Add(LB_B_E);
        }

        private void CreatePointC()
        {
            //point C
            LB_C_S.Location = new Point(LB_B_E.Location.X + 100, LB_B_E.Location.Y);
            LB_C_S.Width = 50;
            LB_C_S.Text = "Точка C(";
            Controls.Add(LB_C_S);

            TB_Cx.Size = new Size(55, 20);
            TB_Cx.Location = new Point(LB_C_S.Location.X + LB_C_S.Width + 1, LB_C_S.Location.Y - 3);
            Controls.Add(TB_Cx);

            TB_Cy.Size = new Size(55, 20);
            TB_Cy.Location = new Point(TB_Cx.Location.X + TB_Cx.Width + 5, LB_C_S.Location.Y - 3);
            Controls.Add(TB_Cy);

            LB_C_E.Location = new Point(TB_Cy.Location.X + TB_Cy.Width + 1, LB_C_S.Location.Y);
            LB_C_E.Text = ")";
            Controls.Add(LB_C_E);
        }

        private double Ugol (double X1, double Y1, double X2, double Y2)
        {
            if (X2 == 0 || Y2 == 0 || X1 == 0 || Y1 == 0) return 0;
            return (X1 * X2) + (Y1 * Y2) / (Math.Sqrt((X1 * X1) * (Y1 * Y1))) * (Math.Sqrt((X2 * X2) * (Y2 * Y2)));
        }

        void UgolRef (ref double Ans, double X1, double Y1, double X2, double Y2)
        {Ans = Ugol(X1, Y1, X2, Y2);}

        private void CreateAns()
        {
            Label LB_L12 = new Label();
                LB_L12.Location = new Point(Desc2.Location.X, Desc2.Location.Y + Desc2.Height + 20);
                LB_L12.Width = 70;
                LB_L12.Text = "Угол A-B";
                Controls.Add(LB_L12);

            TB_L12.Location = new Point(LB_L12.Location.X + LB_L12.Width+10, LB_L12.Location.Y-3);
            TB_L12.Enabled = false;
            Controls.Add(TB_L12);

            Label LB_L23 = new Label();
                LB_L23.Location = new Point(Desc2.Location.X, LB_L12.Location.Y + LB_L12.Height + 20);
                LB_L23.Width = 70;
                LB_L23.Text = "Угол B-C";
                Controls.Add(LB_L23);

            TB_L23.Location = new Point(LB_L23.Location.X + LB_L23.Width + 10, LB_L23.Location.Y-3);
            TB_L23.Enabled = false;
            Controls.Add(TB_L23);

            Label LB_L13 = new Label();
                LB_L13.Location = new Point(Desc2.Location.X, LB_L23.Location.Y + LB_L23.Height + 20);
                LB_L13.Width = 70;
                LB_L13.Text = "Угол A-C";
                Controls.Add(LB_L13);

            TB_L13.Location = new Point(LB_L13.Location.X + LB_L13.Width + 10, LB_L13.Location.Y-3);
            TB_L13.Enabled = false;
            Controls.Add(TB_L13);
        }

        private void CreateAnsRef()
        {
            Label LB_L12Ref = new Label();
            LB_L12Ref.Location = new Point(TB_L12.Location.X + TB_L12.Width + 40, Desc2.Location.Y + Desc2.Height + 20);
            LB_L12Ref.Width = 70;
            LB_L12Ref.Text = "Угол A-B";
            Controls.Add(LB_L12Ref);

            TB_L12Ref.Location = new Point(LB_L12Ref.Location.X + LB_L12Ref.Width + 10, LB_L12Ref.Location.Y - 3);
            TB_L12Ref.Enabled = false;
            Controls.Add(TB_L12Ref);

            Label LB_L23Ref = new Label();
            LB_L23Ref.Location = new Point(TB_L23.Location.X + TB_L23.Width + 40, LB_L12Ref.Location.Y + LB_L12Ref.Height + 20);
            LB_L23Ref.Width = 70;
            LB_L23Ref.Text = "Угол B-C";
            Controls.Add(LB_L23Ref);

            TB_L23Ref.Location = new Point(LB_L23Ref.Location.X + LB_L23Ref.Width + 10, LB_L23Ref.Location.Y - 3);
            TB_L23Ref.Enabled = false;
            Controls.Add(TB_L23Ref);

            Label LB_L13Ref = new Label();
            LB_L13Ref.Location = new Point(TB_L13.Location.X + TB_L13.Width + 40, LB_L23Ref.Location.Y + LB_L23Ref.Height + 20);
            LB_L13Ref.Width = 70;
            LB_L13Ref.Text = "Угол A-C";
            Controls.Add(LB_L13Ref);

            TB_L13Ref.Location = new Point(LB_L13Ref.Location.X + LB_L13Ref.Width + 10, LB_L13Ref.Location.Y - 3);
            TB_L13Ref.Enabled = false;
            Controls.Add(TB_L13Ref);
        }

        private void LB1_main_FormClosing(object sender, EventArgs e)
        {
            MainPage MP = new MainPage();
            MP.Show();
        }

        private void LB1_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
