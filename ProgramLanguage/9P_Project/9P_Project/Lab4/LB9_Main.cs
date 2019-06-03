using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using ClassLibrary9;

namespace _9P_Project
{
    public partial class LB9_Main : Form
    {
        public LB9_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {{try{      // Создание первого массива
                    String g = Interaction.InputBox("Введите количество элементов массива = ", "Введите значение", "", -1, -1);
                    int n = Convert.ToInt16(g);
                    double[] masPtr = new double[n];
                    // Заполнение и вывод первого массива
                    Laba9.enter_mas(masPtr, n);
                    Laba9.output_mas(masPtr, n, dataGridView1);
                    // Подсчет суммы элементов, имеющих четный индекс
                    double Sum = Laba9.sum_mas(masPtr, n);
                    Laba9.vivod_Label(Sum, label1);
                    // Подсчет длинны второго массива
                    int k = 0;
                    k = Laba9.set_count(masPtr, n, Sum, k);
                    // Создание второго массива
                    double[] rezmasPtr = new double[100];
                    // Заполнение и вывод второго массива
                    rezmasPtr = Laba9.set_mas(masPtr, rezmasPtr, n, Sum);
                    Laba9.output_mas(rezmasPtr, k, dataGridView2);
                    // Заполнение третего массива для его обработки
                    double[] testarr = rezmasPtr;
                    Laba9.output_mas(testarr, k, dataGridView3);
                    // Выборка нужного элемента и его удаление
                    String gg = Interaction.InputBox("Введите номер элемента для его удаления = ", " Введите значение ", "", -1, -1);
                    int kk = Convert.ToInt16(gg);
                    double[] rezmasPtr2 = new double[dataGridView2.ColumnCount];
                    Laba9.ElDel(rezmasPtr2, kk, dataGridView3);
                    Laba9.out_ElDel(rezmasPtr2, dataGridView3);
                    // Заполнение Базы данных
                    Laba9.add();
                    Laba9.add_struct();
                    Laba9.add_zap(masPtr, rezmasPtr, rezmasPtr2, n, k);
                    // Очистка памяти
                    rezmasPtr = null;
                    rezmasPtr2 = null;
                    masPtr = null;
                }catch (Exception Ex) { MessageBox.Show("Error: " + Ex.ToString(), "Warning!"); }
            }
        }
    }
}
