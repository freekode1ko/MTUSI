#pragma once
using namespace System;
using namespace System::Windows::Forms;
namespace Laba10Library {
	public ref class Lab10
	{public:
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
