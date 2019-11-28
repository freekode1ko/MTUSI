using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Lab3
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        class ClassCounter 
        {
            public delegate void MethodContainer();
            public event MethodContainer onCount;
            public void sb()
            {
                File.Delete(Directory.GetCurrentDirectory()+@"\Task3.txt");
                for (int i = 0; ; i++)
                {
                    File.AppendAllText(Directory.GetCurrentDirectory() + @"\Task3.txt", "String\n");
                    Thread.Sleep(50);
                    if (i == 10)
                    {
                        onCount();
                        i = 0;
                    }
                }
            }
        }
        class Handler_I 
        {
            public void Message()
            {
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\Task3.txt", "LOG FROM FIRST\n");
            }
        }
        class Handler_T
        {
            public void Message()
            {
                File.AppendAllText(Directory.GetCurrentDirectory() + @"\Task3.txt", "LOG FROM SECOND\n");

            }
        }
        static object locker = new object();

        static void WriteInFile(string text)
        {
            lock (locker)
            {
                if (!File.Exists(Directory.GetCurrentDirectory() + @"\Task1.txt"))
                    File.Create(Directory.GetCurrentDirectory()+ @"\Task1.txt");
                else
                    File.AppendAllText(Directory.GetCurrentDirectory()+ @"\Task1.txt", text);
            }
        }
        static void WriteInFile1()
        {
            int i=0;
            lock (locker)
            {
                for (i = 0; i < 5; i++)
                {
                    WriteInFile("First ");
                }
            }
            i = 0;
        }
        static void WriteInFile2()
        {
            
            int i=0;
            lock (locker) 
            { 
                for (i=0;i<5;i++)
                {
                     WriteInFile("Second ");
                }
            }
            i = 0;
            
        }
        static void Terminate()
        {
            for (; ; Thread.Sleep(2000))
            {
                lock (locker)
                {
                    if (File.Exists(Directory.GetCurrentDirectory()+ @"\Task3.txt"))
                    {
                        File.Delete(Directory.GetCurrentDirectory() + @"\Task3.txt");
                    }
                }
            }
        }
        bool existed;

        private void TB_Task1_Click(object sender, EventArgs e)
        {
            Thread write1 = new Thread(WriteInFile1);
            write1.IsBackground = true;
            Thread write2 = new Thread(WriteInFile2);
            write2.IsBackground = true;
            Thread Read = new Thread(Terminate);
            Read.IsBackground = true;
            write1.Start();
            write2.Start();
            Read.Start();
            MessageBox.Show("Close this meessage to proceed");
            write1.Abort();
            write2.Abort();
            Read.Abort();
        }

        private void TB_Task2_Click(object sender, EventArgs e)
        {
            Mutex mutexObj = new Mutex(true, "guid", out existed);
            if (existed)
            {
                MessageBox.Show("Application works in a single copy, Close this message to proceed");
            }
            else
            {
                MessageBox.Show("Application has already been launched, now it will be closed.");
                Thread.Sleep(3000);
                this.Close();
            }
        }

        private void TB_Task3_Click(object sender, EventArgs e)
        {
            ClassCounter Counter = new ClassCounter();
            Thread sob = new Thread(Counter.sb);
            sob.Start();

            bool Exists;
            Mutex mO = new Mutex(true, "guidr", out Exists);
            if (Exists)
            {
                Handler_I Handler1 = new Handler_I();
                Counter.onCount += Handler1.Message;
            }
            else
            {
                Handler_T Handler2 = new Handler_T();
                Counter.onCount += Handler2.Message;
            }
            MessageBox.Show("Close this meessage to proceed");
            sob.Abort();
        }
    }
}
