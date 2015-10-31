using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamQuenCSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            NongDan farmer = new NongDan("Nguyen A", 69, 5);

            farmer.LamViec();

            Console.ReadLine();
        }
    }
}
