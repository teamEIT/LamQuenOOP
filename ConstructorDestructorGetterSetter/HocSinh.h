#pragma once
#include <iostream>
#include <string>
using namespace std;

class HocSinh
{
private:
	string hoTen;
	float *diemThi;
public:
	// Constructor mặc định
	HocSinh(void);
	// Constructor đầu vào tùy ý
	HocSinh(string ten, float diem);
	// Constructor sao chep
	HocSinh(const HocSinh &hs);
	// Destructor
	~HocSinh();
	void Nhap();
	void Xuat();
	void ThayDoi();
	void InDiaChi();
	string Getter_Ten();
	void Setter_Ten(string ten);
};



