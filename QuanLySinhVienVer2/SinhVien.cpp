#include "SinhVien.h"

/*
	Cú pháp:
	<kiểu dữ liệu> <tên lớp> :: <tên phương thức>
*/
bool KiemTraDuLieu(string chuoi);

void SinhVien :: Nhap() {
	fflush(stdin);
	cout << "\nNhap ho ten :";
	getline(cin, name);
NhapLaiToan:
	cout << "\nNhap diem toan :";
	//cin >> dToan;
	float diemToan;
	getline(cin, dToan);
	if(!KiemTraDuLieu(dToan)) {
		cout << "\nDiem khong hop le.";
		goto NhapLaiToan;
	} else {
		diemToan = atof((char *)dToan.c_str());
		if(diemToan < 0 || diemToan > 10) {
			cout << "\nDiem toan khong hop le, kiem tra lai.";
			goto NhapLaiToan;
		}
	}
NhapLaiVan:
	cout << "\nNhap diem van :";
	//cin >> dVan;
	float diemVan;
	getline(cin, dVan);
	if(!KiemTraDuLieu(dVan)) {
		cout << "\nDiem khong hop le.";
		goto NhapLaiVan;
	} else {
		diemVan = atof((char *)dVan.c_str());
		if(diemVan < 0 || diemVan > 10) {
			cout << "\nDiem van khong hop le, kiem tra lai.";
			goto NhapLaiVan;
		}
	}

	cout << "\nNhap ngay sinh :";
	ngaySinh.Nhap();
}

void SinhVien :: Xuat() {
	cout << "\nHo ten :" << name;
	cout << "\nDiem toan: " << dToan;
	cout << "\nDiem van :" << dVan;
	cout << "\nNgay sinh :";
	ngaySinh.Xuat();
}

float SinhVien :: TinhDiemTrungBinh() {
	float diemToan = atof((char *)dToan.c_str());
	float diemVan = atof((char *)dVan.c_str());
	return (diemToan + diemVan) / 2;
}
bool KiemTraDuLieu(string chuoi) {
	//Kiểm tra chuỗi có phải số thực ?
	int length = chuoi.length();
	int dem = 0;
	for(int i = 0; i < length; i++) {
		if((chuoi[i] < '0' || chuoi[i] > '9') && chuoi[i] != '.') {
			return false;	
		}
		if(chuoi[i] == '.') {
			dem++;
			if(dem == 2) {
				return false;
			}
		}
	}
	return true;
}