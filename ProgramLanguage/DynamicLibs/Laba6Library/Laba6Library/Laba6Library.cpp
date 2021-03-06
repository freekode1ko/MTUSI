#include "stdafx.h"

#include "Laba6Library.h"

using namespace System::Windows::Forms;
using namespace Microsoft::VisualBasic;
#include <time.h>
#include <cstdlib>

namespace Laba6Library {
	/// <summary>
	/// Генерация массива случаных чисел
	/// </summary>
	void Lab6::enter_mas(double *masPtz, int n) {

		srand(time(NULL));

		for (int i = 0; i < n; i++) 
		{masPtz[i] = (double)(rand() % 900) / 20 - 20;}
	}
	/// <summary>
	/// Вывод массива в DataGridView
	/// </summary>
	void Lab6::output_mas(double *aPtz, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = aPtz[i];
		}
		int Width = 0;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width+10;
		}
		if (Width > 660) {
			grid->Width = 601;
		}
		else {
			grid->Width = Width;
		}
	}
	/// <summary>
	/// Удаление выброного элемента массива
	/// </summary>
	void Lab6::aaa(double *masPtr, int k, DataGridView^ grid)
	{
	
			// Заполнение массиваin
			for (int i = 0; i < grid->ColumnCount; i++)
			{masPtr[i] = System::Convert::ToDouble(grid->Rows[1]->Cells[i]->Value);}
			// Удаление выброного элемента массива
			int len = grid->ColumnCount;
			for (int ix = k; ix < len - 1; ix++)
			{
				grid->Rows[0]->Cells[ix]->Value = grid->Rows[0]->Cells[ix + 1]->Value;
				masPtr[ix] = masPtr[ix + 1];
			}
			
	}
	/// <summary>
	/// Вывод рузультирующего массива после удаления элемента
	/// </summary>
	void Lab6::out_aaa(double *masPtr, DataGridView^ grid)
	{
		int len = grid->ColumnCount;
		len--;
		// Заполнение и вывод массива
		for (int i = 0; i < len; i++)
		{
			grid->Rows[1]->Cells[i]->Value = masPtr[i];
			grid->ColumnCount = len;
		}
	}
	/// <summary>
	/// Подсчет суммы элементов, имеющих четный индекс
	/// </summary>
	void Lab6::sum_mas(double *masPtz, int n, double & s) {
		s = 0;
		for (int i = 0; i < n; i++) {
			if (i % 2 == 0 || i == 0) {
				s = s + masPtz[i];
			}
		}
	}
	/// <summary>
	/// Подсчет количества элементов, меньше заданного числа
	/// </summary>
	void Lab6::set_count(double* masPtz, int n, double s, int & k) {
		for (int i = 0; i < n; i++) {
			if (masPtz[i] < s) {
				k++;
			}
		}
	}
	/// <summary>
	/// Подсчет количества элементов, меньше заданного числа
	/// </summary>
	void Lab6::set_mas(double *masPtz, double *rezmasPtz, int n, double s) {
		int j = 0;
		for (int i = 0; i < n; i++) {

			if (masPtz[i] < s) {
				rezmasPtz[j] = masPtz[i];
				j++;
			}
		}
	}
	/// <summary>
	/// Вывод в Label числа типа double 
	/// </summary>
	void Lab6::vivod_Label(double z, Label^ t) {
		t->Text = "Сумма чисел, имеющие четные индексы в массиве = " + z.ToString();
	}
}
