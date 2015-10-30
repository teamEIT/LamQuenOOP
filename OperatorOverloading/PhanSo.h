#pragma once
#include <iostream>
using namespace std;
class PhanSo
{
private:
	int mauSo;
	int tuSo;
public:
	// Khoi tao mac dinh
	PhanSo();
	// Khoi tao truyen 2 tham so
	PhanSo(int, int);
	// Khoi tao sao chep
	PhanSo(const PhanSo &);
	// Nhap
	void Nhap();
	// Xuat
	void Xuat();
	// Tinh tong
	PhanSo TinhTong(PhanSo); // a.TinhTong(b)
	// Nap chong toan tu +
	PhanSo operator +(PhanSo);
	// Nap chong toan tu -
	PhanSo operator -(PhanSo);
	// Nap chong toan tu *
	PhanSo operator *(PhanSo);
	// Nap chong toan tu /
	PhanSo operator /(PhanSo);
	~PhanSo();
};

