#include <iostream>
#include "HocSinh.h"
using namespace std;

int main()
{
	HocSinh hs1("Nguyen Thi Thao", 9);
	HocSinh hs2(hs1); // Constructor copy
	hs1.ThayDoi();
	hs1.Xuat();
	hs2.Xuat();
	cout << "hs1 :";
	hs1.InDiaChi();
	cout << "hs2 :";
	hs2.InDiaChi();
	hs1.Setter_Ten("Nguyen Thuy Van");
	cout << "\nTen hs1 :" << hs1.Getter_Ten() << endl;
	system("pause");
	return 0;
}