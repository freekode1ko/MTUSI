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

        public MainForm()
        {
            InitializeComponent();
        }
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
            } catch (Exception EX) { MessageBox.Show(EX.ToString()); };
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
            this.Height = 575;
            this.Width = 850;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
