#include "stdafx.h"
#include "math.h"
#include "ClassLibraryLab5.h"

using namespace System;
using namespace System::Windows::Forms;
namespace ClassLibraryLab5 {

	void Class2::Rebound(double x, double eps,  TextBox ^t,ListBox^ l) {

		//double i = 0;
		//double z = 1;
		//double y = x/2;
		int n = 1; double fx, fxproizv;
		while (Math::Tan(x) - x > Convert::ToDouble(exp))
		{

/*
			z++;
			y = Funk(y, x, i);
			i++;
			if (i == 100)
				break;
*/
			
			
			VivodL(x, l, n);
			fx = Math::Tan(x) - x;
			fxproizv = 1 / Math::Pow(Math::Cos(x), 2) - 1;
			x = x - (fx / fxproizv);
			n++;

		}
//		vivoddouble(fx, t);
	}
	//Вывод в textBox в формате double
	void Class2::vivoddouble(double z, TextBox^t)
	{
		t->Text = Convert::ToString(z);
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

}