using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using ADOX;


namespace ClassLibrary9
{
    public class Laba9
    {
        /// <summary>
        /// Генерация массива случаных чисел
        /// </summary>
        public static void enter_mas(double[] masPtz, int n)
        {
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            { masPtz[i] = rnd.Next(-20, 20); }
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
                Width += grid.Columns[s].Width + 1;
            }
            if (Width > 1200)
            {
                grid.Width = 1200;
            }
            else
            {
                grid.Width = Width;
            }
        }
        /// <summary>
        /// Удаление выброного элемента массива
        /// </summary>
        public static void ElDel(double[] masPtr, int k, DataGridView grid)
        {

            // Заполнение массиваin
            for (int i = 0; i < grid.ColumnCount; i++)
            {
                masPtr[i] = System.Convert.ToDouble(grid.Rows[1].Cells[i].Value);
            }
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
        public static void out_ElDel(double[] masPtr, DataGridView grid)
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
        public static double sum_mas(double[] masPtz, int n)
        {
            double s = 0;
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
        /// <summary>
        /// Создание Базы данных
        /// </summary>
        public static void add()
        {

            try
            {
                ADOX.Catalog k = new ADOX.Catalog();

                k.Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");

                MessageBox.Show("БД Создана");

            }
            catch (System.Runtime.InteropServices.COMException sit)
            {
                MessageBox.Show(sit.Message);
            }
        }
        /// <summary>
        /// Создание структуры Базы данных
        /// </summary>
        public static void add_struct()
        {
            try
            {

                dynamic p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");
                p.Open();

                dynamic c = new OleDbCommand("CREATE TABLE [MASSIVS] ([Номер Элемента]  char(200),[Исходный массив] char(200), [Результирующий массив] char(200), [Обработанный массив] char(200))", p);
                c.ExecuteNonQuery();

                MessageBox.Show("Структура БД записана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
                p.Close();

            }

            catch (System.Runtime.InteropServices.COMException sit)
            {

                MessageBox.Show(sit.Message);

            }
        }
        /// <summary>
        /// Заполнение Базы данных
        /// </summary>
        public static void add_zap(double[] arr, double[] resmas1, double[] resmas2, int len, int j)
        {
            int ii = -1;
            for (int i = 0; i < len; i++)
            {
                dynamic p = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");
                p.Open();
                if (i < j)
                {
                    if (i < j - 1)
                    {
                        ii++;
                        dynamic c = new OleDbCommand("INSERT INTO [MASSIVS](" + " [Номер Элемента],[Исходный массив], [Результирующий массив], [Обработанный массив]) VALUES('" + i + "','" + arr[i] + "','" + resmas1[i] + "','" + resmas2[ii] + "')");
                        c.Connection = p;
                        c.ExecuteNonQuery();
                    }
                    else
                    {
                        dynamic c = new OleDbCommand("INSERT INTO [MASSIVS](" + " [Номер Элемента],[Исходный массив], [Результирующий массив], [Обработанный массив]) VALUES('" + i + "','" + arr[i] + "','" + resmas1[i] + "','" + " " + "')");
                        c.Connection = p;
                        c.ExecuteNonQuery();
                    }


                }
                else
                {
                    dynamic c = new OleDbCommand("INSERT INTO [MASSIVS](" + " [Номер Элемента],[Исходный массив]) VALUES('" + i + "','" + arr[i] + "')");
                    c.Connection = p;
                    c.ExecuteNonQuery();
                    p.Close();
                }

            }
            MessageBox.Show("В таблицу внесены данные", "Информация", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        public static void CopyArray(double[] arr, double[] arr1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i];
            }
        }
    }
}
    

