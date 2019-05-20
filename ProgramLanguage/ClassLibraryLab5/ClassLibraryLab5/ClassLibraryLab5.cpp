#include "stdafx.h"
#include "math.h"
#include "ClassLibraryLab5.h"

using namespace System;
using namespace System::Windows::Forms;
namespace ClassLibraryLab5 {

	void Class2::Rebound(double eps, double x, ListBox^ l) {

		double i = 0;
		double z = 1;
		double y = x/2;

		do {

			VivodL(y, l, z);
			z++;
			y = Funk(y, x, i);
			i++;
			if (i == 100)
				break;
		} while (fabs(y) > eps);//;while (i < 32);

	}

	double Class2::Funk(double y, double x, int i) {

		return 0.5*(y*i-1 + (x / y*i-1));

	} 
	//Вывод данных

	void Class2::VivodL(double ou, ListBox^ l, double z) {

		l->Items->Add(z + " Член последовательности " + ou);

	}

	//Ввод данных

	double Class2::VvodL(TextBox^ t) {

		double x = Convert::ToDouble(t->Text);

		return x;

	}

	//Ввод данных

	double Class2::Vvod(TextBox^ t) {

		return Convert::ToDouble(t->Text);

	}

	//Вывод данных

	void Class2::Vivod(TextBox^ t, double x) {

		t->Text = Convert::ToString(x);

	}

	//Вычисление значения функции

	double Class2::Choose(double l, double m, double f) {

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