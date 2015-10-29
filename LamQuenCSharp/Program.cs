using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamQuenCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
        DoAgain:
            Console.Write("\nNhap x : ");
            
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Write("\nKieu du lieu khong hop le, moi kiem tra lai.");
                goto DoAgain;
            }
            if (x < 0)
                goto DoAgain;
            Console.Write("\nx = {0}", x);
            // Double: kieu du lieu cua C# form
            // double: kieu du lieu cua c# console
            Console.ReadKey();
        }
    }
}
