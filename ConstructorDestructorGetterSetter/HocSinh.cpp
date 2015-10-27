#include "HocSinh.h"

// Constructor mặc định
HocSinh::HocSinh(void)
{
	hoTen = "Nguyen Van Thanh";
	diemThi = new float;
	*diemThi = 8.75;
}

// Constructor đầu vào tùy ý
HocSinh::HocSinh(string ten, float diem)
{
	hoTen = ten;
	diemThi = new float;
	*diemThi = diem;
}
// Constructor sao chep
HocSinh::HocSinh(const HocSinh &hs)
{
	hoTen = hs.hoTen;
	diemThi = new float; // tao vung nho khac
	*diemThi = *hs.diemThi;
}
// Destructor
HocSinh::~HocSinh()
{
	cout <<"\nHam huy chay.";
	delete diemThi;
}
//void HocSinh::Nhap()
//{
//	cout << "\nNhap ten :";
//	getline(cin, hoTen);
//	cout << "\nNhap diem :";
//	cin >> diemThi;
//}

void HocSinh::Xuat()
{
	cout << "\nHo ten :" << hoTen;
	cout << "\nDiem thi :" << *diemThi << endl;
}
void HocSinh::ThayDoi()
{
	(*diemThi)--;
}
void HocSinh::InDiaChi()
{
	cout << "\nDia chi:" << &diemThi;
	cout << "\nMien gia tri :" << diemThi << endl;
}
string HocSinh::Getter_Ten()
{
	return hoTen;
}
void HocSinh::Setter_Ten(string ten)
{
	hoTen = ten;
}