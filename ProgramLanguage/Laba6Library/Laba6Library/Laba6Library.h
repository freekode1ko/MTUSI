#pragma once

using namespace System;
using namespace System::Windows::Forms;

namespace Laba6Library {
	public ref class Lab6
	{
	public:

		static void enter_mas(double *masPtz, int n);
		static void output_mas(double *aPtz, int len, DataGridView^ grid);
		static void sum_mas(double *masPtz, int n, double & s);
		static void set_count(double* masPtz, int n, double s, int & k);
		static void set_mas(double *masPtz, double *rezmasPtz, int n, double s);
		static void vivod_Label(double z, Label^ t);
		static void aaa(double *masPtr, int k, DataGridView^ grid);
		static void out_aaa(double *masPtr, DataGridView^ grid);
	};
}
