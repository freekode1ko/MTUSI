// Server-2.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _CRT_SECURE_NO_WARNINGS
#include "pch.h"
#include <iostream>
#include <conio.h>
#include <windows.h>
#include <stdio.h>
#include <tchar.h>
#include <stdlib.h> 
#include <string.h> 
#include <strsafe.h>
#include <TlHelp32.h>
#include <stdlib.h>

using namespace std;
#define BUFFER_LEN 1024

LPCTSTR SlotName = TEXT("\\\\.\\mailslot\\mailslot2");
HANDLE Mutex_Server2Main = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server2Main");

BOOL WriteSlot(HANDLE hSlot, LPCTSTR lpszMessage)
{
	BOOL fResult;
	DWORD cbWritten;

	fResult = WriteFile(hSlot, lpszMessage, (DWORD)(lstrlen(lpszMessage) + 1) * sizeof(TCHAR), &cbWritten, (LPOVERLAPPED)NULL);

	if (!fResult)
	{
		printf("WriteFile failed with %d.\n", GetLastError());
		_getch();
		return FALSE;
	}

	printf("successfully.\n");
	return TRUE;
}


int main()
{	DWORD state;
	state = WaitForSingleObject(Mutex_Server2Main, 0);
	if (state == WAIT_OBJECT_0)
		cout << "Server in singl copy" << endl;
	else
	{
		cout << "Server alredy is runing!" << endl;
		_getch();
		return 0;
	}
	bool S1=false;
	setlocale(LC_ALL, "RUS");
	HANDLE Mutex_Server2 = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server2");
	MEMORYSTATUS memoryStatus;
	memoryStatus.dwLength = sizeof(memoryStatus);
	GlobalMemoryStatus(&memoryStatus);
	////

	HANDLE hMapFile;
	BOOL bResult;
	DWORD bufCharCount = BUFFER_LEN;
	PCHAR lpBuffer = NULL;
	char buffer[BUFFER_LEN];
	char physicalMemory[BUFFER_LEN];
	char virtualMemory[BUFFER_LEN];
	size_t szBuffer = sizeof(buffer);

	//Получаем информацию о памяти
	MEMORYSTATUSEX statex;
	statex.dwLength = sizeof(statex);
	GlobalMemoryStatusEx(&statex);

	//Физическая память
	double physMem = (double)(statex.ullTotalPhys - statex.ullAvailPhys) / statex.ullTotalPhys * 100;
	sprintf_s(physicalMemory, "%f", physMem);

	//Виртуальная память
	double virtMem = (double)(statex.ullTotalVirtual - statex.ullAvailVirtual) / statex.ullTotalVirtual * 100;
	sprintf_s(virtualMemory, "%f", virtMem);

	////
	
	cout<<"Server №2\n press 1 to start transfer\n press 2 for exit\n_________________________________\n";


	cout << "% virt mem: " << virtMem << " kb  " << std::endl;
	cout << "% phys mem: " << physMem<< " kb " << std::endl;

	HANDLE hFile;
	int f1=0;
	cin >> f1;
	TCHAR ts[100], es[100];
				swprintf(ts, L"procent of free physic memory: %f ", physMem);
				swprintf(es, L"procent of free virtual memory: %f", virtMem);
				while (f1 != 2) {
					S1 = false;
					switch (f1)
					{
					case 1:
						while (S1 == false)
						{
							hFile = CreateFile(SlotName, GENERIC_WRITE, FILE_SHARE_READ, (LPSECURITY_ATTRIBUTES)NULL, OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL, (HANDLE)NULL);

							if (hFile == INVALID_HANDLE_VALUE)
							{
								printf("Waiting for connect...\n");
								Sleep(3000);
							}
							else {
								WriteSlot(hFile, ts);
								WriteSlot(hFile, es);
								CloseHandle(hFile);
								S1 = TRUE;
								CloseHandle(hFile);
							}
						}
						cout << "Transfer is done!" << endl;
						break;
					default:
						cout << "Wrong command!" << endl;
						break;
					}
					cin >> f1;
				}
				CloseHandle(Mutex_Server2);
				CloseHandle(Mutex_Server2Main);

	return 0;
}
