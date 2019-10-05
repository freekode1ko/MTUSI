using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TODoDler
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BT_Enter_Click(object sender, EventArgs e)
        {
            string ConnectStr = "server=localhost;user=root;database=somesortoftestbd;"; // connect to db
                try
                {

                MySqlConnection conn = new MySqlConnection(ConnectStr);
                    conn.Open();
                    string Sql = "SELECT UserName,UserPassword FROM `users` WHERE UserName = '" + TB_Login.Text+"' AND UserPassword = '"+TB_Pass.Text+"'";
                    MySqlCommand CommandSQL = new MySqlCommand(Sql, conn);
                    MySqlDataReader UserNamePass = CommandSQL.ExecuteReader();
               
                List<string[]> userData = new List<string[]>();
                while (UserNamePass.Read())
                {
                    userData.Add(new string[2]);
                    userData[userData.Count - 1][0] = UserNamePass[0].ToString();
                    userData[userData.Count - 1][1] = UserNamePass[1].ToString();
                }
                UserNamePass.Close();
                conn.Close();
                string UserName="", UserPassword="";

                foreach (string[] s in userData)
                {
                    UserName = s[0];
                    UserPassword = s[1];
                }
                if (UserName == TB_Login.Text && UserPassword == TB_Pass.Text)
                {
                    this.Hide();
                    MainForm Main = new MainForm();
                    Main.Show();
                }
                else { MessageBox.Show("Wrong Login or Password"); }
            }
                catch (Exception EX) {  MessageBox.Show(EX.ToString()); }
        }

        private void BT_Reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration Reg = new Registration();
            Reg.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
