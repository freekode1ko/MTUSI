#include "stdafx.h"

#include "Laba10Library.h"

using namespace System::Windows::Forms;
using namespace Microsoft::VisualBasic;
using namespace ADOX;
using namespace System::Data::OleDb;
#include <time.h>
#include <cstdlib>

namespace Laba10Library 
{

	/// <summary>
	/// Заполнение файла типа .txt массива из DataGridView
	/// </summary>
	void Lab10::addArrayToTxt(DataGridView^ grid, String^ TextName) {
		//String ^f = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
		String ^filename = TextName + "1.txt";
		try {
			auto fk = System::Text::Encoding::GetEncoding(1251);
			auto z = gcnew IO::StreamWriter(filename, false, fk);
			String ^MatLine;
				for (int j = 0; j < grid->ColumnCount; j++) 
				{
					MatLine = MatLine + Convert::ToString(grid->Rows[1]->Cells[j]->Value);
					z->WriteLine(MatLine);
					MatLine = "";
				}
				
				z->Close();
		}
		catch (System::Exception ^E) {
			MessageBox::Show(E->Message);
		}

	}	
		/// <summary>
		/// Заполнение файла типа .txt матрицей из DataGridView
		/// </summary>
	void Lab10::addMatToTxt(DataGridView^ grid, String^ TextName) {
		//String ^f = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
		String ^filename = TextName + "2.txt";
		try {
			auto fk = System::Text::Encoding::GetEncoding(1251);
			auto z = gcnew IO::StreamWriter(filename, false, fk);
			String ^MatLine;
			for (int i = 0; i < grid->ColumnCount; i++) {
				MatLine = "";
				for (int j = 0; j < grid->RowCount; j++) {
					MatLine = MatLine + Convert::ToString(grid->Rows[i]->Cells[j]->Value) + " ";
				}
				z->WriteLine(MatLine);
			}
			z->Close();
		}
		catch (System::Exception ^E) {
			MessageBox::Show(E->Message);
		}

	}
	/// <summary>
	/// Заполнение DataGridView одномерным массивом из файла типа .txt
	/// </summary>
	void Lab10::ReadArray(int len, DataGridView ^grid, String^ TextName) {
		//String ^f = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
		String ^filename = TextName + "1.txt";
		grid->ColumnCount = len;
		grid->RowCount = 2;
		try {
			IO::StreamReader ^R = gcnew IO::StreamReader(filename);
			for (int i = 0; i < len; i++) {
				grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
				grid->Rows[1]->Cells[i]->Value = R->ReadLine();
			}
			R->Close();
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
			int Height = 0;
			for (int s = 0; s < grid->RowCount; s++) {
				Height += grid->Rows[s]->Height;
			}
			Height = Height + grid->Rows[grid->RowCount - 1]->Height * 3 / 2;
			if (grid->Height > 400) {
				grid->Height = 400;
			}
			else {
				grid->Height = Height;
			}
		}
		catch (IO::FileNotFoundException ^E) {
			MessageBox::Show(E->Message);
		}
	}
	void Lab10::ReadMat(int n, int m, DataGridView ^grid, String^ TextName) {
		//String ^f = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
		String ^filename = TextName + "2.txt";
		grid->ColumnCount = m + 1;
		grid->RowCount = n + 1;
		try {
			IO::StreamReader ^R = gcnew IO::StreamReader(filename);
			for (int i = 0; i <= n; i++) {
				grid->Rows[i]->Cells[0]->Value = "[" + i + "]";

			}
			for (int i = 0; i <= m; i++) {
				grid->Rows[0]->Cells[i]->Value = "[" + i + "]";

			}
			R->ReadLine();
			for (int i = 1; i <= n; i++) {
				char delim = ' ';
				String^ str = Convert::ToString(R->ReadLine());
				array<String^>^split = str->Split(delim);

				for (int j = 1; j <= m; j++) {
					grid->Rows[i]->Cells[j]->Value = Convert::ToInt32(split[j]);
				}
			}
			R->Close();
			int Width = 0;
			for (int s = 0; s < grid->ColumnCount; s++) {
				Width += grid->Columns[s]->Width;
			}
			if (Width > 300) {
				grid->Width = 300;
			}
			else {
				grid->Width = Width;
			}
			int Height = 0;
			for (int s = 0; s < grid->RowCount; s++) {
				Height += grid->Rows[s]->Height;
			}
			Height = Height + grid->Rows[grid->RowCount - 1]->Height * 3 / 2;
			if (grid->Height > 300) {
				grid->Height = 300;
			}
			else {
				grid->Height = Height;
			}
		}
		catch (IO::FileNotFoundException ^E) {
			MessageBox::Show(E->Message);
		}
	}


