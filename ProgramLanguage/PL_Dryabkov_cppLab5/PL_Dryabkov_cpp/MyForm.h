#pragma once

namespace PLDryabkovcpp {

#include <math.h>

	//using namespace ClassLibrary1;
	using namespace ClassLibraryLab5;
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





	protected:

	private: System::Windows::Forms::ListBox^  Answer_List;

	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;


	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label8;



	private: System::Windows::Forms::Label^  label12;



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
			this->Answer_List = (gcnew System::Windows::Forms::ListBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(129, 341);
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
			this->b_value->Location = System::Drawing::Point(256, 181);
			this->b_value->Name = L"b_value";
			this->b_value->Size = System::Drawing::Size(100, 20);
			this->b_value->TabIndex = 1;
			this->b_value->Text = L"2";
			// 
			// c_value
			// 
			this->c_value->Location = System::Drawing::Point(256, 207);
			this->c_value->Name = L"c_value";
			this->c_value->Size = System::Drawing::Size(100, 20);
			this->c_value->TabIndex = 1;
			this->c_value->Text = L"0.00001";
			// 
			// Answer_List
			// 
			this->Answer_List->FormattingEnabled = true;
			this->Answer_List->Location = System::Drawing::Point(374, 46);
			this->Answer_List->Name = L"Answer_List";
			this->Answer_List->Size = System::Drawing::Size(270, 355);
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
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(217, 181);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(14, 13);
			this->label7->TabIndex = 8;
			this->label7->Text = L"X";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(217, 210);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(14, 13);
			this->label8->TabIndex = 8;
			this->label8->Text = L"E";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(189, 367);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(0, 13);
			this->label12->TabIndex = 8;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(963, 531);
			this->Controls->Add(this->label12);
			this->Controls->Add(this->label8);
			this->Controls->Add(this->label7);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->Answer_List);
			this->Controls->Add(this->c_value);
			this->Controls->Add(this->b_value);
			this->Controls->Add(this->z_value);
			this->Controls->Add(this->x_value);
			this->Controls->Add(this->b1_value);
			this->Controls->Add(this->c1_value);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"Лабораторная работа №5";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void Result_Click(System::Object^  sender, System::EventArgs^  e) {
		try 
		{	//task 1
			double a = ClassLibraryLab51::Class3::Vvod(c1_value);

			double b = ClassLibraryLab51::Class3::Vvod(b1_value);

			double x = ClassLibraryLab51::Class3::Vvod(x_value);

			double rez = ClassLibraryLab51::Class3::Choose(x, b, a);

			ClassLibraryLab51::Class3::Vivod(z_value, rez);
			
			//task 2
			double xx = Class2::VvodL(b_value);

			double eps = Class2::VvodL(c_value);

			Class2::Rebound(eps, xx, Answer_List);
			
		}
		catch (Exception^ e) 
		{
			//MessageBox::Show("Error");
		}
	}

	private: System::Void c1_value_KeyPress(System::Object^  sender, System::Windows::Forms::KeyPressEventArgs^  e) {
	//	Class1::TypeCheck(c1_value, e);
	}

private: System::Void label5_Click(System::Object^  sender, System::EventArgs^  e) {
}
private: System::Void MyForm_Load(System::Object^  sender, System::EventArgs^  e) {
}
};
};
