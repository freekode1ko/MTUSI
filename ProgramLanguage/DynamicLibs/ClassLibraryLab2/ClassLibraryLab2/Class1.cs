using System;
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
                if (Math.Sqrt(B) < X * X)
                {
                    LocalPEr = Math.Sqrt(B);
                    if (LocalPEr < X + C)
                        return LocalPEr;
                }else { LocalPEr = X * X;
                    if (LocalPEr < X + C)
                        return LocalPEr;
                }
            }
            if (Math.Log(B) > X + C)
                return Math.Log(B);
            else return X + C;
        }

        /// <summary>
        /// Вывод ответа в ListBox
        /// </summary>
        public static void Viv(ListBox L, double x)
        {L.Items.Add(x);}

        /// <summary>
        /// Вывод ответа в TextBox
        /// </summary>
        public static void Viv2(TextBox T, double x)
        { T.Text = x.ToString(); }
    }
}
