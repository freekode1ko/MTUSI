#pragma once
using namespace System;
namespace ClassLibrary1 {
	using namespace System::Windows::Forms;
	public ref class Class1
	{
	public:

		static double Solution(double l, double m, double f);
		static double vvod(TextBox^ x);
		static void vivod_TextBox(double z, TextBox^ t);
		static void vivod_ListBox(double x, double y, ListBox^ L);
		static void ResultProc(double b, double c, double m, double h, double n, double & max, ListBox^ L);
		static void TypeCheck(TextBox^ t, KeyPressEventArgs^ e);
	};
}
