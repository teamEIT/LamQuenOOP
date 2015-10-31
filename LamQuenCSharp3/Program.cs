using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamQuenCSharp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //TKTietKiem taiKhoan = new TKTietKiem();
            //taiKhoan.AccountNumber = "";
            TKTietKiem.LoiChao();
            TKTietKiem taiKhoan = new TKTietKiem("07845215", 5000000);
            taiKhoan.Xuat();
            Console.Read();
        }
    }
}
