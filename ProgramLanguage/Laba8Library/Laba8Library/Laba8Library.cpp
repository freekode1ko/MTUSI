#include "stdafx.h"

#include "Laba8Library.h"
using namespace System;
using namespace System::Data;
using namespace System::Windows::Forms;
using namespace Microsoft::VisualBasic;
using namespace System::Data::OleDb;
using namespace ADOX;
#include <time.h>
#include <cstdlib>

namespace Laba8Library {
	/// <summary>
	/// Генерация массива случаных чисел
	/// </summary>
	void Laba8::enter_mas(double *masPtz, int n) {

		srand(time(NULL));

		for (int i = 0; i < n; i++) {
			masPtz[i] = (double)(rand() % 900) / 20 - 20;
		}
	}
	/// <summary>
	/// Вывод массива в DataGridView
	/// </summary>
	void Laba8::output_mas(double *aPtz, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = aPtz[i];
		}
		int Width = 0;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width;
		}
		if (Width > 1200) {
			grid->Width = 1200;
		}
		else {
			grid->Width = Width;
		}
	}
	void Laba8::puzir(double *aPtr, int n) {
		double swap;
		for (int i = 0; i < (n - 1); i++) {
			for (int j = i + 1; j < n; j++) {
				if (aPtr[i] > aPtr[j]) {
					swap = aPtr[i];
					aPtr[i] = aPtr[j];
					aPtr[j] = swap;
				}
			}
		}
	}

	/// <summary>
	/// Подсчет суммы элементов, имеющих четный индекс
	/// </summary>
	double Laba8::sum_mas(double *masPtz, int n) {
		double	s = 0;
		for (int i = 0; i < n; i++) {
			if (i % 2 == 0 || i == 0) {
				s = s + masPtz[i];
			}
		}
		return s;
	}
	/// <summary>
	/// Подсчет суммы элементов, имеющих четный индекс
	/// </summary>

	/// <summary>
	/// Подсчет количества элементов, меньше заданного числа
	/// </summary>
	void Laba8::set_count(double* masPtz, int n, double s, int & k) {
		for (int i = 0; i < n; i++) {
			if (masPtz[i] < s) {
				k++;
			}
		}
	}

	/// <summary>
	/// Подсчет количества элементов, меньше заданного числа
	/// </summary>
	void Laba8::set_mas(double *masPtz, double *rezmasPtz, int n, double s) {
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
	void Laba8::vivod_Label(double z, Label^ t) {
		t->Text = "Сумма чисел, имеющие четные индексы в массиве = " + z.ToString();
	}
	/// <summary>
	/// Создание Базы данных
	/// </summary>
	void Laba8::add() {

		try {
			ADOX::Catalog ^k = gcnew ADOX::CatalogClass();

			k->Create("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");

			MessageBox::Show("БД Создана");

		}
		catch (System::Runtime::InteropServices::COMException^ sit) {
			MessageBox::Show(sit->Message);
		}
	}
	/// <summary>
	/// Создание структуры Базы данных
	/// </summary>
	void Laba8::add_struct() {
		try {

			auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");
			p->Open();

			auto c = gcnew OleDbCommand("CREATE TABLE [MASSIVS] ([Номер Элемента]  char(200),[Исходный массив] char(200), [Результирующий массив] char(200), [Обработанный массив] char(200))", p);
			c->ExecuteNonQuery();

			MessageBox::Show("Структура БД записана", "Информация", MessageBoxButtons::OK, MessageBoxIcon::None);
			p->Close();

		}

		catch (System::Runtime::InteropServices::COMException^ sit) {

			MessageBox::Show(sit->Message);

		}
	}
	/// <summary>
	/// Заполнение Базы данных
	/// </summary>
	void Laba8::add_zap(double *arr, double *resmas1, double *resmas2, int len, int j) {
		for (int i = 0; i < len; i++) {
			//auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=E:\\Users\\User\\New_BD_mass1.mdb");
			auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\BD\\New_BD_mass1.mdb");
			p->Open();
			if (i < j) {
				auto c = gcnew OleDbCommand("INSERT INTO [MASSIVS](" + " [Номер Элемента],[Исходный массив], [Результирующий массив], [Обработанный массив]) VALUES('" + i + "','" + arr[i] + "','" + resmas1[i] + "','" + resmas2[i] + "')");
				c->Connection = p;
				c->ExecuteNonQuery();
			}
			else {
				auto c = gcnew OleDbCommand("INSERT INTO [MASSIVS](" + " [Номер Элемента],[Исходный массив]) VALUES('" + i + "','" + arr[i] + "')");
				c->Connection = p;
				c->ExecuteNonQuery();
				p->Close();
			}
		}
		MessageBox::Show("В таблицу внесены данные", "Информация", MessageBoxButtons::OK, MessageBoxIcon::None);
	}
	void Laba8::CopyArray(double *arr, double *arr1) {
		for (int i = 0; i < sizeof(arr); i++) {
			arr1[i] = arr[i];
		}
	}
}

