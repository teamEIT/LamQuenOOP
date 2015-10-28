#include "SinhVien.h"

// Khoi tao mac dinh
SinhVien::SinhVien(void)
{
	maSoSV = "";
	hoTen = "";
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 1 tham so : mssv
SinhVien::SinhVien(string id)
{
	maSoSV = id;
	hoTen = "";
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 2 tham so : mssv, ho ten
SinhVien::SinhVien(string id, string name)
{
	maSoSV = id;
	hoTen = name;
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 4 tham so : mssv, ho ten, diem lt, diem th
SinhVien::SinhVien(string id, string name, float dlt, float dth)
{
	maSoSV = id;
	hoTen = name;
	dTH = dth;
	dLT = dlt;
}

// Xuat
void SinhVien::Xuat()
{
	cout << "\nMSSV :" << maSoSV;
	cout << "\nHo ten :" << hoTen;
	cout << "\nNgay sinh :";
	ngaySinh.Xuat();
	cout << "\nDiem LT :" << dLT;
	cout << "\nDiem TH :" << dTH << endl;
}
SinhVien::~SinhVien(void)
{
}
