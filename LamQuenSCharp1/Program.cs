using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamQuenSCharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVien sv1 = new SinhVien();
            sv1.Name = "Quoc";
            sv1.Nhap();
            sv1.Xuat();
        }
    }
}
