using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary6Sharp
{
    public class Class1
    {
        /// <summary>
        /// Генерация массива случаных чисел
        /// </summary>
        public static void enter_mas(double[] masPtz, int n)
        {

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            { masPtz[i] = rnd.Next(-20,20); }
        }
        /// <summary>
        /// Вывод массива в DataGridView
        /// </summary>
        public static void output_mas(double[] aPtz, int len, DataGridView grid)
        {
            grid.ColumnCount = len;
            grid.RowCount = 2;
            for (int i = 0; i < len; i++)
            {
                grid.Rows[0].Cells[i].Value = "[" + i + "]";
                grid.Rows[1].Cells[i].Value = aPtz[i];
            }
            int Width = 0;
            for (int s = 0; s < grid.ColumnCount; s++)
            {
                Width += grid.Columns[s].Width + 10;
            }
            if (Width > 660)
            {
                grid.Width = 601;
            }
            else
            {
                grid.Width = Width;
            }
        }
        /// <summary>
        /// Удаление выброного элемента массива
        /// </summary>
        public static void aaa(double[] masPtr, int k, DataGridView grid)
        {

            // Заполнение массиваin
            for (int i = 0; i < grid.ColumnCount; i++)
            { masPtr[i] = Convert.ToDouble(grid.Rows[1].Cells[i].Value); }
            // Удаление выброного элемента массива
            int len = grid.ColumnCount;
            for (int ix = k; ix < len - 1; ix++)
            {
                grid.Rows[0].Cells[ix].Value = grid.Rows[0].Cells[ix + 1].Value;
                masPtr[ix] = masPtr[ix + 1];
            }

        }
        /// <summary>
        /// Вывод рузультирующего массива после удаления элемента
        /// </summary>
        public static void out_aaa(double[] masPtr, DataGridView grid)
        {
            int len = grid.ColumnCount;
            len--;
            // Заполнение и вывод массива
            for (int i = 0; i < len; i++)
            {
                grid.Rows[1].Cells[i].Value = masPtr[i];
                grid.ColumnCount = len;
            }
        }
        /// <summary>
        /// Подсчет суммы элементов, имеющих четный индекс
        /// </summary>
        public static double sum_mas(double[] masPtz, int n, double s)
        {
            s = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    s = s + masPtz[i];
                }

            }
            return s;
        }
        /// <summary>
        /// Подсчет количества элементов, меньше заданного числа
        /// </summary>
        public static int set_count(double[] masPtz, int n, double s, int k)
        {
            for (int i = 0; i < n; i++)
            {
                if (masPtz[i] < s)
                {
                    k++;
                }
            }
            return k;
        }
        /// <summary>
        /// Подсчет количества элементов, меньше заданного числа
        /// </summary>
        public static double[] set_mas(double[] masPtz, double[] rezmasPtz, int n, double s)
        {
            int j = 0;
            for (int i = 0; i < n; i++)
            {

                if (masPtz[i] < s)
                {
                    rezmasPtz[j] = masPtz[i];
                    j++;
                }
            }
            return rezmasPtz;
        }
        /// <summary>
        /// Вывод в Label числа типа double 
        /// </summary>
        public static void vivod_Label(double z, Label t)
        {
            t.Text = "Сумма чисел, имеющие четные индексы в массиве = " + z.ToString();
        }
    }
}
