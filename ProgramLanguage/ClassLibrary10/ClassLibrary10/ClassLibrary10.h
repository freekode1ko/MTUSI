#pragma once

using namespace System;
using namespace System::Windows::Forms;
using namespace System::Xml;
using namespace Microsoft::VisualBasic;
using namespace System::Data::OleDb;
using namespace ADOX;
#include <time.h>
#include <cstdlib>
namespace ClassLibrary10 {
	public ref class Class10
	{
	public:
		// TODO: Добавьте сюда свои методы для этого класса.
		static	void	input_mas2(int **mas, int n, int m);
		static	int		max_mas(int **mas, int n, int m);
		static  void	output_mas_int(int** arr, int n, int m, DataGridView^ grid);
		static	int		set_count2(int **mas, int n, int m, int max);
		static	void	set_mas(double **mas, double *mas2, int n, int m, int s);
		static	void	set_mas2(int **mas, int *mas2, int n, int m, int max);
		static	void	set_mas3(int **mas, int **mas2, int n, int m, int max);
		static  void	output_mas_int2(int *aPtz, int len, DataGridView^ grid);
		static	void	vivod_Label2(int z, Label^ t);
		static	int*	puzir(int *aPtr, int n);

		static	void	addArrayToTxt(DataGridView^ grid, String^ TextName);
		static	void	ReadArray(int len, DataGridView ^grid, String^ TextName);
		static	void	addMatToTxt(DataGridView^ grid, String^ TextName);
		static	void	ReadMat(int n, int m, DataGridView ^grid, String^ TextName);
	};
}
