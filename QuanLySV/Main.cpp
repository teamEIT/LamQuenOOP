#include <iostream>
#include <string>
using namespace std;

class Ngay {
private:
	int ngay, thang, nam;
public:
	void Nhap() {
		cout << "\nNhap ngay :";
		cin >> ngay;
		cout << "\nNhap thang :";
		cin >> thang;
		cout << "\nNhap nam :";
		cin >> nam;
	}
	void Xuat() {
		cout << "\nNgay " << ngay << "Thang " << thang << "Nam " << nam;
	}
};
class HocSinh {
	// Thuộc tính (dữ liệu)
private:
	string hoTen;
	float dToan, dVan;
	Ngay ngaySinh;
	// Phương thức
public:
	void Nhap() {
		fflush(stdin);
		cout << "\nNhap ho ten :";
		getline(cin, this->hoTen); // Con trỏ this trỏ đến các thuộc tính của lớp
		cout << "\nNhap diem toan :";
		cin >> this->dToan;
		cout << "\nNhap diem van :";
		cin >> this->dVan;
		cout << "\nNhap ngay sinh :";
		ngaySinh.Nhap();
	}
	void Xuat() {
		cout << "\nHo ten :" << hoTen;
		cout << "\nDiem toan :" << dToan;
		cout << "\nDiem van :" << dVan;
		cout << "\nSinh ngay :";
		ngaySinh.Xuat();
	}
	float TinhTrungBinh() {
		return (dToan + dVan) / 2;
	}
};
class Lop {
	
};

int main() {
	HocSinh hocSinhA;
	float dtb;
	hocSinhA.Nhap();
	hocSinhA.Xuat();
	dtb = hocSinhA.TinhTrungBinh();
	cout << "\nDiem trung binh :" << dtb;
	cout << "\n";
	system("pause");
	return 0;
}