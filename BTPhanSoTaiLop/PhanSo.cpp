#include "PhanSo.h"

PhanSo::PhanSo(void)
{
	tuSo = 0;
	mauSo = 1;
}

PhanSo::PhanSo(int t, int m)
{
	tuSo = t;
	mauSo = m;
}
PhanSo::PhanSo(int t)
{
	tuSo = t;
	mauSo = 1;
}
PhanSo::PhanSo(const PhanSo &ps)
{
	tuSo = ps.tuSo;
	mauSo = ps.mauSo;
}


PhanSo::~PhanSo(void)
{
}
void PhanSo::Xuat()
{
	cout << tuSo << "/" << mauSo << endl;
}
PhanSo PhanSo::CongPhanSo(PhanSo ps)
{
	PhanSo phanSoTong;
	phanSoTong.tuSo = tuSo * ps.mauSo + mauSo * ps.tuSo;
	phanSoTong.mauSo = mauSo * ps.mauSo;
	return phanSoTong;
}