using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Class
{
    public class Class1
    {   /// <summary>   
        /// Метод табулирующий значения функции на заданном интервале и возвращающая произведение положительных значений функции
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="h"></param>
        /// <param name="L"></param>
        /// <returns></returns>
        public void ResultProc(double b, double c, double m, double h, double n, ListBox L, TextBox t)
        {
            double max;
            double x = 0;
            max = Choose(m, b, c);
            double y = 0;
            L.Items.Clear();
            for (x = m; x <= n; x = x + h)
            {
                y = Choose(x, b, c);
                Vivod_list(x, y, L);
                if (y > max)
                { max = y;}
            }
            Vivod(max, t);
        }
        /// <summary>
        /// Расчет значения функции
        /// </summary>
        /// <param name="x"></param>
        /// <param name="b"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double Choose(double x, double b, double a)
        {
            double z = 0;
            if (x > 1)
            { z = x * Math.Sqrt(Math.Pow(b, 2) + Math.Pow(a, 2));}
            else if (x < 0)
            {
                double min = Math.Sqrt(b);
                double m2 = Math.Pow(x, 2);
                double m3 = x + a;
                if (m2 < min)
                { min = m2; }
                if (m3 < min)
                { min = m3;}
                z = min;
            } else {
                double m1 = Math.Log(b);
                double m2 = x + a;
                double max = m1;
                if (m2 > max)
                { max = m2;}
                z = max;
            } return z;
        }
        /// <summary>
        /// Метод ввода данных
        /// </summary>
        /// <param name="x"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public double Vvod(TextBox t)
        {
            double x = Convert.ToDouble(t.Text);
            return x;
        }

        /// <summary>
        /// Метод вывода данных
        /// </summary>
        /// <param name="x"></param>
        /// <param name="t"></param>
        public void Vivod(double x, TextBox t)
        {  t.Text = Convert.ToString(x); }
        /// <summary>
        /// Метод вывод табуляции
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="L"></param>
        public void Vivod_list(double x, double y, ListBox L)
        {L.Items.Add(x.ToString("F2") + "\t" + y.ToString("F3"));}
}
}
