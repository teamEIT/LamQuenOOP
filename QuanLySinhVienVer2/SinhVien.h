#pragma once
#include "Ngay.h"
#include <string>

using namespace std;
class SinhVien
{
private:
	string name;
	string dToan, dVan;
	Ngay ngaySinh;
public:
	void Nhap();
	void Xuat();
	float TinhDiemTrungBinh();
};

