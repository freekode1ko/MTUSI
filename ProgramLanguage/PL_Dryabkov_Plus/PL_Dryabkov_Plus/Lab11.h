#pragma once

namespace PLDryabkovPlus {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace Laba11Library;
	using namespace Microsoft::VisualBasic;

	/// <summary>
	/// Summary for Lab11
	/// </summary>
	public ref class Lab11 : public System::Windows::Forms::Form
	{
	public:
		Lab11(void)
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
		~Lab11()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^  dataGridView4;
	protected:
	private: System::Windows::Forms::Button^  button3;
	private: System::Windows::Forms::Button^  button2;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::DataGridView^  dataGridView3;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::DataGridView^  dataGridView2;
	private: System::Windows::Forms::DataGridView^  dataGridView1;
	private: System::Windows::Forms::Button^  button4;

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
			this->dataGridView4 = (gcnew System::Windows::Forms::DataGridView());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->dataGridView3 = (gcnew System::Windows::Forms::DataGridView());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->button4 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView4))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// dataGridView4
			// 
			this->dataGridView4->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView4->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView4->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView4->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView4->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView4->ColumnHeadersVisible = false;
			this->dataGridView4->Location = System::Drawing::Point(409, 48);
			this->dataGridView4->Name = L"dataGridView4";
			this->dataGridView4->RowHeadersVisible = false;
			this->dataGridView4->Size = System::Drawing::Size(240, 150);
			this->dataGridView4->TabIndex = 22;
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(816, 291);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(169, 23);
			this->button3->TabIndex = 21;
			this->button3->Text = L"Запись в базу данных";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Lab11::button3_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(816, 205);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(169, 23);
			this->button2->TabIndex = 20;
			this->button2->Text = L"Удалить элемент";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Lab11::button2_Click);
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(17, 373);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(210, 13);
			this->label4->TabIndex = 19;
			this->label4->Text = L"Рельтирущая после удаления элемента";
			// 
			// dataGridView3
			// 
			this->dataGridView3->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView3->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView3->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView3->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView3->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView3->ColumnHeadersVisible = false;
			this->dataGridView3->Location = System::Drawing::Point(13, 389);
			this->dataGridView3->Name = L"dataGridView3";
			this->dataGridView3->RowHeadersVisible = false;
			this->dataGridView3->ScrollBars = System::Windows::Forms::ScrollBars::Horizontal;
			this->dataGridView3->Size = System::Drawing::Size(701, 76);
			this->dataGridView3->TabIndex = 18;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(17, 256);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(78, 13);
			this->label3->TabIndex = 17;
			this->label3->Text = L"Рельтирущая ";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(14, 36);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(157, 13);
			this->label2->TabIndex = 16;
			this->label2->Text = L"Исходная 2х мерная матрица";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(816, 175);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(169, 23);
			this->button1->TabIndex = 15;
			this->button1->Text = L"Сгенерировать";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Lab11::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(813, 231);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 13);
			this->label1->TabIndex = 14;
			// 
			// dataGridView2
			// 
			this->dataGridView2->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView2->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView2->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView2->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->ColumnHeadersVisible = false;
			this->dataGridView2->Location = System::Drawing::Point(13, 272);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->RowHeadersVisible = false;
			this->dataGridView2->ScrollBars = System::Windows::Forms::ScrollBars::Horizontal;
			this->dataGridView2->Size = System::Drawing::Size(701, 173);
			this->dataGridView2->TabIndex = 13;
			// 
			// dataGridView1
			// 
			this->dataGridView1->AllowUserToResizeColumns = false;
			this->dataGridView1->AllowUserToResizeRows = false;
			this->dataGridView1->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView1->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView1->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView1->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView1->ColumnHeadersBorderStyle = System::Windows::Forms::DataGridViewHeaderBorderStyle::None;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->ColumnHeadersVisible = false;
			this->dataGridView1->Location = System::Drawing::Point(13, 55);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowHeadersVisible = false;
			this->dataGridView1->RowHeadersWidth = 21;
			this->dataGridView1->ScrollBars = System::Windows::Forms::ScrollBars::Horizontal;
			this->dataGridView1->Size = System::Drawing::Size(701, 173);
			this->dataGridView1->TabIndex = 12;
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(816, 262);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(169, 23);
			this->button4->TabIndex = 23;
			this->button4->Text = L"Назад";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &Lab11::button4_Click);
			// 
			// Lab11
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1008, 543);
			this->Controls->Add(this->button4);
			this->Controls->Add(this->dataGridView4);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->dataGridView3);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"Lab11";
			this->Text = L"Лабораторная работа №11";
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			this->Load += gcnew System::EventHandler(this, &Lab11::Lab11_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView4))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView3))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		int n = 0;// число строк
		int m = 0;// число столбцов
		int **mat;// исходная матрица
		int max;// масимальный четный элемент
		int k;// число элементов в результирующей матрице
		int *rezmas;// результирующая матрица
	private: System::Void Lab11_Load(System::Object^  sender, System::EventArgs^  e) {
	}
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		//  Ввод количества строк и столбцов матрицы исходной матрицы
		String^ g1 = Interaction::InputBox("Введите число строк матрицы:", "Число строк = ", "5", -1, -1);
		String^ g2 = Interaction::InputBox("Введите число столбцов матрицы:", "Число стобцов = ", "5", -1, -1);
		n = Convert::ToInt32(g1);
		m = Convert::ToInt32(g2);
		//  Создание и вывод исходной матрицы
		mat = new int*[n];
		Laba11Library::Lab11::input_mas2(mat, n, m);
		Laba11Library::Lab11::output_mas_int(mat, n, m, dataGridView1);
		//  Создание и вывод результирующего массива 

		max = Laba11Library::Lab11::max_mas(mat, n, m);
		Laba11Library::Lab11::vivod_Label2(max, label1);
		k = Laba11Library::Lab11::set_count2(mat, n, m, max);
		rezmas = new int[k];
		Laba11Library::Lab11::set_mas2(mat, rezmas, n, m, max);
		Laba11Library::Lab11::output_mas_int2(rezmas, k, dataGridView2);
		Laba11Library::Lab11::output_mas_int2(rezmas, k, dataGridView3);

		Laba11Library::Lab11^ msv = gcnew Laba11Library::Lab11();
		msv->CreateBD(" ");
		msv->add_struct(n, " ");
		msv->addToBD(n, m, mat, " ");

		//
		String^ g3 = Interaction::InputBox("Введите число столбцов матрицы:", "Число стобцов = ", "5", -1, -1);
		int	mm = Convert::ToInt32(g3);

		int dd = Laba11Library::Lab11::LowCounter(mat, m, mm);

		Laba11Library::Lab11::Swamp(mat, n, m, dd);
		Laba11Library::Lab11::output_mas_int(mat, n, m, dataGridView4);
		msv->add_struct2(n, " ");
		msv->addToBD2(n, m, mat, " ");
		//Lab10::output_mas_int2(mat, k, dataGridView4);

	}

private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) 
{
	// Выборка нужного элемента и его удаление
	String^gg = Interaction::InputBox("Введите номер элемента для его удаления = ", " Введите значение ", "", -1, -1);
	int kk = Convert::ToInt16(gg);
	double *rezmasPtr2 = new double[100];
	Laba11Library::Lab11::ElDel(rezmasPtr2, kk, dataGridView3);
	Laba11Library::Lab11::out_ElDel(rezmasPtr2, dataGridView3);
}
private: System::Void button4_Click(System::Object^  sender, System::EventArgs^  e) 
{
	Owner->Show();
	this->Close();
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) 
{

}
};
}
