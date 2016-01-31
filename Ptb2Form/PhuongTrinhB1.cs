using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PtForm
{
    class PhuongTrinhB1
    {
        public string GiaiPTB1(double a, double b)
        {
            string s;
            if (a == 0)
                if (b == 0)
                    s = "Phương trình vô số nghiệm";
                else
                    s = "Phương trình vô nghiệm";
            else
                s = (-b / a).ToString();
            return s;
        }
    }
}
