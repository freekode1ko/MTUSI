#pragma once

namespace PLDryabkovcppLab8 {

	using namespace Laba8Library;
	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace Microsoft::VisualBasic;

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
	private: System::Windows::Forms::DataGridView^  dataGridView1;
	protected:
	private: System::Windows::Forms::DataGridView^  dataGridView2;
	private: System::Windows::Forms::DataGridView^  dataGridView3;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Button^  button1;

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
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView3 = (gcnew System::Windows::Forms::DataGridView());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->BeginInit();
			this->SuspendLayout();
			// 
			// dataGridView1
			// 
			this->dataGridView1->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView1->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->ColumnHeadersVisible = false;
			this->dataGridView1->Location = System::Drawing::Point(12, 12);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowHeadersVisible = false;
			this->dataGridView1->Size = System::Drawing::Size(866, 79);
			this->dataGridView1->TabIndex = 0;
			// 
			// dataGridView2
			// 
			this->dataGridView2->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView2->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->ColumnHeadersVisible = false;
			this->dataGridView2->Location = System::Drawing::Point(12, 186);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->RowHeadersVisible = false;
			this->dataGridView2->Size = System::Drawing::Size(866, 79);
			this->dataGridView2->TabIndex = 0;
			// 
			// dataGridView3
			// 
			this->dataGridView3->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView3->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView3->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView3->ColumnHeadersVisible = false;
			this->dataGridView3->Location = System::Drawing::Point(12, 284);
			this->dataGridView3->Name = L"dataGridView3";
			this->dataGridView3->RowHeadersVisible = false;
			this->dataGridView3->Size = System::Drawing::Size(866, 79);
			this->dataGridView3->TabIndex = 0;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(12, 94);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 13);
			this->label1->TabIndex = 1;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(12, 170);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(62, 13);
			this->label2->TabIndex = 2;
			this->label2->Text = L"Результат:";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(9, 268);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(85, 13);
			this->label3->TabIndex = 3;
			this->label3->Text = L"Упорядоченый:";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(402, 389);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 4;
			this->button1->Text = L"Генерация";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(890, 436);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->dataGridView3);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"MyForm";
			this->Text = L"Лабораторная работа №8";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		try {
			// Создание первого массива
			String^g = Interaction::InputBox("Введите количество элементов массива = ", "Введите значение", "", -1, -1);
			int n = Convert::ToInt16(g);
			double *masPtr = new double[n];
			// Заполнение и вывод первого массива
			Laba8::enter_mas(masPtr, n);
			Laba8::output_mas(masPtr, n, dataGridView1);
			// Подсчет суммы элементов, имеющих четный индекс
			double Sum = Laba8::sum_mas(masPtr, n); \
				Laba8::vivod_Label(Sum, label1);
			// Подсчет длинны второго массива
			int k = 0;
			Laba8::set_count(masPtr, n, Sum, k);
			// Создание второго массива
			double *rezmasPtr = new double[k];

			// Заполнение и вывод второго массива
			Laba8::set_mas(masPtr, rezmasPtr, n, Sum);
			Laba8::output_mas(rezmasPtr, k, dataGridView2);

			// Фильрация массива методом пузырика
			double *rezmasPtr2 = new double[k];
			Laba8::CopyArray(rezmasPtr, rezmasPtr2);
			Laba8::puzir(rezmasPtr2, k);
			Laba8::output_mas(rezmasPtr2, k, dataGridView3);
			// Заполнение Базы данных
			Laba8::add();
			Laba8::add_struct();
			Laba8::add_zap(masPtr, rezmasPtr, rezmasPtr2, n, k);
			// Очистка памяти
			delete rezmasPtr;
			delete rezmasPtr2;
			delete masPtr;
		}
		catch (Exception^ e){}
	}
};
}
