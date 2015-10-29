using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1CS
{
    class Date
    {
        private int ngay, thang, nam;
        // Khoi tao mac dinh
        public Date()
        {
            ngay = thang = nam = 1;
        }
        // Khoi tao truyen 3 tham so
        public Date(int day, int month, int year)
        {
            ngay = day;
            thang = month;
            nam = year;
        }
        // Khoi tao sao chep
        public Date(Date x)
        {
            ngay = x.ngay;
            thang = x.thang;
            nam = x.nam;
        }

        // getter setter ngay 
        public int Ngay
        {
            get
            {
                return ngay;
            }

            set
            {
                ngay = value;
            }
        }
        // Ham nhap
        public void Nhap()
        {
            // Ngay
            while (true)
            {
                try
                {
                    Console.Write("\nNhap ngay :");
                    Ngay = int.Parse(Console.ReadLine());
                    if (Ngay < 1 || Ngay > 31)
                    {
                        Console.Write("\nNgay phai nam trong doan tu 1 toi 31 . ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write("\nDu lieu khong hop le .");
                }
            }
            // Thang
            while (true)
            {
                try
                {
                    Console.Write("\nNhap thang :");
                    thang = int.Parse(Console.ReadLine());
                    if (thang < 1 || thang > 12)
                    {
                        Console.Write("\nThang phai nam trong doan tu 1 toi 12 . ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write("\nDu lieu khong hop le .");
                }
            }
            // Nam
            while (true)
            {
                try
                {
                    Console.Write("\nNhap nam :");
                    nam = int.Parse(Console.ReadLine());
                    if (nam < 0)
                    {
                        Console.Write("\nNam phai lon hon 0 . ");
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.Write("\nDu lieu khong hop le .");
                }
            }
        }
        // Ham xuat
        public void Xuat()
        {
            Console.Write("{0} / {1} / {2}", Ngay, thang, nam);
        }
    }
}
