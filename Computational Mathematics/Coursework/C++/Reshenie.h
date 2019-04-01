#include <math.h>

#define		r	10
#define		l	1
#define		c	0.000001
#define		e	10

void difur(HWND hList)
{
	TCHAR buf[200];
	double a=0;
	double b=0.004;
	double h=0.0002;
	double E=0.1;
	double k1,k2;
	double x=0;
	double yi=0;
	double zi=0;
	double z,y;
	swprintf(buf,TEXT(" %-1.4f ║ %-9f ║ %-5.1f "),x,yi,zi);	
	SendMessage(hList,LB_ADDSTRING,0,(LPARAM)buf);
	for(double i=a;i<=b;i+=h)
	{
	x=x+h;
	z=zi+h*(-(r/l)*zi+(e-yi)/(l*c));
	y=yi+h*zi;
	yi=y;
	zi=z;
	swprintf(buf,TEXT(" %-1.4f ║ %-9f ║ %-5.1f "),x,y,z);	
	SendMessage(hList,LB_ADDSTRING,0,(LPARAM)buf);
	}
}

double y(double x)
{
	double m1=2841293853777390;
	double m2=372448727428171;
	double m3=-2846491805720.19;
	double m4=2238527280.58129;
	double m5=9396463.10261702;
	double m6=25.7869435123593;

return m1*(x*x*x*x*x)+m2*(x*x*x*x)+m3*(x*x*x)+m4*(x*x)+m5*x+m6;
}

void dih(HWND hList,HWND hList2)
{
	//МЕТОД ДИХОТОМИИ
	TCHAR buf[200]; 
	double x1,x2;
	double a=0.001;			//Левая граница
	double b=0.002;			//Правая граница
	double E=0.000001;		//Заданная точность
	double d=0.00000002;	//Параметр метода
	int n=0;			//Кол-во итераций
	swprintf(buf,TEXT("%-3i║%-7.6f║%-7.6f║%-10c║%-10c║%-12c║%-12c║%-6f"),n,a,b,'*','*','*','*',b-a);
	SendMessage(hList,LB_ADDSTRING,0,(LPARAM)buf);//вывод
	do 
	{	
		n++;
		x1=(a+b-d)/2;
		x2=(a+b+d)/2;
		if (y(x1)<y(x2))//Определение границ нового отрезка неопределённости
			{	a=x1;	}
		else
			{	b=x2;	}
		swprintf(buf,TEXT("%-3i║%-7.6f║%-7.6f║%-10f║%-10f║%-12f║%-12f║%-f"),n,a,b, x1,x2,y(x1),y(x2),b-a);
		SendMessage(hList,LB_ADDSTRING,0,(LPARAM)buf);//вывод
	}while (abs(b-a)>=E);
	double xx=(a+b)/2;//Абсцисса точки минимума
	swprintf(buf,TEXT("%-10.6f║%-10.4f"),xx,y(xx));
	SendMessage(hList2,LB_ADDSTRING,0,(LPARAM)buf);//вывод координат точки минимума
}