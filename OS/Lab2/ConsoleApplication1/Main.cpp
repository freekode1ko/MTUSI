#include <iostream>
#include <conio.h>
#include <windows.h>
#include <tlhelp32.h>
#pragma warning(disable: 4996)
#include <locale>

#define cout wcout
#define cin wcin
using namespace std;

void Vivod(HMODULE hModule, wchar_t* longName);
int GetFileName(wchar_t* outName, wchar_t* fullName, const int bufferLength);
void Zadacha2();
void Zadacha3();
#define STRING_LENGTH 256

void main(int argv, char** argc)
{
	setlocale(LC_ALL, "rus");
	cout.imbue(locale("rus_rus.1251"));
	char* param = new char[STRING_LENGTH];
	wchar_t* longName = new wchar_t[STRING_LENGTH];
	strcpy(param, argc[0]);
	wchar_t* shortName = new wchar_t[STRING_LENGTH];
	bool exit = true;
	while (exit)
	{
		cout << "\n�������� ��������:" << endl
			<< "0: ������� Name, FName, Handle" << endl
			<< "1: ������ Name" << endl
			<< "2: ������ FName" << endl
			<< "3: ������ Handle" << endl
			<< "4: ������� 2" << endl
			<< "5: ������� 3" << endl
			<< "6: �����" << endl
			<< "�����: ";

		int n = 0;
		cin >> n;
		HMODULE hModule;
		switch (n)
		{
		case 0:
		{
			mbstowcs(longName, param, STRING_LENGTH);
			hModule = GetModuleHandle(longName);
			Vivod(hModule, longName);
			break;
		}
		case 1:
		{
			cout << endl << "������� Name: ";
			cin >> shortName;
			GetModuleFileName(GetModuleHandle(shortName), longName, STRING_LENGTH);
			hModule = GetModuleHandle(longName);
			Vivod(hModule, longName);
			break;
		}
		case 2:
		{
			cout << endl << "������� FName: ";
			cin >> longName;
			GetFileName(shortName, longName, STRING_LENGTH);
			hModule = GetModuleHandle(longName);
			Vivod(hModule, longName);
			break;
		}
		case 3:
		{
			cout << endl << "������� Handle: ";
			wchar_t* temp = new wchar_t[10];
			cin >> temp;
			wchar_t* endptr;
			long num = wcstoul(temp, &endptr, 16);
			hModule = (HMODULE)num;
			GetModuleFileName(hModule, longName, STRING_LENGTH);
			Vivod(hModule, longName);
			delete[] temp;
			break;
		}
		case 4:
		{
			Zadacha2();
			break;
		}
		case 5:
		{
			Zadacha3();
			break;
		}
		case 6:
		{
			exit = false;
			break;
		}
}

getch();
}
delete[] param;
delete[] longName;
delete[] shortName;
}

int GetFileName(wchar_t* outName, wchar_t* fullName, const int bufferLength)
{
	wchar_t* name = wcsrchr(fullName, L'\\');
	if (name == NULL)
	{
		wcsncpy(outName, fullName, bufferLength);
		return 0;
	}
	else
	{
		wcsncpy(outName, name + 1, bufferLength);
		return 1;
	}
}

void Vivod(HMODULE hModule, wchar_t* longName)
{
	wchar_t* shortName = new wchar_t[STRING_LENGTH];
	GetFileName(shortName, longName, STRING_LENGTH);
	cout << "\nHandle: " << hModule << endl << "Name: " << shortName << endl << "FName: " << longName << endl;
	delete shortName;
}

void ShowProcessEntry(PROCESSENTRY32& entry)
{
	cout << "\n\nth32ProcessID = " << entry.th32ProcessID;
	cout << "\nth32DefaultHeapID = " << entry.th32DefaultHeapID;
	cout << "\nth32ModuleID = " << entry.th32ModuleID;
	cout << "\nth32ParentProcessID = " << entry.th32ParentProcessID;
	cout << "\ncntUsage = " << entry.cntUsage;
	cout << "\ncntThreads = " << entry.cntThreads;
	cout << "\npcPriClassBase = " << entry.pcPriClassBase;
	cout << "\ndwFlags = " << entry.dwFlags;
	cout << "\nszExeFile = " << entry.szExeFile;
}

void ShowThreadEntry(THREADENTRY32& entry)
{
	cout << "\n\nth32ThreadID = " << entry.th32ThreadID;
	cout << "\nth32OwnerProcessID = " << entry.th32OwnerProcessID;
	cout << "\ncntUsage = " << entry.cntUsage;
	cout << "\ntpBasePri = " << entry.tpBasePri;
	cout << "\ntpDeltaPri = " << entry.tpDeltaPri;
	cout << "\ndwFlags = " << entry.dwFlags;
}

