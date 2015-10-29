#include "SinhVien.h"

int main()
{
	SinhVien sv1;
	sv1.Xuat();
	SinhVien sv2("0913084");
	sv2.Xuat();
	SinhVien sv3("0913084", "Le Hoang Anh Quoc");
	sv3.Xuat();
	SinhVien sv4("0913084", "Le Hoang Anh Quoc", 7, 8);
	sv4.Xuat();
	Ngay ngaySinh(1990, 4, 14);
	SinhVien sv5("0913084", "Le Hoang Anh Quoc", ngaySinh);
	sv5.Xuat();
	SinhVien sv6("0913084", "Le Hoang Anh Quoc", 1990, 4, 14, 9, 9.5);
	sv6.Xuat();
	SinhVien sv7(sv5);
	sv7.Xuat();
	system("pause");
	return 0;
}