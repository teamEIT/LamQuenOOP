#pragma once
#include <iostream>
using namespace std;
class Ngay
{
private:
	int ngay, thang, nam;
public:
	// Khoi tao mac dinh
	Ngay(void);
	// Khoi tao co tham so
	// Nam, thang, ngay
	Ngay(int, int, int); 
	// Khoi tao sao chep
	Ngay(const Ngay &);
	// Ham huy
	~Ngay(void);
	void Xuat();
};

