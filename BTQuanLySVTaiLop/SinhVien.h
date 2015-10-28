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
	// Khoi tao truyen 4 tham so : mssv, ho ten, diem lt, diem th
	SinhVien(string, string, float, float);
	// Xuat
	void Xuat();
	// Ham huy
	~SinhVien(void);
};

