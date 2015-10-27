#include "Diem.h"

int main()
{
	Diem d1(1, 2);
	Diem d2(5, 8);
	Diem d3;
	Diem d4(d1);
	d1.Xuat();
	d2.Xuat();
	d3.Xuat();
	d4.Xuat();

	float khoangCach = d1.TinhKhoangCach(d2);
	cout << "\nKhoang cach = " << khoangCach << endl;
	system("pause");
	return 0;
}