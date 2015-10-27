#pragma once
#include <iostream>
using namespace std;
class PhanSo
{
private:
	int tuSo;
	int mauSo;
public:
	// Khoi tao mac dinh
	PhanSo(void);
	// Khoi tao truyen 2 tham so
	PhanSo(int, int);
	// Khoi tao truyen 1 tham so
	PhanSo(int);
	// Khoi tao sao chep
	PhanSo(const PhanSo &);
	// Ham huy
	~PhanSo(void);
	void Xuat();
	PhanSo CongPhanSo(PhanSo);
};

