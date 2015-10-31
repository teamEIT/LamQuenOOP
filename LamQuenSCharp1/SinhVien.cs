using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamQuenSCharp1
{
    public class SinhVien
    {
        private double dToan;
        private int dLy;
        private string hoTen;
        private string maSo;
        private Ngay ngaySinh;

        public string ID
        {
            get
            {
                return maSo;
            }

            set
            {
                maSo = value;
            }
        }

        public string Name
        {
            get
            {
                return hoTen;
            }

            set
            {

                hoTen = value;
            }
        }

        public void Nhap()
        {
            Console.Write("\nNhap ten: ");
            Name = Console.Read().ToString();
        }

        public void Xuat()
        {
            Console.WriteLine("\nHo ten :" + Name);
        }

        public double TinhDiemTrungBinh()
        {
            throw new System.NotImplementedException();
        }
    }
}