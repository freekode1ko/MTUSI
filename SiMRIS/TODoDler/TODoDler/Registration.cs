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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        string ConnectStr = "server=localhost;user=root;database=somesortoftestbd;"; // connect to db
        private void TB_Reg_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(ConnectStr);
                conn.Open();
                string Sql = "INSERT INTO users VALUES('', '" + TB_Login.Text + "', '" + TB_Pass.Text + "', '0')";
                if (TB_Login.Text == "" || TB_Pass.Text == "")
                    MessageBox.Show("Field must be filled");
                else 
                { 
                MySqlCommand CommandSQL = new MySqlCommand(Sql, conn);
                string GetProjectName = CommandSQL.ExecuteScalar().ToString();
                conn.Close();
                }
            }
            catch (Exception EX) { /* MessageBox.Show(EX.ToString()); */}
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login Log = new Login();
            Log.Show();
        }
    }
}
