#pragma once
#include "Math.h";
namespace PLDryabkovPlus {
	using namespace ClassLibrary1;
	//using namespace CPPClass1;
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for Lab4
	/// </summary>
	public ref class Lab4 : public System::Windows::Forms::Form
	{
	public:
		Lab4(void)
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
		~Lab4()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^  label14;
	protected:
	private: System::Windows::Forms::Label^  label13;
	private: System::Windows::Forms::Label^  label12;
	private: System::Windows::Forms::Label^  label11;
	private: System::Windows::Forms::Label^  label10;
	private: System::Windows::Forms::Label^  label9;
	private: System::Windows::Forms::Label^  label8;
	private: System::Windows::Forms::Label^  label7;
	private: System::Windows::Forms::Label^  label6;
	private: System::Windows::Forms::Label^  label5;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::ListBox^  Answer_List;
	private: System::Windows::Forms::TextBox^  max_value;
	private: System::Windows::Forms::TextBox^  h_value;
	private: System::Windows::Forms::TextBox^  n_value;
	private: System::Windows::Forms::TextBox^  m_value;
	private: System::Windows::Forms::TextBox^  c_value;
	private: System::Windows::Forms::TextBox^  b_value;
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
			this->label14 = (gcnew System::Windows::Forms::Label());
			this->label13 = (gcnew System::Windows::Forms::Label());
			this->label12 = (gcnew System::Windows::Forms::Label());
			this->label11 = (gcnew System::Windows::Forms::Label());
			this->label10 = (gcnew System::Windows::Forms::Label());
			this->label9 = (gcnew System::Windows::Forms::Label());
			this->label8 = (gcnew System::Windows::Forms::Label());
			this->label7 = (gcnew System::Windows::Forms::Label());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->Answer_List = (gcnew System::Windows::Forms::ListBox());
			this->max_value = (gcnew System::Windows::Forms::TextBox());
			this->h_value = (gcnew System::Windows::Forms::TextBox());
			this->n_value = (gcnew System::Windows::Forms::TextBox());
			this->m_value = (gcnew System::Windows::Forms::TextBox());
			this->c_value = (gcnew System::Windows::Forms::TextBox());
			this->b_value = (gcnew System::Windows::Forms::TextBox());
			this->z_value = (gcnew System::Windows::Forms::TextBox());
			this->x_value = (gcnew System::Windows::Forms::TextBox());
			this->b1_value = (gcnew System::Windows::Forms::TextBox());
			this->c1_value = (gcnew System::Windows::Forms::TextBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// label14
			// 
			this->label14->AutoSize = true;
			this->label14->Location = System::Drawing::Point(733, 45);
			this->label14->Name = L"label14";
			this->label14->Size = System::Drawing::Size(26, 13);
			this->label14->TabIndex = 36;
			this->label14->Text = L"F(X)";
			// 
			// label13
			// 
			this->label13->AutoSize = true;
			this->label13->Location = System::Drawing::Point(687, 46);
			this->label13->Name = L"label13";
			this->label13->Size = System::Drawing::Size(14, 13);
			this->label13->TabIndex = 35;
			this->label13->Text = L"X";
			// 
			// label12
			// 
			this->label12->AutoSize = true;
			this->label12->Location = System::Drawing::Point(455, 303);
			this->label12->Name = L"label12";
			this->label12->Size = System::Drawing::Size(61, 13);
			this->label12->TabIndex = 34;
			this->label12->Text = L"Максимум";
			// 
			// label11
			// 
			this->label11->AutoSize = true;
			this->label11->Location = System::Drawing::Point(481, 232);
			this->label11->Name = L"label11";
			this->label11->Size = System::Drawing::Size(27, 13);
			this->label11->TabIndex = 33;
			this->label11->Text = L"Шаг";
			// 
			// label10
			// 
			this->label10->AutoSize = true;
			this->label10->Location = System::Drawing::Point(423, 209);
			this->label10->Name = L"label10";
			this->label10->Size = System::Drawing::Size(93, 13);
			this->label10->TabIndex = 32;
			this->label10->Text = L"Верхняя граница";
			// 
			// label9
			// 
			this->label9->AutoSize = true;
			this->label9->Location = System::Drawing::Point(425, 183);
			this->label9->Name = L"label9";
			this->label9->Size = System::Drawing::Size(91, 13);
			this->label9->TabIndex = 31;
			this->label9->Text = L"Нижняя граница";
			// 
			// label8
			// 
			this->label8->AutoSize = true;
			this->label8->Location = System::Drawing::Point(483, 146);
			this->label8->Name = L"label8";
			this->label8->Size = System::Drawing::Size(14, 13);
			this->label8->TabIndex = 30;
			this->label8->Text = L"C";
			// 
			// label7
			// 
			this->label7->AutoSize = true;
			this->label7->Location = System::Drawing::Point(483, 117);
			this->label7->Name = L"label7";
			this->label7->Size = System::Drawing::Size(14, 13);
			this->label7->TabIndex = 29;
			this->label7->Text = L"B";
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Location = System::Drawing::Point(425, 16);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(59, 13);
			this->label6->TabIndex = 28;
			this->label6->Text = L"Задание 2";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(20, 16);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(59, 13);
			this->label5->TabIndex = 27;
			this->label5->Text = L"Задание 1";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(38, 247);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(14, 13);
			this->label4->TabIndex = 26;
			this->label4->Text = L"Z";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(38, 202);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(14, 13);
			this->label3->TabIndex = 25;
			this->label3->Text = L"X";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(38, 176);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(14, 13);
			this->label2->TabIndex = 24;
			this->label2->Text = L"B";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(38, 150);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(14, 13);
			this->label1->TabIndex = 23;
			this->label1->Text = L"C";
			// 
			// Answer_List
			// 
			this->Answer_List->FormattingEnabled = true;
			this->Answer_List->Location = System::Drawing::Point(687, 65);
			this->Answer_List->Name = L"Answer_List";
			this->Answer_List->Size = System::Drawing::Size(124, 355);
			this->Answer_List->TabIndex = 22;
			// 
			// max_value
			// 
			this->max_value->Location = System::Drawing::Point(522, 300);
			this->max_value->Name = L"max_value";
			this->max_value->Size = System::Drawing::Size(100, 20);
			this->max_value->TabIndex = 20;
			// 
			// h_value
			// 
			this->h_value->Location = System::Drawing::Point(522, 232);
			this->h_value->Name = L"h_value";
			this->h_value->Size = System::Drawing::Size(100, 20);
			this->h_value->TabIndex = 19;
			this->h_value->Text = L"0.1";
			// 
			// n_value
			// 
			this->n_value->Location = System::Drawing::Point(522, 206);
			this->n_value->Name = L"n_value";
			this->n_value->Size = System::Drawing::Size(100, 20);
			this->n_value->TabIndex = 18;
			this->n_value->Text = L"1";
			// 
			// m_value
			// 
			this->m_value->Location = System::Drawing::Point(522, 180);
			this->m_value->Name = L"m_value";
			this->m_value->Size = System::Drawing::Size(100, 20);
			this->m_value->TabIndex = 17;
			this->m_value->Text = L"-1";
			// 
			// c_value
			// 
			this->c_value->Location = System::Drawing::Point(522, 143);
			this->c_value->Name = L"c_value";
			this->c_value->Size = System::Drawing::Size(100, 20);
			this->c_value->TabIndex = 16;
			this->c_value->Text = L"10";
			// 
			// b_value
			// 
			this->b_value->Location = System::Drawing::Point(522, 117);
			this->b_value->Name = L"b_value";
			this->b_value->Size = System::Drawing::Size(100, 20);
			this->b_value->TabIndex = 15;
			this->b_value->Text = L"2";
			// 
			// z_value
			// 
			this->z_value->Location = System::Drawing::Point(79, 244);
			this->z_value->Name = L"z_value";
			this->z_value->Size = System::Drawing::Size(100, 20);
			this->z_value->TabIndex = 14;
			// 
			// x_value
			// 
			this->x_value->Location = System::Drawing::Point(79, 202);
			this->x_value->Name = L"x_value";
			this->x_value->Size = System::Drawing::Size(100, 20);
			this->x_value->TabIndex = 13;
			this->x_value->Text = L"3";
			// 
			// b1_value
			// 
			this->b1_value->Location = System::Drawing::Point(79, 176);
			this->b1_value->Name = L"b1_value";
			this->b1_value->Size = System::Drawing::Size(100, 20);
			this->b1_value->TabIndex = 12;
			this->b1_value->Text = L"2";
			// 
			// c1_value
			// 
			this->c1_value->Location = System::Drawing::Point(79, 150);
			this->c1_value->Name = L"c1_value";
			this->c1_value->Size = System::Drawing::Size(100, 20);
			this->c1_value->TabIndex = 21;
			this->c1_value->Text = L"10";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(41, 488);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(163, 23);
			this->button1->TabIndex = 11;
			this->button1->Text = L"Расчет";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Lab4::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(211, 488);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(164, 23);
			this->button2->TabIndex = 37;
			this->button2->Text = L"Назад";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Lab4::button2_Click);
			// 
			// Lab4
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(863, 535);
			this->Controls->Add(this->button2);
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
			this->Name = L"Lab4";
			this->Text = L"Лабораторная работа №4";
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		try { //MY FUNC
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
			 double max = -(pow(10, 23));
			 Class1::ResultProc(b, c, m, h, n, max, Answer_List);
			 Class1::vivod_TextBox(max, max_value);
			 
			 // CPPClass1
			/*double a, b, h;
			double sum = 0;
			a = Class1::inpd(c1_value);
			b = Class1::inpd(b1_value);
			h = Class1::inpd(x_value);
			Class1::task(a, b, h, sum, Answer_List);
			Class1::outpd(sum, z_value);
			*/
		}
		catch (Exception^ ex)
		{
			MessageBox::Show("Error");
		}
	}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e)
{
	Owner->Show();
	this->Close();
}
};
}