void ShowModuleEntry(MODULEENTRY32& entry)

{
	cout << "\n\nth32ModuleID \t= \t" << entry.th32ModuleID;
	cout << "\nth32ProcessID \t= \t" << entry.th32ProcessID;
	cout << "\nGlblcntUsage \t= \t" << entry.GlblcntUsage;
	cout << "\nProccntUsage \t= \t" << entry.ProccntUsage;
	cout << "\nmodBaseAddr \t= \t" << entry.modBaseAddr;
	cout << "\nmodBaseSize \t= \t" << entry.modBaseSize;
	cout << "\nhModule \t= \t" << entry.hModule;
	cout << "\nszModule \t= \t" << entry.szModule;
	cout << "\nszExePath \t= \t" << entry.szExePath;
}

void ShowProcesses()
{
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPPROCESS, 0);
	cout << "\nSnapshot ID = " << hSnapshot;
	PROCESSENTRY32 entry;
	entry.dwSize = sizeof(PROCESSENTRY32);
	BOOL fRepeat = Process32First(hSnapshot, &entry);
	int i = 0;

	while (fRepeat)
	{
		i++;
		ShowProcessEntry(entry);
		fRepeat = Process32Next(hSnapshot, &entry);
		if (i == 10)
		{
			cout << "\n";
			system("pause");
			i = 0;
		}
	}

	CloseHandle(hSnapshot);
	cout << "\n\n=== ����� ������ � ��������� ===\n\n";
}

void ShowThreads()
{
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPTHREAD, 0);
	cout << "\nSnapshot ID = " << hSnapshot;	THREADENTRY32 entry;
	entry.dwSize = sizeof(THREADENTRY32);
	BOOL fRepeat = Thread32First(hSnapshot, &entry);
	DWORD dwCurentProcessId = GetCurrentProcessId();
	while (fRepeat)
	{
		if (entry.th32OwnerProcessID == dwCurentProcessId)
		{
			ShowThreadEntry(entry);
		}
		fRepeat = Thread32Next(hSnapshot, &entry);
	}
	CloseHandle(hSnapshot);
	cout << "\n\n=== ����� ������ � ������� ===\n\n";
}

void ShowModules()
{
	HANDLE hSnapshot = CreateToolhelp32Snapshot(TH32CS_SNAPMODULE, 0);
	cout << "\nSnapshot ID = " << hSnapshot;
	MODULEENTRY32 entry;
	entry.dwSize = sizeof(MODULEENTRY32);
	BOOL fRepeat = Module32First(hSnapshot, &entry);
	while (fRepeat)
	{
		ShowModuleEntry(entry);
		fRepeat = Module32Next(hSnapshot, &entry);
	}
	CloseHandle(hSnapshot);
	cout << "\n\n=== ����� ������ � ������� ===\n\n";
}

void Zadacha2()
{
	setlocale(LC_ALL, "rus");
	cout.imbue(locale("rus_rus.1251"));
	DWORD dCurrentId = GetCurrentProcessId();
	HANDLE hCurrentPseudo = GetCurrentProcess();
	HANDLE hCurrentIdDup;
	DuplicateHandle(hCurrentPseudo, hCurrentPseudo, hCurrentPseudo,
		&hCurrentIdDup, 0, FALSE, DUPLICATE_SAME_ACCESS);
	HANDLE hCurrentIdOpen = OpenProcess(PROCESS_DUP_HANDLE, TRUE, dCurrentId);
	BOOL fClosedDup = CloseHandle(hCurrentIdDup);
	BOOL fClosedOpen = CloseHandle(hCurrentIdOpen);
	cout << "\n������������� �������� ��������: " << dCurrentId
		<< "\n���������������� �������� ��������: " << hCurrentPseudo
		<< "\n����������, ���������� �������� DuplicateHandle: " << hCurrentIdDup
		<< "\n����������, ���������� �������� OpenProcess: " << hCurrentIdOpen
		<< "\n��������� ����������, ���������� �������� OpenProcess: " << fClosedOpen
		<< "\n��������� ����������, ���������� �������� DuplicateHandle: " << fClosedDup << endl;
}

void Zadacha3()
{
	cout << "\n\n=== �������� ===\n";
	getch();
	ShowProcesses();
	cout << "\n\n=== ������ ===\n";
	getch();
	ShowThreads();
	cout << "\n\n=== ������ ===\n";
	getch();
	ShowModules();
}