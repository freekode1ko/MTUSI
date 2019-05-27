#include "stdafx.h"
#include "math.h"
#include "ClassLibraryLab5.h"

using namespace System;
using namespace System::Windows::Forms;
namespace ClassLibraryLab5 {
	void Class2::Rebound(double eps, double x, ListBox^ l) {
		double i = 0;
		double z = 1;
		double y = x / 2;
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
		return 0.5*(y*i - 1 + (x / y * i - 1));
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