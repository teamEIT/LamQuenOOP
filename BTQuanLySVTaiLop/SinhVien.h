#pragma once
#include "Ngay.h"
#include <string>

class SinhVien
{
private:
	string maSoSV, hoTen;
	Ngay ngaySinh;
	float dLT, dTH;
public:
	// Khoi tao mac dinh
	SinhVien(void);
	// Khoi tao truyen 1 tham so : mssv
	SinhVien(string);
	// Khoi tao truyen 2 tham so : mssv, ho ten
	SinhVien(string, string);
	// Khoi tao truyen 3 tham so : mssv, ngay sinh
	SinhVien(string, string, Ngay);
	// Khoi tao truyen 4 tham so : mssv, ho ten, diem lt, diem th
	SinhVien(string, string, float, float);
	// Khoi tao truyen 5 tham so : mssv, ho ten, ngay sinh, diem lt, diem th
	SinhVien(string, string, Ngay, float, float);
	// Khoi tao truyen 7 tham so : mssv, ho ten, nam, thang, ngay, diem lt, diem th
	SinhVien(string, string, int, int, int, float, float);
	// Xuat
	void Xuat();
	// Ham huy
	~SinhVien(void);
};

