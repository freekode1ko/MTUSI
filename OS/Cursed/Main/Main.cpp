// КурсоваяОС.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <conio.h>
#include <windows.h>
#include <tchar.h>
#include <stdio.h>
#include <strsafe.h>
#include <iostream>



using namespace std;

HANDLE hSlot;
LPCTSTR lcName1 = TEXT("\\\\.\\mailslot\\mailslot1");
LPCTSTR SlotName2 = TEXT("\\\\.\\mailslot\\mailslot2");

BOOL ReadSlot()
{
	DWORD cbMessage, cMessage, cbRead;
	BOOL fResult;
	LPTSTR lpszBuffer;
	TCHAR achID[80];
	DWORD cAllMessages;
	HANDLE hEvent;
	OVERLAPPED ov;

	cbMessage = cMessage = cbRead = 0;

	hEvent = CreateEvent(NULL, FALSE, FALSE, TEXT("ExampleSlot"));
	if (NULL == hEvent)
		return  FALSE;
	ov.Offset = 0;
	ov.OffsetHigh = 0;
	ov.hEvent = hEvent;

	fResult = GetMailslotInfo(hSlot, // mailslot handle 
		(LPDWORD)NULL,               // no maximum message size 
		&cbMessage,                   // size of next message 
		&cMessage,                    // number of messages 
		(LPDWORD)NULL);              // no read time-out 

	if (!fResult)
	{
		printf("GetMailslotInfo failed with %d.\n", GetLastError());
		return FALSE;
	}

	if (cbMessage == MAILSLOT_NO_MESSAGE)
	{
		printf("Waiting for a call...\n");
		return TRUE;
	}

	cAllMessages = cMessage;

	while (cMessage != 0)  // retrieve all messages
	{
		// Create a message-number string. 

		StringCchPrintf((LPTSTR)achID,
			80,
			TEXT("\nMessage #%d of %d\n"),
			cAllMessages - cMessage + 1,
			cAllMessages);

		// Allocate memory for the message. 

		lpszBuffer = (LPTSTR)GlobalAlloc(GPTR,
			lstrlen((LPTSTR)achID) * sizeof(TCHAR) + cbMessage);
		if (NULL == lpszBuffer)
			return FALSE;
		lpszBuffer[0] = '\0';

		fResult = ReadFile(hSlot,
			lpszBuffer,
			cbMessage,
			&cbRead,
			&ov);

		if (!fResult)
		{
			printf("ReadFile failed with %d.\n", GetLastError());
			GlobalFree((HGLOBAL)lpszBuffer);
			return FALSE;
		}

		// Concatenate the message and the message-number string. 

		StringCbCat(lpszBuffer,
			lstrlen((LPTSTR)achID) * sizeof(TCHAR) + cbMessage,
			(LPTSTR)achID);

		// Display the message. 

		_tprintf(TEXT("MS contents: %s\n"), lpszBuffer);

		GlobalFree((HGLOBAL)lpszBuffer);

		fResult = GetMailslotInfo(hSlot,  // mailslot handle 
			(LPDWORD)NULL,               // no maximum message size 
			&cbMessage,                   // size of next message 
			&cMessage,                    // number of messages 
			(LPDWORD)NULL);              // no read time-out 

		if (!fResult)
		{
			printf("GetMailslotInfo failed (%d)\n", GetLastError());
			return FALSE;
		}
	}
	CloseHandle(hEvent);
	return FALSE;
}

BOOL WINAPI MakeSlot(LPCTSTR lpszSlotName)
{
	hSlot = CreateMailslot(lpszSlotName,
		0,                             // no maximum message size 
		MAILSLOT_WAIT_FOREVER,         // no time-out for operations 
		(LPSECURITY_ATTRIBUTES)NULL); // default security

	if (hSlot == INVALID_HANDLE_VALUE)
	{
		printf("CreateMailslot ERROR: %d\n", GetLastError());
		return FALSE;
	}
	return TRUE;
}


int main()
{	
	setlocale(LC_ALL, "RUS");
	HANDLE Mutex_Server1 = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server1");
	HANDLE Mutex_Server2 = CreateMutex(NULL, FALSE, (LPCWSTR)"Client_Server2");
	STARTUPINFOA cif;
	ZeroMemory(&cif, sizeof(STARTUPINFOA));
	PROCESS_INFORMATION pi;
	DWORD state;
	cout << "Server=1\n Sending: \n *PC name;\n *Username;\n------------------------\n";
	std::cout << "Server-2\n Sending: \n *Procent of free physic memory;\n *Procent of free virtual memory;\n------------------------\n";
	cout << "TIP:\n" << "Press 1 for call Server-1\n" << "Press 2 for call Server-2\n" << "Press 3 to quit\n";
	int fl;
	cin >> fl;
	while (fl != 3)
	{
		bool S1 = TRUE;
		bool S2 = TRUE;
		switch (fl)
		{
		case 1:
			state = WaitForSingleObject(Mutex_Server1, INFINITE);
			MakeSlot(lcName1);
			while (S1 == TRUE)
			{
				Sleep(3000);
				S1=ReadSlot();
			}
			ReleaseMutex(Mutex_Server1);
			cout << "Transfer is done!" << endl;
			break;
		case 2:
			state = WaitForSingleObject(Mutex_Server2, INFINITE);
			MakeSlot(SlotName2);
			while (S2 == TRUE)
			{
				Sleep(3000);
				S2=ReadSlot();
			}
			ReleaseMutex(Mutex_Server2);
			cout << "Transfer is done!"<< endl;
			break;
		default:
			cout << "Wrong command!" << endl;
			break;
		}
		CloseHandle(hSlot);
		cin >> fl;
	}
	CloseHandle(Mutex_Server1);
	CloseHandle(Mutex_Server2);
	return 0;
}

