#include "Time.h"


// Khoi tao mac dinh
Time::Time()
{
	hour = 0;
	minute = 0;
	second = 0;
}
// Khoi tao truyen 1 tham so : hour
Time::Time(int h)
{
	hour = h;
	minute = 0;
	second = 0;
}
// Khoi tao truyen 2 tham so : hour, minute
Time::Time(int h, int m)
{
	hour = h;
	minute = m;
	second = 0;
}
// Khoi tao truyen 3 tham so: hour, minute, second
Time::Time(int h, int m, int s)
{
	hour = h;
	minute = m;
	second = s;
}
// Khoi tao sao chep
Time::Time(const Time &time)
{
	hour = time.hour;
	minute = time.minute;
	second = time.second;
}

Time::~Time()
{
}

void Time::Xuat()
{
	if (hour > 9 && minute > 9 && second > 9)
		cout << hour << " : " << minute << " : " << second << endl;
	else
	{
		cout << setfill('0') << setw(2) << hour << " : ";
		cout << setfill('0') << setw(2) << minute << " : ";
		cout << setfill('0') << setw(2) << second << endl;
	}
}
