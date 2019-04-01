using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
            DrawGraph1();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 0;
            DrawGraph2();
        }

        private void DrawGraph1()
        {
            GraphPane pane = zedGraphControl1.GraphPane;
            pane.CurveList.Clear();

            PointPairList list = new PointPairList();
            double x = 0;
            double y = 0;
            for (int n = 1; n < listBox1.Items.Count; n++)
            {
                listBox1.SelectedIndex = n;
                listBox2.SelectedIndex = n;
                x = Convert.ToDouble(listBox1.SelectedItem.ToString());
                y = Convert.ToDouble(listBox2.SelectedItem.ToString());
                list.Add(x, y);
            }

            LineItem myCurve = pane.AddCurve("Func", list, Color.Blue, SymbolType.None);

            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();// Refresh
        }
        private void DrawGraph2()
        {
            GraphPane pane1 = zedGraphControl1.GraphPane;
            PointPairList list2 = new PointPairList();
            double x = 0;
            double y = 0;
            for (int n = 1; n < listBox1.Items.Count; n++)
            {
                listBox1.SelectedIndex = n;
                listBox2.SelectedIndex = n;
                x = Convert.ToDouble(listBox1.SelectedItem.ToString());
                y = Convert.ToDouble(listBox2.SelectedItem.ToString());
                list2.Add(x, y);
            }
            // Add a smoothed curve
            LineItem curve = pane1.AddCurve("Approx 5x", list2, Color.Red, SymbolType.Diamond);
            curve.Symbol.Fill = new Fill(Color.White);
            curve.Symbol.Size = 5;
            // activate the cardinal spline smoothing
            curve.Line.IsSmooth = true;
            curve.Line.SmoothTension = 0.5F;
            zedGraphControl1.AxisChange();

            zedGraphControl1.Invalidate();// Refresh
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zedGraphControl1.Visible = true;
        }
    }
}