	/// <summary>
	/// Создание БД
	/// </summary>
	void Lab10::CreateBD(String^ Name)
	{
		ADOX::CatalogClass^ k = gcnew ADOX::CatalogClass();
		try
		{
			k->Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD\\test.mdb");
			MessageBox::Show("База данных успешно создана");
		}
		catch (System::Runtime::InteropServices::COMException^ sit)
		{
			MessageBox::Show(sit->Message);
		}
		finally{ k = nullptr; };

	}

	void Lab10::CommBD(String^ Comst, String^ BD) 
	{
		auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD\\test.mdb");
		p->Open();
		auto com = gcnew OleDbCommand(" " + Comst);
		com->Connection = p;
		com->ExecuteNonQuery();
		p->Close();
	}

	/// <summary>
	/// Создание структуры
	/// </summary>
	void Lab10::add_struct(int cols, String^ BDname) 
	{
		auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD\\test.mdb");
		p->Open();
		String^ c = "CREATE TABLE[MATRIX]([Rows] counter";
		for (int i = 0; i<cols; i++) {
			c = c + ", [" + "c" + Convert::ToString(i + 1) + "] char(20)";
		}
		auto com = gcnew OleDbCommand(c + ")", p);
		try {
			com->ExecuteNonQuery();
			MessageBox::Show("Структура БД успешно сформирована!");
		}
		catch (Exception ^ e)
		{
			MessageBox::Show(e->Message);
		}
		p->Close();
	}
	/// <summary>
	/// Добавление массива в БД
	/// </summary>

	void Lab10::addToBD(int cols, int rows, int** mas, String^ bdname) 
	{
		String^ cmdstr;
		String^ cmdstr2;
		int i, j;
		for (i = 0; i<rows; i++) {
			cmdstr = "INSERT INTO [MATRIX] ([Rows]";
			cmdstr2 = ") VALUES (" + "'" + Convert::ToString(i + 1) + "'";

			for (j = 0; j <cols; j++) {
				cmdstr = cmdstr + ", [c" + Convert::ToString(j + 1) + "]";
				cmdstr2 = cmdstr2 + ", '" + Convert::ToString(mas[i][j]) + "'";
			}

			cmdstr2 = cmdstr2 + ")";
			CommBD(cmdstr + cmdstr2, bdname);
		}
		MessageBox::Show("Массив успешно занесен в базу данных");

	}

	void Lab10::add_struct2(int cols, String^ BDname)
	{
		auto p = gcnew OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= D:\\BD\\test.mdb");
		p->Open();
		String^ c = "CREATE TABLE[MATRIX2]([Rows] counter";
		for (int i = 0; i<cols; i++) {
			c = c + ", [" + "c" + Convert::ToString(i + 1) + "] char(20)";
		}
		auto com = gcnew OleDbCommand(c + ")", p);
		try {
			com->ExecuteNonQuery();
			MessageBox::Show("Структура БД успешно сформирована!");
		}
		catch (Exception ^ e)
		{
			MessageBox::Show(e->Message);
		}
		p->Close();
	}
	void Lab10::addToBD2(int cols, int rows, int** mas, String^ bdname)
	{
		String^ cmdstr;
		String^ cmdstr2;
		int i, j;
		for (i = 0; i<rows; i++) {
			cmdstr = "INSERT INTO [MATRIX2] ([Rows]";
			cmdstr2 = ") VALUES (" + "'" + Convert::ToString(i + 1) + "'";

			for (j = 0; j <cols; j++) {
				cmdstr = cmdstr + ", [c" + Convert::ToString(j + 1) + "]";
				cmdstr2 = cmdstr2 + ", '" + Convert::ToString(mas[i][j]) + "'";
			}

			cmdstr2 = cmdstr2 + ")";
			CommBD(cmdstr + cmdstr2, bdname);
		}
		MessageBox::Show("Массив успешно занесен в базу данных");

	}

	/// <summary>
	/// Создание двумероного массива типа int
	/// </summary>
	void Lab10::input_mas2(int **mas, int n, int m) {
		srand(time(NULL));
		for (int i = 0; i < n; i++) {
			mas[i] = new int[m];
			for (int j = 0; j < m; j++) {
				mas[i][j] = (int)(rand() % 900) / 20 - 20;
			}
		}
	}
	int Lab10::LowCounter(int **mas, int height,int num)
	{
		int call = 0;
			for(int i =0 ; i<height;i++)
			{
				if(mas[i][num]<0)
				{
					call++;
				}
			}
		return call;
	}

