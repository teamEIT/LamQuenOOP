#include "SinhVien.h"

// Khoi tao mac dinh
SinhVien::SinhVien(void)
{
	maSoSV = "";
	hoTen = "";
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 1 tham so : mssv
SinhVien::SinhVien(string id)
{
	maSoSV = id;
	hoTen = "";
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 2 tham so : mssv, ho ten
SinhVien::SinhVien(string id, string name)
{
	maSoSV = id;
	hoTen = name;
	dLT = 10;
	dTH = 10;
}
// Khoi tao truyen 3 tham so : mssv, ngay sinh
SinhVien::SinhVien(string id, string name, Ngay birthDay)
{
	maSoSV = id;
	hoTen = name;
	ngaySinh = birthDay;
	dTH = 10;
	dLT = 10;
}

// Khoi tao truyen 4 tham so : mssv, ho ten, diem lt, diem th
SinhVien::SinhVien(string id, string name, float dlt, float dth)
{
	maSoSV = id;
	hoTen = name;
	dTH = dth;
	dLT = dlt;
}
// Khoi tao truyen 54 tham so : mssv, ho ten, ngay sinh, diem lt, diem th
SinhVien::SinhVien(string id, string name, Ngay birthDay, float dlt, float dth)
{
	maSoSV = id;
	hoTen = name;
	ngaySinh = birthDay;
	dTH = dlt;
	dLT = dth;
}
// Khoi tao truyen 7 tham so : mssv, ho ten, nam, thang, ngay, diem lt, diem th
SinhVien::SinhVien(string id, string name, int year, int month, int day, float dlt, float dth)
{
	maSoSV = id;
	hoTen = name;
	// Khoi tao gian tiep
	//Ngay Temp(year, month, day);
	//ngaySinh = Temp;
	ngaySinh.Setter_Nam(year);
	ngaySinh.Setter_Thang(month);
	ngaySinh.Setter_Ngay(day);
	dTH = dlt;
	dLT = dth;
}

// Xuat
void SinhVien::Xuat()
{
	cout << "\nMSSV :" << maSoSV;
	cout << "\nHo ten :" << hoTen;
	cout << "\nNgay sinh :";
	ngaySinh.Xuat();
	cout << "\nDiem LT :" << dLT;
	cout << "\nDiem TH :" << dTH << endl;
}
SinhVien::~SinhVien(void)
{
}
