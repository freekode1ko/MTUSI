#pragma once
using namespace System;
using namespace System::Windows::Forms;
namespace Laba10Library {
	public ref class Lab10
	{public:
		static	void	CreateBD(String^ Name);
		static	void	CommBD(String^ Comst, String^ BD);
		static	void	add_struct(int cols, String^ BDname);
		static	void	addToBD(int cols, int rows, int** mas, String^ bdname);

		static	int		LowCounter(int **mas, int height, int n);
		static	void	Swamp(int **mas, int width, int height, int num);
		static	void	addToBD2(int cols, int rows, int** mas, String^ bdname);
		static	void	add_struct2(int cols, String^ BDname);

		static	void	addArrayToTxt(DataGridView^ grid, String^ TextName);
		static	void	ReadArray(int len, DataGridView ^grid, String^ TextName);
		static	void	addMatToTxt(DataGridView^ grid, String^ TextName);
		static	void	ReadMat(int n, int m, DataGridView ^grid, String^ TextName);

		static	void	input_mas2(int **mas, int n, int m);
		static	int		max_mas(int **mas, int n, int m);
		static  void	output_mas_int(int** arr, int n, int m, DataGridView^ grid);
		static	int		set_count2(int **mas, int n, int m, int max);
		static	void	set_mas2(int **mas, int *mas2, int n, int m, int max);
		static	void	set_mas3(int **mas, int **mas2, int n, int m, int max);
		static  void	output_mas_int2(int *aPtz, int len, DataGridView^ grid);
		static	void	vivod_Label2(int z, Label^ t);
		static	void	ElDel(double *masPtr, int k, DataGridView^ grid);
		static	void	out_ElDel(double *masPtr, DataGridView^ grid);
	};
}
