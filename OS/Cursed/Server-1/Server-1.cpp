// Server-1.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//
#define _CRT_SECURE_NO_WARNINGS

#include "pch.h"
#include <iostream>
#include <conio.h>
#include <windows.h>
#include <stdio.h>
#include <cstdio>
#include <tchar.h>
#include <stdlib.h> 
#include <string.h> 
#include <strsafe.h>
#include <TlHelp32.h>
//#pragma warning(suppress : 4996)
#pragma warning(disable : 4996)
using namespace std;
#define BUFFER_LEN 1024

//LPCTSTR SlotNameS2 = TEXT("\\\\.\\mailslot\\mailslotS2");
LPCTSTR SlotName = TEXT("\\\\.\\mailslot\\mailslot1");
int kolmouse, koleso;// , wigthScreen, heightScreen;
HANDLE Mutex_Server1Main = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server1Main");




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
{
	DWORD state;
	state = WaitForSingleObject(Mutex_Server1Main, 0);
	if (state == WAIT_OBJECT_0)
		cout << "Server in single mode" << endl;
	else
	{
		cout << "Server alredy is runing!" << endl;
		_getch();
		return 0;
	}
	int f1 = 0;
	bool S1 = FALSE;
	setlocale(LC_ALL, "RUS");

	HANDLE Mutex_Server1 = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server1");

	cout << "Server №1\n press 1 to start transfer\n press 2 for exit\n_________________________________\n";
	
	////
	HANDLE hMapFile;
	BOOL bResult;
	DWORD bufCharCount = BUFFER_LEN;
	PCHAR lpBuffer = NULL;
	TCHAR buffer[BUFFER_LEN];
	TCHAR computerName[BUFFER_LEN];
	TCHAR userName[BUFFER_LEN];
	size_t szBuffer = sizeof(buffer);

	bufCharCount = BUFFER_LEN;
	GetComputerName(computerName, &bufCharCount);
	//Получаем имя компьютера
	

	//Получаем имя пользователя
	bufCharCount = BUFFER_LEN;
	GetUserName(userName, &bufCharCount); 
	CHAR computerName1[BUFFER_LEN];
	CHAR userName1[BUFFER_LEN];


	bufCharCount = BUFFER_LEN;
	GetComputerNameA(computerName1, &bufCharCount);
	//Получаем имя компьютера


	//Получаем имя пользователя
	bufCharCount = BUFFER_LEN;
	GetUserNameA(userName1, &bufCharCount);
	cout << "Computer name: " << computerName1 << endl;
	cout << "Usename: "<< userName1 << endl;
	//Заносим имя компьютера и имя пользователя в буфер
//	snprintf(buffer, sizeof buffer, "Computer Name: %s\nUser Name: %s", computerName, userName);


	OSVERSIONINFO osvi;
	memset(&osvi, 0x00, sizeof(OSVERSIONINFOEX));
	osvi.dwOSVersionInfoSize = sizeof(OSVERSIONINFOEX);
	GetVersionEx((LPOSVERSIONINFOW)&osvi);

	cout << "OS version: " << (int)osvi.dwMajorVersion <<"."<< (int)osvi.dwMinorVersion<< endl;
	cout << "Build version: " << (int)osvi.dwBuildNumber << endl;
	////
	HANDLE hFile;
	TCHAR kp[100];
	TCHAR km[100];

	swprintf(km, L"PC name: %s", computerName);
	swprintf(kp, L"Username: %s", userName);

	TCHAR ka[100];
	TCHAR kb[100];
	TCHAR kc[100];

	swprintf(ka, L"Win major version: %d", (int)osvi.dwMajorVersion);
	swprintf(kc, L"Win minor version: %d", (int)osvi.dwMinorVersion);
	swprintf(kb, L"Win build version: %d", (int)osvi.dwBuildNumber);
	cin >> f1;
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
					WriteSlot(hFile, km);
					WriteSlot(hFile, kp);

					WriteSlot(hFile, ka);
					WriteSlot(hFile, kc);
					WriteSlot(hFile, kb);

					CloseHandle(hFile);
					S1 = TRUE;
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
	
	
	Sleep(3000);

	CloseHandle(Mutex_Server1);
	CloseHandle(Mutex_Server1Main);
	return 0;
}



