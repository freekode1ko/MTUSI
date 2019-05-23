#include "stdafx.h"

#include "ClassLibrary10.h"

namespace ClassLibrary10 {

	/// <summary>
	/// Создание двумероного массива типа int
	/// </summary>
	void Class10::input_mas2(int **mas, int n, int m) {
		srand(time(NULL));
		for (int i = 0; i < n; i++) {
			mas[i] = new int[m];
			for (int j = 0; j < m; j++) {
				mas[i][j] = (int)(rand() % 900) / 20 - 20;
			}
		}
	}

	/// <summary>
	/// Вывод двумероного массива типа int
	/// </summary>
	void Class10::output_mas_int(int** arr, int n, int m, DataGridView^ grid) {
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
		int Width = 0;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width+5;
		}
		if (grid->Width > 805) {
			grid->Width = 805;
		}
		else {
			grid->Width = Width+5;
		}
		int Height = 0;
		for (int s = 0; s < grid->RowCount; s++) {
			Height += grid->Rows[s]->Height+5;
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
	int Class10::max_mas(int **mas, int n, int m) {
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
	int Class10::set_count2(int **mas, int n, int m, int max) {
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
	void Class10::set_mas2(int **mas, int *mas2, int n, int m, int max) {
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
	void Class10::set_mas3(int **mas, int **mas2, int n, int m, int max) {
		for (int i = 0; i < n; i++) {
			mas2[i] = new int[m];
			for (int j = 0; j < m; j++) {
				mas2[i][j] = mas[i][j] + max;

			}

		}
	}
	/// <summary>
	/// Заполнение одномерного массива элементами из двумерного
	/// </summary>
	void Class10::set_mas(double **mas, double *mas2, int n, int m, int s) {
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

	/// <summary>
	/// Вывод одномерного массива
	/// </summary>
	void Class10::output_mas_int2(int *aPtz, int len, DataGridView^ grid) {
		grid->ColumnCount = len;
		grid->RowCount = 2;
		for (int i = 0; i < len; i++) {
			grid->Rows[0]->Cells[i]->Value = "[" + i + "]";
			grid->Rows[1]->Cells[i]->Value = aPtz[i];
		}
		int Width = 0;
		for (int s = 0; s < grid->ColumnCount; s++) {
			Width += grid->Columns[s]->Width+5;
		}
		if (Width > 1205) {
			grid->Width = 1205;
		}
		else {
			grid->Width = Width+5;
		}
		int Height = 0;
		for (int s = 0; s < grid->RowCount; s++) {
			Height += grid->Rows[s]->Height+5;
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
	/// Вывод в Label числа типа int 
	/// </summary>
	void Class10::vivod_Label2(int z, Label^ t) {
		t->Text = "Наибольший четный элемент = " + z.ToString();
	}
	/// <summary>
	/// Создание массива, отфильрованного по-возрастанию, метод "пузырика"  
	/// </summary>
	int* Class10::puzir(int *aPtr, int n) {
		int *arr = new int[n];
		for (int i = 0; i < n; i++)
		{
			arr[i] = aPtr[i];
		}
		int swap;
		for (int i = 0; i < (n - 1); i++) {
			for (int j = i + 1; j < n; j++) {
				if (arr[i] > arr[j]) {
					swap = arr[i];
					arr[i] = arr[j];
					arr[j] = swap;
				}
			}
		}
		return arr;
	}
	/// <summary>
	/// Заполнение файла типа .txt матрицей из DataGridView
	/// </summary>
	void Class10::addMatToTxt(DataGridView^ grid, String^ TextName) {
		//String ^f = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
		String ^filename = TextName + "2.txt";
		try {
			auto fk = System::Text::Encoding::GetEncoding(1251);
			auto z = gcnew IO::StreamWriter(filename, false, fk);
			String ^MatLine;
			for (int i = 0; i< grid->RowCount; i++) {
				MatLine = "";
				for (int j = 0; j < grid->ColumnCount; j++) {
					MatLine = MatLine + Convert::ToString(grid->Rows[i]->Cells[j]->Value) + " ";
				}

				z->WriteLine(MatLine);
			}
			z->Close();
		}
		catch (System::Exception ^E) {
			MessageBox::Show(E->Message);
		}

	}	/// <summary>
		/// Заполнение файла типа .txt матрицей из DataGridView
		/// </summary>
	void Class10::addArrayToTxt(DataGridView^ grid, String^ TextName) {
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
	void Class10::ReadArray(int len, DataGridView ^grid, String^ TextName) {
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
				Width += grid->Columns[s]->Width+5;
			}
			if (Width > 1205) {
				grid->Width = 1205;
			}
			else {
				grid->Width = Width+5;
			}
			int Height = 0;
			for (int s = 0; s < grid->RowCount; s++) {
				Height += grid->Rows[s]->Height+5;
			}
			Height = Height + grid->Rows[grid->RowCount - 1]->Height * 3 / 2;
			if (grid->Height > 405) {
				grid->Height = 405;
			}
			else {
				grid->Height = Height+5;
			}
		}
		catch (IO::FileNotFoundException ^E) {
			MessageBox::Show(E->Message);
		}
	}
	void Class10::ReadMat(int n, int m, DataGridView ^grid, String^ TextName) {
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
				Width += grid->Columns[s]->Width+5;
			}
			if (Width > 305) {
				grid->Width = 305;
			}
			else {
				grid->Width = Width+5;
			}
			int Height = 0;
			for (int s = 0; s < grid->RowCount; s++) {
				Height += grid->Rows[s]->Height+5;
			}
			Height = Height + grid->Rows[grid->RowCount - 1]->Height * 3 / 2;
			if (grid->Height > 305) {
				grid->Height = 305;
			}
			else {
				grid->Height = Height+5;
			}
		}
		catch (IO::FileNotFoundException ^E) {
			MessageBox::Show(E->Message);
		}
	}
}
