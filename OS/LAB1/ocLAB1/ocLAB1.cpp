#include "stdafx.h"
#include <windows.h>
#include <iostream>
#pragma warning(disable : 4996)
#define BUFSIZE MAX_PATH
#define UNLEN 256

using namespace std;

void main()
{
	char buffer[MAX_COMPUTERNAME_LENGTH + 1];
	char buf[UNLEN + 1];
	DWORD size,size2;
	size = sizeof(buffer);
	size2 = sizeof(buf);
	GetUserNameA(buf, &size2);
	cout << buf << endl;
	GetComputerNameA(buffer, &size);
	cout << buffer << endl;
	char path[20];
	GetSystemDirectoryA(path, 20);
	cout << path << endl;
	char wpath[20];
	GetWindowsDirectoryA(wpath, 20);
	cout << wpath << endl;
	char tpath[50];
	GetTempPathA(50, tpath);
	cout << tpath << endl;
	OSVERSIONINFO osvi;
	ZeroMemory(&osvi, sizeof(OSVERSIONINFO));
	osvi.dwOSVersionInfoSize = sizeof(OSVERSIONINFO);
	GetVersionEx(&osvi);
	//cout << osvi.szCSDVersion << endl;
	cout << "Version " << osvi.dwMajorVersion << "." << osvi.dwMinorVersion << endl;
	BOOL mrez1 = GetSystemMetrics(SM_SWAPBUTTON);
	cout << mrez1 << endl;
	BOOL mrez2 = GetSystemMetrics(43);
	cout <<mrez2 << endl;
	BOOL prez1 = SystemParametersInfo(SPI_GETDRAGFULLWINDOWS, 0, NULL, 0);
	cout << prez1 << endl;
	int aMouseInfo[3];
	BOOL prez2 = SystemParametersInfo(SPI_GETMOUSE, 0, &aMouseInfo, 0);
	cout << prez2 << endl;

	int aElements[2] = { COLOR_WINDOW, COLOR_WINDOWFRAME };
	DWORD aOldColors[2];
	DWORD aNewColors[2];

	aOldColors[0] = GetSysColor(COLOR_WINDOW);
	printf("Current window color: {0x%x, 0x%x, 0x%x}\n",
		GetRValue(aOldColors[0]),
		GetGValue(aOldColors[0]),
		GetBValue(aOldColors[0]));

	aOldColors[1] = GetSysColor(aElements[1]);
	printf("Current text color: {0x%x, 0x%x, 0x%x}\n",
		GetRValue(aOldColors[1]),
		GetGValue(aOldColors[1]),
		GetBValue(aOldColors[1]));

	aNewColors[1] = RGB(0x80, 0x80, 0x80);
	aNewColors[0] = RGB(0x80, 0x00, 0x80);  // dark purple
	printf("\nNew text color: {0x%x, 0x%x, 0x%x}\n",
		GetRValue(aNewColors[0]),
		GetGValue(aNewColors[0]),
		GetBValue(aNewColors[0]));
	SetSysColors(1, aElements, aNewColors);
	cout << "new text color" << endl;
	Sleep(1000);
	SetSysColors(1, aElements, aOldColors);

	int a = GetTickCount();
	cout << a << endl;
	SYSTEMTIME st;
	GetLocalTime(&st);
	cout << "hour:" << st.wHour << " minutes:" << st.wMinute << endl;
	//
	LONG TFM = GetMessageTime();
	cout << "Time from last message: " << TFM << endl;
	DWORD CP = GetMessagePos();
	cout << "Cursor position for the last message last message: " << CP << endl;
	LPARAM WTF =  GetMessageExtraInfo();
	cout << "Extra message for the current thread: " << WTF << endl;

	FIRMWARE_TYPE tp;
	cout << "System firmware type: " << GetFirmwareType(&tp) << "\n";
	system("PAUSE");
}
	/*
	OSVERSIONINFO osvi;
	BOOL bIsWindowsXPorLater;
	ZeroMemory(&osvi, sizeof(OSVERSIONINFO));
	osvi.dwOSVersionInfoSize = sizeof(OSVERSIONINFO);
	GetVersionEx(&osvi);
	bIsWindowsXPorLater =
		((osvi.dwMajorVersion > 5) ||
		((osvi.dwMajorVersion == 5) && (osvi.dwMinorVersion >= 1)));

	if (bIsWindowsXPorLater)
		printf("The system meets the requirements.\n");
	else printf("The system does not meet the requirements.\n");
	*/
	//LPSYSTEM_INFO sysinfo;
	//GetNativeSystemInfo(sysinfo);
	//cout << sysinfo;
	//

	/*
	TCHAR Buffer[BUFSIZE];
	GetCurrentDirectory(BUFSIZE, Buffer);
	cout << "current dir:" << Buffer << endl;


	SYSTEM_POWER_STATUS status;
	GetSystemPowerStatus(&status);
	int charge = status.BatteryLifePercent;
	cout << "current batery charge:" << charge << endl;
	FIRMWARE_TYPE tp;

	cout << "system firmware type: " << GetFirmwareType(&tp) << ". What means thet it is bios type.\n";
	MEMORYSTATUSEX statex;

	statex.dwLength = sizeof(statex);

	GlobalMemoryStatusEx(&statex);

	cout << "all physical memory: " << statex.ullTotalPhys << endl;
	cout << "used memory: " << statex.dwMemoryLoad << "%\n";
	*/
	//delete aNewColors;
	//delete aOldColors;