	void Lab10::Swamp(int **mas, int width, int height,int num)
	{
		for (int i = 0; i < width; i++)
		{
			for (int j = 0; j < height; j++)
			{
				if (i > j)
				{
					mas[i][j] = num;
				}
			}
		}
	}

	/// <summary>
	/// Вывод двумероного массива типа int
	/// </summary>
	void Lab10::output_mas_int(int** arr, int n, int m, DataGridView^ grid) {
		grid->ColumnCount = m + 1;
		grid->RowCount = n + 1;
		grid->Rows[0]->Cells[0]->Value = "[" + n + "]" + "[" + m + "]";
		for (int i = 0; i < n; i++) {
			grid->Rows[i + 1]->Cells[0]->Value = "[" + i + "]";
		}
		for (int j = 0; j < m; j++) {
			grid->Rows[0]->Cells[j + 1]->Value = "[" + j + "]";
		}
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				grid->Rows[i + 1]->Cells[j + 1]->Value = arr[i][j];
			}
		}
		int Width = 5;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width+1;
		}
		if (grid->Width > 805) {
			grid->Width = 805;
		}
		else {
			grid->Width = Width+5;
		}
		int Height = 5;
		for (int s = 0; s < grid->RowCount; s++) {
			Height += grid->Rows[s]->Height + 1;
		}

		Height = Height + grid->Rows[grid->RowCount - 1]->Height*1.5;

		if (grid->Height > 405) {
			grid->Height = 405;

		}
		else {
			grid->Height = Height+5;
		}
	}

	/// <summary>
	/// Поиск максимального четного элемента матрицы
	/// </summary>
	int Lab10::max_mas(int **mas, int n, int m) {
		double max = mas[0][0];
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (mas[i][j] > max && mas[i][j] % 2 == 0) {
					max = mas[i][j];
				}
			}

		}
		return max;
	}
	/// <summary>
	///  Подсчет количества элементов, меньше заданного числа для массива типа int
	/// </summary>
	int Lab10::set_count2(int **mas, int n, int m, int max) {
		int k = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (mas[i][j] < max) {
					k++;
				}
			}
		}


		return k;
	}




	/// <summary>
	///  Формирование результирующего массива
	/// </summary>
	void Lab10::set_mas2(int **mas, int *mas2, int n, int m, int max) {
		int g = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (mas[i][j] < max) {
					mas2[g] = mas[i][j];
					g++;
				}
			}

		}

	}
	/// <summary>
	///  Формирование результирующей матрицы
	/// </summary>
	void Lab10::set_mas3(int **mas, int **mas2, int n, int m, int max) {
		for (int i = 0; i < n; i++) {
			mas2[i] = new int[m];
			for (int j = 0; j < m; j++) {
				mas2[i][j] = mas[i][j] + max;

			}

		}
	}
	/*
	/// <summary>
	/// Заполнение одномерного массива элементами из двумерного
	/// </summary>
	void Lab10::set_mas(double **mas, double *mas2, int n, int m, int s) {
		int g = 0;
		for (int i = 0; i < n; i++) {
			for (int j = 0; j < m; j++) {
				if (mas[i][j] < s) {
					mas2[g] = mas[i][j];
					g++;
				}
			}

		}
	}
	*/
	/// <summary>
	/// Вывод одномерного массива
	/// </summary>
	void Lab10::output_mas_int2(int *aPtz, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = aPtz[i];
		}
		int Width = 5;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width;
		}
		if (Width > 1205) {
			grid->Width = 1205;
		}
		else {
			grid->Width = Width;
		}
		int Height = 5;
		for (int s = 0; s < grid->RowCount; s++) {
			Height += grid->Rows[s]->Height;
		}
		Height = Height + grid->Rows[grid->RowCount - 1]->Height * 3 / 2;
		if (grid->Height > 405) {
			grid->Height = 405;
		}
		else {
			grid->Height = Height+5;
		}
	}
	/// <summary>
	/// Удаление выброного элемента массива
	/// </summary>
	void Lab10::ElDel(double *masPtr, int k, DataGridView^ grid)
	{

		// Заполнение массиваin
		for (int i = 0; i < grid->ColumnCount; i++)
		{
			masPtr[i] = System::Convert::ToDouble(grid->Rows[1]->Cells[i]->Value);
		}
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
	void Lab10::out_ElDel(double *masPtr, DataGridView^ grid)
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
	/// Вывод в Label числа типа int 
	/// </summary>
	void Lab10::vivod_Label2(int z, Label^ t) {
		t->Text = "Наибольший четный элемент = " + z.ToString();
	}
}
