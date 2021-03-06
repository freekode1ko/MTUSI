#include "stdafx.h"

#include "ClassLibrary1.h"
#include <stdexcept>
using namespace System;
using namespace System::Windows::Forms;
using namespace std;
using namespace System::Xml;

namespace ClassLibrary1 {
	/// <summary>
	/// Метод возвращает значение выражения.
	/// </summary>
	/// <param name="l"></param>
	/// <param name="m"></param>
	/// <param name="f"></param>
	/// <returns></returns>
	double Class1::Solution(double l, double m, double f)
	{
		double z = 0;
		/*
		* l=x
		* m=b
		* f=c
		*/
		if (l > 1)
		{
			z = l * sqrt(pow(m, 2) + pow(f, 2));
		}
		else if (l < 0)
		{
			double min = sqrt(m);
			double m2 = pow(l, 2);
			double m3 = l + f;
			if (m2 < min)
			{
				min = m2;
			}
			if (m3 < min)
			{
				min = m3;
			}
			z = min;
		}
		else
		{
			double m1 = log(m);
			double m2 = l + f;
			double max = m1;
			if (m2 > max)
			{
				max = m2;
			}
			z = max;
		}
		return z;

	}
	/// <summary>
	/// Ввод данных в формате double
	/// </summary>
	/// <param name="x"></param>
	/// <returns></returns>
	double Class1::vvod(TextBox^ x)
	{
		return System::Convert::ToDouble(x->Text);
	}
	/// <summary>
	/// Вывод данных в TextBox
	/// </summary>
	/// <param name="z"></param>
	/// <param name="t"></param>
	void Class1::vivod_TextBox(double z, TextBox^ t)
	{
		t->Text = z.ToString("F5");
	}
	/// <summary>
	/// Вывод данных в ListBox в формате double
	/// </summary>
	/// <param name="x"></param>
	/// <param name="y"></param>
	/// <param name="L"></param>
	void Class1::vivod_ListBox(double x, double y, ListBox^ L)
	{
		L->Items->Add(x.ToString("F2") + "\t" + y.ToString("F3"));
	}
	/// <summary>
	/// Метод реализующий второе задание
	/// </summary>
	/// <param name="b"></param>
	/// <param name="c"></param>
	/// <param name="m"></param>
	/// <param name="h"></param>
	/// <param name="n"></param>
	/// <param name="max"></param>
	/// <param name="L"></param>
	void Class1::ResultProc(double b, double c, double m, double h, double n, double & max, ListBox^ L)
	{
		double x = 0;
		max = Class1::Solution(m, b, c);
		double y = 0;
		L->Items->Clear();
		for (x = m; x <= n; x = x + h)
		{
			y = Class1::Solution(x, b, c);
			Class1::vivod_ListBox(x, y, L);
			if (y > max)
			{
				max = y;
			}
		}
	}

	/// <summary>
	///  Метод проверяющий корректности ввода данных (только числа, и по одному символу "," , "-")
	/// </summary>
	/// <param name="t"></param>
	/// <param name="e"></param>
	void Class1::TypeCheck(TextBox^ t, KeyPressEventArgs^ e)
	{
		if (!Char::IsDigit(e->KeyChar) && !(Char::IsControl(e->KeyChar)))
		{
			if (!(e->KeyChar.ToString() == "," && t->Text->IndexOf(',') == -1) && !(e->KeyChar.ToString() == "-" && t->Text->IndexOf('-') == -1))
			{
				e->Handled = true;
			}
		}
	}
}
