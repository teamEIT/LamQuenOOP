#include "PhanSo.h"

// Khoi tao mac dinh
PhanSo::PhanSo()
{
	tuSo = 0;
	mauSo = 1;
}

// Khoi tao tham so
PhanSo::PhanSo(int t, int m)
{
	tuSo = t;
	mauSo = m;
}

// Khoi tao sao chep
PhanSo::PhanSo(const PhanSo &ps)
{
	tuSo = ps.tuSo;
	mauSo = ps.mauSo;
}

void PhanSo::Nhap()
{
	cout << "\nNhap tu so :";
	do
	{
		cout << "\Nhap mau so :";
		if (mauSo == 0)
			cout << "\nMau so phai khac 0, moi nhap lai.";
	} while (mauSo == 0);
}

void PhanSo::Xuat()
{
	cout << tuSo << " / " << mauSo << "\n";
}

PhanSo PhanSo::TinhTong(PhanSo x)
{
	PhanSo tong(tuSo * x.mauSo + mauSo * x.tuSo, mauSo * x.mauSo);
	return tong;
}

// Nap chong toan tu +
PhanSo PhanSo::operator+(PhanSo x)
{
	PhanSo tong;
	tong.tuSo = tuSo * x.mauSo + mauSo * x.tuSo;
	tong.mauSo = mauSo * x.mauSo;
	return tong;
}

// Nap chong toan tu -
PhanSo PhanSo::operator-(PhanSo x)
{
	PhanSo hieu;
	hieu.tuSo = tuSo * x.mauSo - mauSo * x.tuSo;
	hieu.mauSo = mauSo * x.mauSo;
	return hieu;
}
PhanSo::~PhanSo()
{
}
