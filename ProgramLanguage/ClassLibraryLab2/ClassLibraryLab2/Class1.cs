﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab2
{
    /// <summary>
    /// Набор методов по решению системы и выводу её ответа
    /// </summary>
    public class Class1
    {
        /// <summary>
        /// Метод решения системы уравнения
        /// </summary>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="X"></param>
        /// <returns></returns>
        public static double Ans(double B, double C, double X)
        {
            double LocalPEr;
            if (X > 1)
            { return X * (Math.Sqrt(B * B + C * C)); }
            if (X < 0)
            {
                //LocalPEr = Math.Min(Math.Sqrt(B), X * X);
                // return Math.Min(LocalPEr, X + C);
                if (Math.Sqrt(B) < X * X)
                {
                    LocalPEr = Math.Sqrt(B);
                    if (LocalPEr < X + C)
                        return LocalPEr;
                }else { LocalPEr = X * X;
                    if (LocalPEr < X + C)
                        return LocalPEr;
                }
               // LocalPEr = minn(Math.Sqrt(B), X * X);
               //  return minn(LocalPEr, X + C);
            }
            //return Math.Max(Math.Log(B), X + C);
            return maxx(Math.Log(B), X + C);
        }

        //Методы для вычисления максимума и минимума
        static double maxx(double x, double y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
        static double minn(double x, double y)
        {
            if (x < y)
                return x;
            else
                return y;
        }
        /// <summary>
        /// Вывод ответа
        /// </summary>
        public static void Viv(ListBox L, double x)
        {
            L.Items.Add(x);
        }
    }
}
