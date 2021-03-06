#pragma once

using namespace System;
using namespace System::Windows::Forms;
#include <time.h>
#include <cstdlib>

namespace Laba8Library {
	public ref class Laba8
	{
	public:

		static void enter_mas(double *masPtz, int n);
		static void output_mas(double *aPtz, int len, DataGridView^ grid);
		static double sum_mas(double *masPtz, int n);
		static void set_count(double* masPtz, int n, double s, int & k);
		static void set_mas(double *masPtz, double *rezmasPtz, int n, double s);
		static void vivod_Label(double z, Label^ t);
		static void add();
		static void add_struct();
		static void add_zap(double *arr, double *resmas1, double *resmas2, int len, int j);
		static void CopyArray(double *arr, double *arr1);
		static void aaa(double *masPtr, int k, DataGridView^ grid);
		static void out_aaa(double *masPtr, DataGridView^ grid);

	};
}
