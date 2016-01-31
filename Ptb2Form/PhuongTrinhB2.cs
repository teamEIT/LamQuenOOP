using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtForm
{
    class PhuongTrinhB2 : PhuongTrinhB1
    {
        public string GiaiPTB2(double a, double b, double c)
        {
            string s;
            double delta, x1, x2;
            if (a != 0)
            {
                delta = b * b - 4 * a * c;
                if (delta == 0)
                {
                    s = "Phương trình có nghiệm: " + ((-b) / (2 * a)).ToString();
                }
                else if (delta > 0)
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                    s = "Phương trình có nghiệm: " + "\r\n" + "x1 = " + x1.ToString() + "\r\n" + "x2 = "
                    + x2.ToString();
                }

                else
                    s = "Phương trình vô nghiệm.";
            }
            else
            {
                if (b == 0)
                    if (c == 0)
                        s = "Phương trình vô số nghiệm.";
                    else
                        s = "Phương trình vô nghiệm.";
                else
                    s = "Phương trình có nghiệm: " + (-c / b).ToString();
            }
            return s;
        }
        
    }
}
