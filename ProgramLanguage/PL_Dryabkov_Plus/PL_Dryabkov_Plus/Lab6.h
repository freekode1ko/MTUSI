#pragma once

namespace PLDryabkovPlus {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace Laba6Library;
	using namespace Microsoft::VisualBasic;

	/// <summary>
	/// Summary for Lab6
	/// </summary>
	public ref class Lab6 : public System::Windows::Forms::Form
	{
	public:
		Lab6(void)
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
		~Lab6()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button2;
	protected:
	private: System::Windows::Forms::Button^  button1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::DataGridView^  dataGridView2;
	private: System::Windows::Forms::DataGridView^  dataGridView1;
	private: System::Windows::Forms::Button^  button3;

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
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->dataGridView2 = (gcnew System::Windows::Forms::DataGridView());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->button3 = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->BeginInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(277, 217);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(169, 23);
			this->button2->TabIndex = 9;
			this->button2->Text = L"������� �������";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &Lab6::button2_Click);
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(277, 187);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(169, 23);
			this->button1->TabIndex = 8;
			this->button1->Text = L"�������������";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &Lab6::button1_Click);
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(9, 84);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(0, 13);
			this->label1->TabIndex = 7;
			// 
			// dataGridView2
			// 
			this->dataGridView2->AutoSizeColumnsMode = System::Windows::Forms::DataGridViewAutoSizeColumnsMode::AllCells;
			this->dataGridView2->AutoSizeRowsMode = System::Windows::Forms::DataGridViewAutoSizeRowsMode::AllCells;
			this->dataGridView2->BackgroundColor = System::Drawing::SystemColors::Control;
			this->dataGridView2->BorderStyle = System::Windows::Forms::BorderStyle::None;
			this->dataGridView2->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView2->ColumnHeadersVisible = false;
			this->dataGridView2->Location = System::Drawing::Point(12, 112);
			this->dataGridView2->Name = L"dataGridView2";
			this->dataGridView2->RowHeadersVisible = false;
			this->dataGridView2->ScrollBars = System::Windows::Forms::ScrollBars::Horizontal;
			this->dataGridView2->Size = System::Drawing::Size(708, 69);
			this->dataGridView2->TabIndex = 6;
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
			this->dataGridView1->Location = System::Drawing::Point(12, 12);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->RowHeadersVisible = false;
			this->dataGridView1->RowHeadersWidth = 21;
			this->dataGridView1->ScrollBars = System::Windows::Forms::ScrollBars::Horizontal;
			this->dataGridView1->Size = System::Drawing::Size(708, 69);
			this->dataGridView1->TabIndex = 5;
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(277, 247);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(169, 23);
			this->button3->TabIndex = 10;
			this->button3->Text = L"�����";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &Lab6::button3_Click);
			// 
			// Lab6
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1028, 534);
			this->Controls->Add(this->button3);
			this->Controls->Add(this->button2);
			this->Controls->Add(this->button1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->dataGridView2);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"Lab6";
			this->Text = L"������������ ������ �6";
			this->WindowState = System::Windows::Forms::FormWindowState::Maximized;
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView2))->EndInit();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) 
	{
		try {
			// �������� ������� �������
			String^g = Interaction::InputBox("������� ���������� ��������� ������� = ", "������� ��������", "", -1, -1);
			int n = Convert::ToInt16(g);
			double *masPtz = new double[n];
			// ���������� � ����� ������� �������
			Laba6Library::Lab6::enter_mas(masPtz, n);
			Laba6Library::Lab6::output_mas(masPtz, n, dataGridView1);
			// �������� ����� ���������, ������� ������ ������
			double Sum = 0;
			Laba6Library::Lab6::sum_mas(masPtz, n, Sum);
			Laba6Library::Lab6::vivod_Label(Sum, label1);
			// ������� ������ ������� �������
			int k = 0;
			Laba6Library::Lab6::set_count(masPtz, n, Sum, k);
			// �������� ������� �������
			double *rezmasPtz = new double[k];
			// ���������� � ����� ������� �������
			Laba6Library::Lab6::set_mas(masPtz, rezmasPtz, n, Sum);
			Laba6Library::Lab6::output_mas(rezmasPtz, k, dataGridView2);
			// ������� ������
			delete rezmasPtz;
			delete masPtz;
		}
		catch (Exception^ e) {}
	}
private: System::Void button2_Click(System::Object^  sender, System::EventArgs^  e) 
{
	try
	{
		//��������� � �������� �� ��������
		String^g = Interaction::InputBox("������� ����� �������� ��� ��� �������� ", "������� ��������", "", -1, -1);
		int k = Convert::ToInt16(g);
		//�������� ������ �������
		double *masPtz = new double[dataGridView2->ColumnCount];
		//�������� ��������� �������� �� ������� � ����� �������������� �������
		Laba6Library::Lab6::aaa(masPtz, k, dataGridView2);
		Laba6Library::Lab6::out_aaa(masPtz, dataGridView2);
		//������� ������
		delete masPtz;
	}
	catch (Exception^ e) {}
}
private: System::Void button3_Click(System::Object^  sender, System::EventArgs^  e) 
{
	Owner->Show();
	this->Close();
}

};
}
