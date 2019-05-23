#pragma once
#include <locale.h>;
#include <stdio.h>

namespace PLDryabkovcppLab12 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace Microsoft::VisualBasic;
	using namespace ClassLibrary10;

	int arrayCount = 0;// номер группы массивов в базе данных
	int matrixCount = 0;// номер группы матриц в базе данных
	int n = 0;// число строк
	int m = 0;// число столбцов
	int **mat;// исходная матрица
	int max;// масимальный четный элемент
	int k;// число элементов в результирующей матрице
	int *rezmas;// результирующая матрица
	int *rezmas2;// отфильтрованная матрица 
	int **rezmat;// результирующая матрица

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
	private: System::Windows::Forms::DataGridView^  dataGridView4;
	private: System::Windows::Forms::DataGridView^  dataGridView5;
	private: System::Windows::Forms::DataGridView^  dataGridView6;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Button^  button2;

	private: System::Windows::Forms::Label^  label1;

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
			this->dataGridView4 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView5 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView6 = (gcnew System::Windows::Forms::DataGridView());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView4))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView5))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView6))->BeginInit();
			this->SuspendLayout();
			// 
			// dataGridView1
			// 
			this->dataGridView1->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView1->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView1->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView1->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->ColumnHeadersVisible = false;
			this->dataGridView1->Location = System::Drawing::Point(70, 37);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowHeadersVisible = false;
			this->dataGridView1->Size = System::Drawing::Size(240, 150);
			this->dataGridView1->TabIndex = 0;
			// 
			// dataGridView2
			// 
			this->dataGridView2->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView2->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView2->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView2->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->ColumnHeadersVisible = false;
			this->dataGridView2->Location = System::Drawing::Point(70, 271);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->RowHeadersVisible = false;
			this->dataGridView2->Size = System::Drawing::Size(240, 98);
			this->dataGridView2->TabIndex = 0;
			// 
			// dataGridView3
			// 
			this->dataGridView3->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView3->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView3->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView3->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView3->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView3->ColumnHeadersVisible = false;
			this->dataGridView3->Location = System::Drawing::Point(70, 428);
			this->dataGridView3->Name = L"dataGridView3";
			this->dataGridView3->RowHeadersVisible = false;
			this->dataGridView3->Size = System::Drawing::Size(240, 69);
			this->dataGridView3->TabIndex = 0;
			// 
			// dataGridView4
			// 
			this->dataGridView4->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView4->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView4->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView4->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView4->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView4->ColumnHeadersVisible = false;
			this->dataGridView4->Location = System::Drawing::Point(573, 37);
			this->dataGridView4->Name = L"dataGridView4";
			this->dataGridView4->RowHeadersVisible = false;
			this->dataGridView4->Size = System::Drawing::Size(240, 103);
			this->dataGridView4->TabIndex = 0;
			// 
			// dataGridView5
			// 
			this->dataGridView5->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView5->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView5->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView5->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView5->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView5->ColumnHeadersVisible = false;
			this->dataGridView5->Location = System::Drawing::Point(70, 527);
			this->dataGridView5->Name = L"dataGridView5";
			this->dataGridView5->RowHeadersVisible = false;
			this->dataGridView5->Size = System::Drawing::Size(240, 70);
			this->dataGridView5->TabIndex = 0;
			// 
			// dataGridView6
			// 
			this->dataGridView6->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView6->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView6->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView6->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView6->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView6->ColumnHeadersVisible = false;
			this->dataGridView6->Location = System::Drawing::Point(1069, 37);
			this->dataGridView6->Name = L"dataGridView6";
			this->dataGridView6->RowHeadersVisible = false;
			this->dataGridView6->Size = System::Drawing::Size(240, 103);
			this->dataGridView6->TabIndex = 0;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(36, 631);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(75, 23);
			this->button1->TabIndex = 1;
			this->button1->Text = L"button1";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(117, 631);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 1;
			this->button2->Text = L"button1";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(76, 249);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(35, 13);
			this->label1->TabIndex = 2;
			this->label1->Text = L"label1";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1464, 717);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->dataGridView3);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView6);
			this->Controls->Add(this->dataGridView5);
			this->Controls->Add(this->dataGridView4);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView4))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView5))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView6))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		try {
			// ----------- Ввод количества строк и столбцов матрицы исходной матрицы -----------//
			String^ g1 = Interaction::InputBox("Введите число строк матрицы:", "Число строк = ", "5", -1, -1);
			String^ g2 = Interaction::InputBox("Введите число столбцов матрицы:", "Число стобцов = ", "5", -1, -1);
			n = Convert::ToInt32(g1);
			m = Convert::ToInt32(g2);
			// ----------- Создание и вывод исходной матрицы -----------//
			mat = new int*[n];
			Class10::input_mas2(mat, n, m);
			Class10::output_mas_int(mat, n, m, dataGridView1);
			// ----------- Создание и вывод результирующего массива -----------//

			max = Class10::max_mas(mat, n, m);
			Class10::vivod_Label2(max, label1);
			k = Class10::set_count2(mat, n, m, max);
			rezmas = new int[k];
			Class10::set_mas2(mat, rezmas, n, m, max);
			Class10::output_mas_int2(rezmas, k, dataGridView2);
			// ----------- Создание и вывод отфильрованного массива -----------// 
			rezmas2 = Class10::puzir(rezmas, k);
			Class10::output_mas_int2(rezmas2, k, dataGridView3);
			// ----------- Создание второй матрицы -----------//
			rezmat = new int*[n];
			Class10::set_mas3(mat, rezmat, n, m, max);
			Class10::output_mas_int(rezmat, n, m, dataGridView4);

		}
		catch (Exception^ e) {
		}

	}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) 
{
	String ^Filename = Interaction::InputBox("Введите путь к файлу: ", "Введите название бд", "C:\\Users\\User\\", -1, -1);
	// ----------- Внесение в файл формата .txt массива -----------//
	Class10::addArrayToTxt(dataGridView2, Filename);
	// ----------- Вынесение и массиваз в файл формата .txt  -----------//
	Class10::ReadArray(k, dataGridView5, Filename);
	Class10::addMatToTxt(dataGridView1, Filename);
	Class10::ReadMat(n, m, dataGridView6, Filename);
	k = 0;
	n = 0;
	m = 0;
	delete rezmas;
	delete rezmas2;
	delete rezmat;
	delete mat;
}

};

}
