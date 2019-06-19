using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace Class3Library
{
    public class Class1
    {
        static public void Vivod(double x, TextBox t)
        { t.Text = Convert.ToString(x); }

        static public int rating(int n)
        {
            int rat = ((n + 1) / 3 + 2);
            return rat;
        }

        static public void Viv(double x, string t, Chart c)
        { c.Series[t].Points.AddY(x); }
    }
}
