using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BT1CS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5;
            //Math.Abs(x);
            //ArrayList arr = new ArrayList();
            //arr.Add("Minh");
            //arr.Add("ten");
            //arr.Add("Quoc");
            //arr.Add(6);
            //arr.Add(9);
            //int size = arr.Count;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write("{0}\n", arr[i]);
            //}
            HocSinh hs1 = new HocSinh();
            hs1.Nhap();
            hs1.NgaySinh.Ngay = 20;
            hs1.Xuat();
            Console.ReadKey();
        }
    }
}
