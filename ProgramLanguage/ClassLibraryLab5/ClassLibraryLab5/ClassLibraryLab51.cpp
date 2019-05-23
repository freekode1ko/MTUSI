#include "stdafx.h"
#include "math.h"
#include "ClassLibraryLab51.h"

using namespace System;
using namespace System::Windows::Forms;
namespace ClassLibraryLab51 {
	//Ввод данных
	double Class1::Vvod(TextBox^ t) {
		return Convert::ToDouble(t->Text);
	}

	//Вывод данных
	void Class1::Vivod(TextBox^ t, double x) {
		t->Text = Convert::ToString(x);
	}

	//Вычисление значения функции
	double Class1::Choose(double l, double m, double f) {
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

	};
}