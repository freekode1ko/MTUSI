#pragma once

namespace PLDryabkovcpp {

#include <math.h>

	using namespace ClassLibrary1;
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

//#include <msclr/marshal_cppstd.h>
	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::TextBox^  c1_value;
	private: System::Windows::Forms::TextBox^  b1_value;
	private: System::Windows::Forms::TextBox^  x_value;
	private: System::Windows::Forms::TextBox^  z_value;
	private: System::Windows::Forms::TextBox^  b_value;
	private: System::Windows::Forms::TextBox^  c_value;
	private: System::Windows::Forms::TextBox^  m_value;
	private: System::Windows::Forms::TextBox^  n_value;
	private: System::Windows::Forms::TextBox^  h_value;
	private: System::Windows::Forms::TextBox^  max_value;

	protected:

	private: System::Windows::Forms::ListBox^  Answer_List;

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::Label^  label13;
	private: System::Windows::Forms::Label^  label14;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->c1_value = (gcnew System::Windows::Forms::TextBox());
			this->b1_value = (gcnew System::Windows::Forms::TextBox());
			this->x_value = (gcnew System::Windows::Forms::TextBox());
			this->z_value = (gcnew System::Windows::Forms::TextBox());
			this->b_value = (gcnew System::Windows::Forms::TextBox());
			this->c_value = (gcnew System::Windows::Forms::TextBox());
			this->m_value = (gcnew System::Windows::Forms::TextBox());
			this->n_value = (gcnew System::Windows::Forms::TextBox());
			this->h_value = (gcnew System::Windows::Forms::TextBox());
			this->max_value = (gcnew System::Windows::Forms::TextBox());
			this->Answer_List = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(55, 496);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(163, 23);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Расчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::Result_Click);
			// 
			// c1_value
			// 
			this->c1_value->Location = System::Drawing::Point(93, 158);
			this->c1_value->Name = L"c1_value";
			this->c1_value->Size = System::Drawing::Size(100, 20);
			this->c1_value->TabIndex = 1;
			this->c1_value->Text = L"10";
			// 
			// b1_value
			// 
			this->b1_value->Location = System::Drawing::Point(93, 184);
			this->b1_value->Name = L"b1_value";
			this->b1_value->Size = System::Drawing::Size(100, 20);
			this->b1_value->TabIndex = 1;
			this->b1_value->Text = L"2";
			// 
			// x_value
			// 
			this->x_value->Location = System::Drawing::Point(93, 210);
			this->x_value->Name = L"x_value";
			this->x_value->Size = System::Drawing::Size(100, 20);
			this->x_value->TabIndex = 1;
			this->x_value->Text = L"3";
			// 
			// z_value
			// 
			this->z_value->Location = System::Drawing::Point(93, 252);
			this->z_value->Name = L"z_value";
			this->z_value->Size = System::Drawing::Size(100, 20);
			this->z_value->TabIndex = 1;
			// 
			// b_value
			// 
			this->b_value->Location = System::Drawing::Point(536, 125);
			this->b_value->Name = L"b_value";
			this->b_value->Size = System::Drawing::Size(100, 20);
			this->b_value->TabIndex = 1;
			this->b_value->Text = L"2";
			// 
			// c_value
			// 
			this->c_value->Location = System::Drawing::Point(536, 151);
			this->c_value->Name = L"c_value";
			this->c_value->Size = System::Drawing::Size(100, 20);
			this->c_value->TabIndex = 1;
			this->c_value->Text = L"10";
			// 
			// m_value
			// 
			this->m_value->Location = System::Drawing::Point(536, 188);
			this->m_value->Name = L"m_value";
			this->m_value->Size = System::Drawing::Size(100, 20);
			this->m_value->TabIndex = 1;
			this->m_value->Text = L"-1";
			// 
			// n_value
			// 
			this->n_value->Location = System::Drawing::Point(536, 214);
			this->n_value->Name = L"n_value";
			this->n_value->Size = System::Drawing::Size(100, 20);
			this->n_value->TabIndex = 1;
			this->n_value->Text = L"1";
			// 
			// h_value
			// 
			this->h_value->Location = System::Drawing::Point(536, 240);
			this->h_value->Name = L"h_value";
			this->h_value->Size = System::Drawing::Size(100, 20);
			this->h_value->TabIndex = 1;
			this->h_value->Text = L"0.1";
			// 
			// max_value
			// 
			this->max_value->Location = System::Drawing::Point(536, 308);
			this->max_value->Name = L"max_value";
			this->max_value->Size = System::Drawing::Size(100, 20);
			this->max_value->TabIndex = 1;
			// 
			// Answer_List
			// 
			this->Answer_List->FormattingEnabled = true;
			this->Answer_List->Location = System::Drawing::Point(701, 73);
			this->Answer_List->Name = L"Answer_List";
			this->Answer_List->Size = System::Drawing::Size(124, 355);
			this->Answer_List->TabIndex = 2;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(52, 158);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(14, 13);
			this->label1->TabIndex = 3;
			this->label1->Text = L"C";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(52, 184);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(14, 13);
			this->label2->TabIndex = 4;
			this->label2->Text = L"B";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(52, 210);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(14, 13);
			this->label3->TabIndex = 5;
			this->label3->Text = L"X";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(52, 255);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(14, 13);
			this->label4->TabIndex = 6;
			this->label4->Text = L"Z";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(34, 24);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(59, 13);
			this->label5->TabIndex = 7;
			this->label5->Text = L"Задание 1";
			this->label5->Click += gcnew System::EventHandler(this, &MyForm::label5_Click);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(439, 24);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(59, 13);
			this->label6->TabIndex = 7;
			this->label6->Text = L"Задание 2";
			this->label6->Click += gcnew System::EventHandler(this, &MyForm::label5_Click);
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(497, 125);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(14, 13);
			this->label7->TabIndex = 8;
			this->label7->Text = L"B";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(497, 154);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(14, 13);
			this->label8->TabIndex = 8;
			this->label8->Text = L"C";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(439, 191);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(91, 13);
			this->label9->TabIndex = 8;
			this->label9->Text = L"Нижняя граница";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(437, 217);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(93, 13);
			this->label10->TabIndex = 8;
			this->label10->Text = L"Верхняя граница";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(495, 240);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(27, 13);
			this->label11->TabIndex = 8;
			this->label11->Text = L"Шаг";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(469, 311);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(61, 13);
			this->label12->TabIndex = 8;
			this->label12->Text = L"Максимум";
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(701, 54);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(14, 13);
			this->label13->TabIndex = 9;
			this->label13->Text = L"X";
			// 
			// label14
			// 
			this->label14->AutoSize = true;
			this->label14->Location = System::Drawing::Point(747, 53);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(26, 13);
			this->label14->TabIndex = 10;
			this->label14->Text = L"F(X)";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(963, 531);
			this->Controls->Add(this->label14);
			this->Controls->Add(this->label13);
			this->Controls->Add(this->label12);
			this->Controls->Add(this->label11);
			this->Controls->Add(this->label10);
			this->Controls->Add(this->label9);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->Answer_List);
			this->Controls->Add(this->max_value);
			this->Controls->Add(this->h_value);
			this->Controls->Add(this->n_value);
			this->Controls->Add(this->m_value);
			this->Controls->Add(this->c_value);
			this->Controls->Add(this->b_value);
			this->Controls->Add(this->z_value);
			this->Controls->Add(this->x_value);
			this->Controls->Add(this->b1_value);
			this->Controls->Add(this->c1_value);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"Лабораторная работа №4";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void Result_Click(System::Object^  sender, System::EventArgs^  e) {
		try {
			// Вычисления первого задания
			double b1 = Class1::vvod(b1_value);
			double c1 = Class1::vvod(c1_value);
			double x = Class1::vvod(x_value);
			double z = Class1::Solution(x, b1, c1);
			Class1::vivod_TextBox(z, z_value);
			// Вычисления второго задания 
			double m = Class1::vvod(m_value);
			double n = Class1::vvod(n_value);
			double h = Class1::vvod(h_value);
			double b = Class1::vvod(b_value);
			double c = Class1::vvod(c_value);
			double max = -pow(10, 23);
			Class1::ResultProc(b, c, m, h, n, max, Answer_List);
			Class1::vivod_TextBox(max, max_value);
		}
		catch (Exception^ e) 
		{
			//MessageBox::Show("Error");
		}
	}

	private: System::Void c1_value_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
		Class1::TypeCheck(c1_value, e);
	}

private: System::Void label5_Click(System::Object^  sender, System::EventArgs^  e) {
}
};
};
