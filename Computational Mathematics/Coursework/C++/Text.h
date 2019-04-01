#include "stdafx.h"
int strlen(TCHAR* str)
{
int len;
for(len=0;*str;len++,str++);
return len;
}
void inputText( HWND hWnd,HDC hdc)
{
PAINTSTRUCT ps;
TCHAR* line[] ={TEXT("Курсовая по ВМ"),
				TEXT("   "),
				TEXT("Выполнил студент"),
				TEXT("Дрябков Олег"),
				TEXT("   "),};
COLORREF masColor=RGB(0,0,0);
HPEN hPen0	= CreatePen(PS_SOLID,4,masColor);
HPEN hOldPen= (HPEN)SelectObject(hdc,hPen0);
static LOGFONT lf;
lf.lfPitchAndFamily	= FIXED_PITCH | FF_MODERN;
lf.lfItalic			= TRUE;
lf.lfWeight			= FW_BOLD;
lf.lfHeight			= 80;
lf.lfCharSet		= RUSSIAN_CHARSET;
HFONT hFont0	= CreateFontIndirect(&lf);
HFONT hOldFont	= (HFONT)SelectObject(hdc,hFont0);
SetTextColor(hdc,masColor);
int x=50, y=30,dX=80, dY=50;
TextOut (hdc,x,y,line[0],strlen(line[0]));
POINT tabStop[]={{x,y+3*dY},
				 {x,y+4*dY},
				 {x,y+5*dY},
				 {x,y+6*dY}};
int fontHeight[]={50,40,70};
MoveToEx(hdc,x,y+1.5*dY,NULL);
LineTo(hdc,x+7.3*dX,y+1.5*dY);
DeleteObject(SelectObject(hdc,hFont0));
for( int i=0; i<4; i++)
	{
	lf.lfPitchAndFamily	= FIXED_PITCH | FF_MODERN;
	lf.lfItalic			= FALSE;
	lf.lfWeight			= FW_BOLD;
	lf.lfHeight			= fontHeight[1];
	lf.lfCharSet		= RUSSIAN_CHARSET;
	hFont0	= CreateFontIndirect(&lf);
	SelectObject(hdc,hFont0);
	SetTextColor(hdc,masColor);
	TextOut (hdc,tabStop[i].x,tabStop[i].y,line[i+1],strlen(line[i+1]));
	DeleteObject(SelectObject(hdc,hFont0));
	}
DeleteObject(SelectObject(hdc,hOldPen));
DeleteObject(SelectObject(hdc,hOldFont));
}
