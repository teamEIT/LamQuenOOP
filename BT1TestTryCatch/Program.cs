using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1TestTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Nhap:
            try {
                Console.Write("\nNhap x = ");
                x = int.Parse(Console.ReadLine());
            }
            catch {
                Console.Write("\nDu lieu sai, nhap lai.");
                goto Nhap;
            }
        }
    }
}
