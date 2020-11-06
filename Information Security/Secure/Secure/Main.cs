using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using Microsoft.TeamFoundation.Common;
using System.Net;
using System.IO;


namespace Secure
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void BTN_EthernetStatus_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Проверка соединения с интернетом");
            if(EthrConnection() == true)
            {
                LSB_LOG.Items.Add("Доступ к интернету есть");
                LB_EthernetStatus.ForeColor = Color.FromArgb(0, 255, 0);
                LB_EthernetStatus.Text = "Доступ к интернету есть";
            }
            else
            {
                LSB_LOG.Items.Add("Доступ к интернету отсутствует");
                LB_EthernetStatus.ForeColor = Color.FromArgb(255, 0, 0);
                LB_EthernetStatus.Text = "Доступ к интернету отсутствует";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Проверка соединения с интернетом");
        }

        private void BTN_FirewallStatus_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Проверка МЭ");
            if (FireWallEbbl() == true)
            {
                LSB_LOG.Items.Add("МЭ подключен");
                LB_FirewallStatus.ForeColor = Color.FromArgb(0, 255, 0);
                LB_FirewallStatus.Text = "МЭ подключен";
            }
            else
            {
                LSB_LOG.Items.Add("МЭ выключен");
                LB_FirewallStatus.ForeColor = Color.FromArgb(255, 0, 0);
                LB_FirewallStatus.Text = "МЭ выключен";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Проверка МЭ");
        }

        private void BTN_FirewallWork_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Проверка корректности МЭ");
            if (FirewWallWork() == true)
            {
                LSB_LOG.Items.Add("МЭ работает корректно");
                LB_FirewallWork.ForeColor = Color.FromArgb(0, 255, 0);
                LB_FirewallWork.Text = "МЭ работает корректно";
            }
            else
            {
                LSB_LOG.Items.Add("МЭ работает не корректно");
                LB_FirewallWork.ForeColor = Color.FromArgb(255, 0, 0);
                LB_FirewallWork.Text = "МЭ работает не корректно";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Проверка корректности МЭ");
        }
        private void BTN_AntivirusStatus_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Проверка наличия антивируса");
            if (AntivirusInstl() == true)
            {
                LSB_LOG.Items.Add("Антивирус установлен");
                LB_AntivirusStatus.ForeColor = Color.FromArgb(0, 255, 0);
                LB_AntivirusStatus.Text = "Антивирус установлен";
            }
            else
            {
                LSB_LOG.Items.Add("Антивирус не установлен");
                LB_AntivirusStatus.ForeColor = Color.FromArgb(255, 0, 0);
                LB_AntivirusStatus.Text = "Антивирус не установлен";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Проверка наличия антивируса");
        }

        private void BNT_AntivirusWork_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Проверка корректности работы антивируса");
            if (AntivirusWork() == true)
            {
                LSB_LOG.Items.Add("Антивирус работает корректно");
                LB_AntivirusWork.ForeColor = Color.FromArgb(0, 255, 0);
                LB_AntivirusWork.Text = "Антивирус работает корректно";
            }
            else
            {
                LSB_LOG.Items.Add("Антивирус работает не корректно");
                LB_AntivirusWork.ForeColor = Color.FromArgb(255, 0, 0);
                LB_AntivirusWork.Text = "Антивирус работает не корректно";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Проверка корректности работы антивируса");
        }

        private void BTN_AntivirusTest_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: Тестирование работы антивируса");
            if (AntivirusTest() == true)
            {
                LSB_LOG.Items.Add("Антивирус работает корректно");
                LB_AntivirusTest.ForeColor = Color.FromArgb(0, 255, 0);
                LB_AntivirusTest.Text = "Антивирус работает корректно";
            }
            else
            {
                LSB_LOG.Items.Add("Антивирус работает не корректно");
                LB_AntivirusTest.ForeColor = Color.FromArgb(255, 0, 0);
                LB_AntivirusTest.Text = "Антивирус работает не корректно";
            }
            LSB_LOG.Items.Add("КОНЕЦ: Тестирование работы антивируса");
        }
        private Boolean EthrConnection()
        {
            string HOST = "www.google.com";
            Ping ping = new Ping();
            try
            {
                PingReply reply = ping.Send(HOST, 3000);
                if (reply.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception EX)
            { LSB_LOG.Items.Add("Error while check enternet connections: " + EX); }
            return false;
        }

        private Boolean FireWallEbbl()
        {
            Type NetFwMgrType = Type.GetTypeFromProgID("HNetCfg.FwMgr", false);
            INetFwMgr mgr = (INetFwMgr)Activator.CreateInstance(NetFwMgrType);
            return mgr.LocalPolicy.CurrentProfile.FirewallEnabled;
        }

        private Boolean FirewWallWork()
        {
            WebClient client = new WebClient();
            try
            {
                String responde = client.DownloadString(address: "http://www.google.com");
                return false;
            }
            catch { return true; }
        }

        private Boolean AntivirusInstl()
        {
            try
            {
                string wmipathstr = @"\\" + Environment.MachineName + @"\root\SecurityCenter2";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmipathstr, "SELECT * FROM AntivirusProduct");
                ManagementObjectCollection instances = searcher.Get();
                return instances.Count > 0;
            }
            catch(Exception Ex)
            {
                LSB_LOG.Items.Add("Error while check antivirus installation: " + Ex);
                return false;
            }
        }

        private Boolean AntivirusWork()
        {
            var runningProcs = from proc in Process.GetProcesses(".") orderby proc.Id select proc;
            return runningProcs.Count(p => p.ProcessName.Contains("MsMpEng")) > 0;
        }

        private Boolean AntivirusTest()
        {
            StreamWriter fs = new StreamWriter("test.txt");
            int i = 92;
            fs.WriteLine("X5O!P%@AP[4" + (char)i + "PZX54(P^)7CC)7}$EICAR-STANDARD-ANTIVIRUS-TEST-FILE!$H+H*");
            fs.Close();
            return !File.Exists("\\test.txt");
        }

        private void runAllTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LSB_LOG.Items.Add("СТАРТ: MASS TEST");
            try
            {
                BTN_EthernetStatus_Click(sender, e);
                BTN_FirewallStatus_Click(sender, e);
                BTN_FirewallWork_Click(sender, e);
                BTN_AntivirusStatus_Click(sender, e);
                BNT_AntivirusWork_Click(sender, e);
                BTN_AntivirusTest_Click(sender, e);
            }
            catch(Exception Ex) {LSB_LOG.Items.Add("ERROR while run mass test: "+ Ex);}

            LSB_LOG.Items.Add("КОНЕЦ: MASS TEST");
        }

        private void saveLogToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter fs = new StreamWriter("LOG.txt");
            for (int i = 0; i < LSB_LOG.Items.Count; i++)
                fs.WriteLine(LSB_LOG.Items[i]);
            fs.Close();
        }
    }
}
