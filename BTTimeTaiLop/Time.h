#pragma once
#include <iostream>
#include <iomanip>
using namespace std;
class Time
{
private:
	int hour, minute, second;
public:
	// Khoi tao mac dinh
	Time();
	// Khoi tao truyen 1 tham so: hour
	Time(int);
	// Khoi tao truyen 2 tham so: hour, minute
	Time(int, int);
	// Khoi tao truyen 3 tham so: hour, minute, second
	Time(int, int, int);
	// Khoi tao sao chep
	Time(const Time &);
	// Ham huy
	~Time();
	// Xuat
	void Xuat();
};

