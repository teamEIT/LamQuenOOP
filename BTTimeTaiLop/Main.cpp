#include "Time.h"

int main()
{
	Time t1;
	t1.Xuat();
	Time t2(7);
	t2.Xuat();
	Time t3(7, 30);
	t3.Xuat();
	Time t4(8, 12, 56);
	t4.Xuat();
	Time t5(t2);
	t5.Xuat();
	Time t6 = t3;
	t6.Xuat();
	return 0;
}