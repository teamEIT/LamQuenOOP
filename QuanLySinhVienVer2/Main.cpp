#include "SinhVien.h"

int main() {
	SinhVien sinhVien1;
	sinhVien1.Nhap();
	sinhVien1.Xuat();
	float dtb = sinhVien1.TinhDiemTrungBinh();
	cout << "\nDiem trung binh :" << dtb;
	system("pause");
	return 0;
}