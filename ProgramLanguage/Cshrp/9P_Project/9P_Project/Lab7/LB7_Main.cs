using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary6Sharp;
using Microsoft.VisualBasic;

namespace _9P_Project
{
    public partial class LB7_Main : Form
    {
        public LB7_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    // Создание первого массива
                    String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1, -1); 
                    int n = Convert.ToInt16(g);
                    double[] masPtz = new double[n];
                    // Заполнение и вывод первого массива
                    Class1.enter_mas(masPtz, n);
                    Class1.output_mas(masPtz, n, dataGridView1);
                    // Подсечыт суммы элементов, имеющих четный индекс
                    double Sum = 0;
                    Sum = Class1.sum_mas(masPtz, n, Sum);
                    Class1.vivod_Label(Sum, label1);
                    // Подсчет длинны второго массива
                    int k = 0;
                    k=Class1.set_count(masPtz, n, Sum, k);
                    // Создание второго массива
                    double[] rezmasPtz = new double[k];
                    // Заполнение и вывод второго массива
                    rezmasPtz=Class1.set_mas(masPtz, rezmasPtz, n, Sum);
                    Class1.output_mas(rezmasPtz, k, dataGridView2);
                    // Очистка памяти
                    rezmasPtz = null;
                    masPtz = null;
                }
                catch (Exception ex) { MessageBox.Show("error: " + ex.ToString()); }
            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Получение № элемента на удаление
                    String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1, -1);
                    int k = Convert.ToInt16(g);
                    //Создание нового массива
                    double[] masPtz = new double[dataGridView2.ColumnCount];
                    //Удаление выброного элемента из массива и вывод результирущего массива
                    Class1.aaa(masPtz, k, dataGridView2);
                    Class1.out_aaa(masPtz, dataGridView2);
                    //Очистка памяти
                    masPtz = null;
                }
                catch (Exception ex){ MessageBox.Show("error: "+ ex.ToString()); }
                }

            }
        }
}
