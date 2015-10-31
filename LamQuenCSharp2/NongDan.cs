using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamQuenCSharp2
{
    public class NongDan
    {
        private byte capDo;
        private string hoTen;
        private int nangLuong;

        // Constructor 3 tham so hten, nluong, cdo
        public NongDan(string hten, int nluong, byte cdo)
        {
            this.Name = hten;
            this.Power = nluong;
            this.Level = cdo;
        }

        public NongDan()
        {
            throw new System.NotImplementedException();
        }

        public byte Level
        {
            get
            {
                return this.capDo;
            }

            set
            {
                capDo = value;
            }
        }

        public string Name
        {
            get
            {
                return this.hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public int Power
        {
            get
            {
                return this.nangLuong;
            }

            set
            {
                nangLuong = value;
            }
        }

        public void LamViec()
        {
            Console.Write("\nNong dan {0} dang lam viec.", this.Name);
        }

        public void ThuHoach()
        {
            Console.Write("\nNong dan {0} dang lam thu hoach nong san.", this.Name);
        }
    }
}