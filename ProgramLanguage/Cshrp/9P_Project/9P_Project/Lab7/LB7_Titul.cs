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
    public partial class LB7_Titul : Form
    {
        public LB7_Titul()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LB7_Main lb1 = new LB7_Main();
            lb1.Show();
        }
    }
}
