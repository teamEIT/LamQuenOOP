#pragma once
#include <iostream>
using namespace std;
class Diem
{
private:
	int x; // Hoanh do 
	int y; // Tung do
public:
	// Khoi tai mac dinh
	Diem(void); 
	// Khoi tao tham so
	Diem(int, int); 
	// Khoi tao sao chep
	Diem(const Diem &); 
	~Diem(void); // Huy
	void Nhap();
	void Xuat();
	int Getter_X();
	int Getter_Y();
	void Setter_X(int);
	void Setter_Y(int);
	float TinhKhoangCach(Diem);
};

