#include "PhanSo.h"

int main()
{
	PhanSo a(1, 2), b(3, 4), c(5, 6), d(7, 8);
	int n = 5;
	PhanSo kq = a + n;
	//PhanSo tong = a.TinhTong(b).TinhTong(c).TinhTong(d);
	PhanSo tong = a + b + c + d;
	cout << "\na + b + c + d = ";
	tong.Xuat();
	PhanSo hieu = a - b - c - d;
	cout << "\na - b - c - d = ";
	hieu.Xuat();
	return 0;
}