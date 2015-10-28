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
