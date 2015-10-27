#include "PhanSo.h"

int main()
{
	PhanSo ps1;
	ps1.Xuat();
	PhanSo ps2(1, 2);
	ps2.Xuat();
	PhanSo ps3(3, 4);
	ps3.Xuat();
	PhanSo ps4(3);
	ps4.Xuat();
	PhanSo ps5(-5);
	ps5.Xuat();
	PhanSo ps6(ps3);
	ps6.Xuat();
	ps1 = ps2.CongPhanSo(ps3);
	ps1.Xuat();
	system("pause");
	return 0;
}