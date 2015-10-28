#include "Ngay.h"

// Khoi tao mac dinh
Ngay::Ngay(void)
{
	ngay = 1;
	thang = 1;
	nam = 1990;
}

// Khoi tao tham so : nam, thang, ngay
Ngay::Ngay(int year, int month, int day)
{
	nam = year;
	thang = month;
	ngay = day;
}

// Khoi tao sao chep
Ngay::Ngay(const Ngay &date)
{
	nam = date.nam;
	thang = date.thang;
	ngay = date.ngay;
}

// Ham huy
Ngay::~Ngay(void)
{
}

// Xuat
void Ngay::Xuat()
{
	cout << "\nNam " << nam << " thang " << thang << " ngay " << ngay << endl;
}

int Ngay::Getter_Ngay()
{
	return ngay;
}

void Ngay::Setter_Ngay(int day)
{
	ngay = day;
}

int Ngay::Getter_Thang()
{
	return thang;
}

void Ngay::Setter_Thang(int month)
{
	thang = month;
}

int Ngay::Getter_Nam()
{
	return nam;
}

void Ngay::Setter_Nam(int year)
{
	nam = year;
}
