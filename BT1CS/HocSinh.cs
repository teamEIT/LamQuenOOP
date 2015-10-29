using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1CS
{
    class HocSinh
    {
        // Khai bao thuoc tinh
        private string maSo, hoTen;
        private double dToan, dLy, dHoa;
        private Date ngaySinh = new Date();

        internal Date NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public void Nhap()
        {
            Console.Write("\nNhap ma so :");
            this.maSo = Console.ReadLine();

            Console.Write("\nNhap ho ten :");
            this.hoTen = Console.ReadLine();

            Console.Write("\nNhap ngay sinh :");
            NgaySinh.Nhap();

            // Diem toan
            while (true)
            {
                try
                {
                    Console.Write("\nNhap diem toan :");
                    dToan = double.Parse(Console.ReadLine());
                    if (dToan < 0 || dToan > 10)
                    {
                        Console.Write("\nDiem Toan phai nam trong doan tu 0 toi 10 . ");
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

            // Diem ly
            while (true)
            {
                try
                {
                    Console.Write("\nNhap diem ly :");
                    dLy = double.Parse(Console.ReadLine());
                    if (dLy < 0 || dLy > 10)
                    {
                        Console.Write("\nDiem ly phai nam trong doan tu 0 toi 10 . ");
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

            // Diem hoa
            while (true)
            {
                try
                {
                    Console.Write("\nNhap diem hoa :");
                    dHoa = double.Parse(Console.ReadLine());
                    if (dHoa < 0 || dHoa > 10)
                    {
                        Console.Write("\nDiem hoa phai nam trong doan tu 0 toi 10 . ");
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
            Console.Write("\nMa so : {0}", this.maSo);
            Console.Write("\nHo ten :" + hoTen);
            Console.Write("\nSinh Ngay :");
            NgaySinh.Xuat();
            Console.Write("\nDiem toan : {0}", this.dToan);
            Console.Write("\nDiem ly : {0}", this.dLy);
            Console.Write("\nDiem hoa : {0} \n", this.dHoa);
        }
        // Tinh diem trung binh
        public double TinhDiemTrungBinh()
        {
            return (dHoa + dLy + dToan) / 3;
        }
    }
}
