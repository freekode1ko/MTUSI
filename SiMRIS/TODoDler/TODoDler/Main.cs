using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Net;
using System.Text.RegularExpressions;

namespace TODoDler
{
    public partial class MainForm : Form
    {
        //Global var
        string MessBodyText = ""; //notification msg 
        string MessTitleText = "";//msg. project name
        string DATATIME = ""; //deadline timer(date)
        string JsonPath = Directory.GetCurrentDirectory().ToString()+ @"\Package.json"; //create json path
        string ConnectStr = "server=localhost;user=root;database=somesortoftestbd;"; // connect to db

        string NN = "User";
        string PP = "User";
        string NT = "";
        string NTD = "";


        public MainForm()
        {
            InitializeComponent();
        }
        /// <SendingNew>  
        public class SendDead
        {
            public string toUser { get; set; }
            public string text { get; set; }
            public string toDate { get; set; }
        }
        private SendDead SendNewNotif()
        {
            var sendDead = new SendDead
            {
                toUser = NN,
                text = NT,
                toDate = NTD
            };
            return sendDead; 
        }
        /// </SendingNew>
        /// <getListOfNotif>
        public class Deadline2
        {
            public string name { get; set; }
            public string password { get; set; }
        }
        private Deadline2 GetDeadline2() //Test json package
        {
            var deadline2 = new Deadline2
            {
                name = NN,
                password = PP
            };
            return deadline2;
        }
        /// </getListOfNotif>

        public class Deadline
        {
            public string EndDate { get; set; }
            public string ProjectName { get; set; }
            public string Note { get; set; }
        }
        private Deadline GetDeadline() //Test json package
        {
            var deadline = new Deadline
            {
                ProjectName = "IDK",
                Note = "I think this ist working",
                EndDate = "66.99.6969"
            };
            return deadline;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
            try
            {
                /*
                CreateJsonFile();//create json
                MessageBox.Show("First done");
                ReadJsonFile();//read json, 
                MessageBox.Show("Second done");
                AddDeadToDB();//write to db
                MessageBox.Show("Third done");
                GETnotiff();//get notification
                MessageBox.Show("Fourth done");
                //SendToServ();//send to Sever
                //MessageBox.Show("Fifth done");
                */
                testc();
            } catch (Exception EX) { MessageBox.Show(EX.ToString()); };
        }
        private void testc()
        {
            string Ans = "";
            try
            {

                var deadline = GetDeadline2();
                var jsonToWrite = JsonConvert.SerializeObject(deadline, Formatting.Indented);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.225:8000/descpath/login/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonToWrite);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd(); Ans = result.ToString();
                    if (Ans == "{}") {}
                    else 
                    {
                        Match match1 = Regex.Match(Ans, @"\u0022text\u0022: \u0022.*?(\w.*)\s*\u0022,", RegexOptions.Singleline);
                        string result1 = match1.Success ? match1.Groups[1].Value : "Не найдено";

                        Match match2 = Regex.Match(Ans, @"\u0022todatee\u0022: \u0022.*?(\w.*)\s*\u0022}", RegexOptions.Singleline);
                        string result2 = match2.Success ? match2.Groups[1].Value : "Не найдено";

                        dataGridView1.Rows.Add(result1, result2);
                    }
                }
            }

            catch (Exception Ex)
            {
                //dataGridView1.Rows.Add(Ex.ToString());
                //MessageBox.Show("WOW!: " + Ex.ToString());
            }
        }
        private void GETnotiff()
        {
            PopupNotifier poop = new PopupNotifier();
            //poop.Image = //Properties.Resources.pepega;
            poop.TitleText = MessTitleText;
            poop.ContentText = MessBodyText;
            poop.Popup();
        }
        private void SendToServ()
        {
            try
            {
                var deadline = GetDeadline();
                var jsonToWrite = JsonConvert.SerializeObject(deadline, Formatting.Indented);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://127.0.0.1:5000/views/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(jsonToWrite);
                        streamWriter.Flush();
                        streamWriter.Close();
                    }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {var result = streamReader.ReadToEnd();}
            }catch (Exception ex){ /*MessageBox.Show("Error: " + ex);*/ }
        }
        private void ReadJsonFile()
        {

            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(JsonPath))
                { jsonFromFile = reader.ReadToEnd(); }
                //richTextBox1.Text = jsonFromFile;
                var customerFromJson = JsonConvert.DeserializeObject<Deadline>(jsonFromFile);

                var details = JObject.Parse(jsonFromFile);

                MessTitleText = string.Concat(details["ProjectName"], "");
                MessBodyText = string.Concat(details["Note"], "");
                DATATIME = string.Concat(details["EndDate"], "");

            }
            catch (Exception ex)
            {MessageBox.Show("Error: " + ex);}
           
        }
        private void AddDeadToDB()
        {
            try { 
            MySqlConnection conn = new MySqlConnection(ConnectStr);
            conn.Open();
            string Sql = "INSERT INTO deds VALUES('', '" + MessTitleText + "', '" + MessBodyText + "', '" + DATATIME + "')";
            MessageBox.Show(Sql);
            MySqlCommand CommandSQL = new MySqlCommand(Sql, conn);
            string GetProjectName = CommandSQL.ExecuteScalar().ToString();
            conn.Close();
            }
            catch (Exception EX) { /* MessageBox.Show(EX.ToString()); */}
        }
        private void CreateJsonFile()
        {
            try
            {
                var deadline = GetDeadline();
                var jsonToWrite = JsonConvert.SerializeObject(deadline, Formatting.Indented);
                using (var writer = new StreamWriter(JsonPath))
                { writer.Write(jsonToWrite); }

            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex); }
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                NT = richTextBox1.Text;
                NTD = textBox1.Text;
                var deadlines = SendNewNotif();
                var jsonToWrite = JsonConvert.SerializeObject(deadlines, Formatting.Indented);
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://192.168.1.225:8000/descpath/nm/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(jsonToWrite);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd(); MessageBox.Show(result.ToString());
                    if (result.ToString() == "1")
                    {
                        testc();
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("WOW!: " + Ex.ToString());
            }
}
    }
}
