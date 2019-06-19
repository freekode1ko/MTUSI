#pragma once

namespace PLDryabkovPlus {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Lab5
	/// </summary>
	public ref class Lab5 : public System::Windows::Forms::Form
	{
	public:
		Lab5(void)
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
		~Lab5()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label5;
	protected:
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::ListBox^  Answer_List;
	private: System::Windows::Forms::TextBox^  c_value;
	private: System::Windows::Forms::TextBox^  b_value;
	private: System::Windows::Forms::TextBox^  z2_value;
	private: System::Windows::Forms::TextBox^  z_value;
	private: System::Windows::Forms::TextBox^  x_value;
	private: System::Windows::Forms::TextBox^  b1_value;
	private: System::Windows::Forms::TextBox^  c1_value;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;

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
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->Answer_List = (gcnew System::Windows::Forms::ListBox());
			this->c_value = (gcnew System::Windows::Forms::TextBox());
			this->b_value = (gcnew System::Windows::Forms::TextBox());
			this->z2_value = (gcnew System::Windows::Forms::TextBox());
			this->z_value = (gcnew System::Windows::Forms::TextBox());
			this->x_value = (gcnew System::Windows::Forms::TextBox());
			this->b1_value = (gcnew System::Windows::Forms::TextBox());
			this->c1_value = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(186, 233);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(28, 13);
			this->label5->TabIndex = 26;
			this->label5->Text = L"Eler:";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(155, 342);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(0, 13);
			this->label12->TabIndex = 25;
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(183, 185);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(14, 13);
			this->label8->TabIndex = 24;
			this->label8->Text = L"E";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(183, 156);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(14, 13);
			this->label7->TabIndex = 23;
			this->label7->Text = L"X";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(18, 230);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(14, 13);
			this->label4->TabIndex = 22;
			this->label4->Text = L"Z";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(18, 185);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(14, 13);
			this->label3->TabIndex = 21;
			this->label3->Text = L"X";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(18, 159);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(14, 13);
			this->label2->TabIndex = 20;
			this->label2->Text = L"B";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(18, 133);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(14, 13);
			this->label1->TabIndex = 19;
			this->label1->Text = L"C";
			// 
			// Answer_List
			// 
			this->Answer_List->FormattingEnabled = true;
			this->Answer_List->Location = System::Drawing::Point(340, 21);
			this->Answer_List->Name = L"Answer_List";
			this->Answer_List->Size = System::Drawing::Size(270, 355);
			this->Answer_List->TabIndex = 18;
			// 
			// c_value
			// 
			this->c_value->Location = System::Drawing::Point(222, 182);
			this->c_value->Name = L"c_value";
			this->c_value->Size = System::Drawing::Size(100, 20);
			this->c_value->TabIndex = 16;
			this->c_value->Text = L"0.00001";
			// 
			// b_value
			// 
			this->b_value->Location = System::Drawing::Point(222, 156);
			this->b_value->Name = L"b_value";
			this->b_value->Size = System::Drawing::Size(100, 20);
			this->b_value->TabIndex = 15;
			this->b_value->Text = L"2";
			// 
			// z2_value
			// 
			this->z2_value->Location = System::Drawing::Point(222, 227);
			this->z2_value->Name = L"z2_value";
			this->z2_value->Size = System::Drawing::Size(100, 20);
			this->z2_value->TabIndex = 14;
			// 
			// z_value
			// 
			this->z_value->Location = System::Drawing::Point(59, 227);
			this->z_value->Name = L"z_value";
			this->z_value->Size = System::Drawing::Size(100, 20);
			this->z_value->TabIndex = 13;
			// 
			// x_value
			// 
			this->x_value->Location = System::Drawing::Point(59, 185);
			this->x_value->Name = L"x_value";
			this->x_value->Size = System::Drawing::Size(100, 20);
			this->x_value->TabIndex = 12;
			this->x_value->Text = L"3";
			// 
			// b1_value
			// 
			this->b1_value->Location = System::Drawing::Point(59, 159);
			this->b1_value->Name = L"b1_value";
			this->b1_value->Size = System::Drawing::Size(100, 20);
			this->b1_value->TabIndex = 11;
			this->b1_value->Text = L"2";
			// 
			// c1_value
			// 
			this->c1_value->Location = System::Drawing::Point(59, 133);
			this->c1_value->Name = L"c1_value";
			this->c1_value->Size = System::Drawing::Size(100, 20);
			this->c1_value->TabIndex = 17;
			this->c1_value->Text = L"10";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(95, 316);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(163, 23);
			this->button1->TabIndex = 10;
			this->button1->Text = L"Расчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Lab5::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(95, 288);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(163, 22);
			this->button2->TabIndex = 27;
			this->button2->Text = L"Назад";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Lab5::button2_Click);
			// 
			// Lab5
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1079, 563);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label5);
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
			this->Controls->Add(this->z2_value);
			this->Controls->Add(this->z_value);
			this->Controls->Add(this->x_value);
			this->Controls->Add(this->b1_value);
			this->Controls->Add(this->c1_value);
			this->Controls->Add(this->button1);
			this->Name = L"Lab5";
			this->Text = L"Лабораторная работа №5";
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		try
		{	//task 1
			double a = ClassLibraryLab51::Class3::Vvod(c1_value);

			double b = ClassLibraryLab51::Class3::Vvod(b1_value);

			double x = ClassLibraryLab51::Class3::Vvod(x_value);

			double rez = ClassLibraryLab51::Class3::Choose(x, b, a);

			ClassLibraryLab51::Class3::Vivod(z_value, rez);

			/*//task 2
			double xx = Class2::VvodL(b_value);

			double eps = Class2::VvodL(c_value);

			Class2::Rebound(eps, xx, Answer_List);*/
			//task 3
			double E = Libr5::Class1::vvod(c_value);
			double X = Libr5::Class1::vvod(b_value);
			double res;
			Libr5::Class1::Euler(X, E, res, Answer_List);
			Libr5::Class1::vivod(res, z2_value);

		}
		catch (Exception^ e)
		{
			//MessageBox::Show("Error");
		}
	}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) 
{
	Owner->Show();
	this->Close();
}
};
}
