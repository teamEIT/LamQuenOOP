#include "Diem.h"

// Khoi tao mac dinh
Diem::Diem(void)
{
	x = y = 0;
}
// Khoi tao truyen tham so
Diem::Diem(int nx, int ny)
{
	x = nx;
	y = ny;
}
// Khoi tao sao chep
Diem::Diem(const Diem &a)
{
	x = a.x;
	y = a.y;
}
// Ham huy
Diem::~Diem(void)
{
	// Rong do khong su dung con tro
}

void Diem::Nhap()
{
	cout << "\nNhap hoanh do :";
	cin >> x;
	cout << "\nNhap tung do :";
	cin >> y;
}
void Diem::Xuat()
{
	cout << "Toa do diem : ( " << x << ", " << y << ")\n"; 
}

int Diem::Getter_X()
{
	return x;
}

int Diem::Getter_Y()
{
	return y;
}

void Diem::Setter_X(int nx)
{
	x = nx;
}

void Diem::Setter_Y(int ny)
{
	y = ny;
}

float Diem::TinhKhoangCach(Diem diem)
{
	return sqrt(pow(x - diem.x, 2) + pow(y - diem.y, 2));
}