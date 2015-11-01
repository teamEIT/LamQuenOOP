using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPForm1
{
    class PhepTinh
    {
        private double numberA;
        private double numberB;

        //Getter Setter numberA
        public double NumberA
        {
            get
            {
                return numberA;
            }

            set
            {
                numberA = value;
            }
        }
        //Getter Setter numberB
        public double NumberB
        {
            get
            {
                return numberB;
            }

            set
            {
                numberB = value;
            }
        }

        public double PhepCong()
        {
            return NumberA + NumberB;
        }

        public double PhepTru()
        {
            return NumberA - NumberB;
        }

        public double PhepNhan()
        {
            return NumberA * NumberB;
        }

        public double PhepChia()
        {
            return NumberA / NumberB;
        }
    }
}
