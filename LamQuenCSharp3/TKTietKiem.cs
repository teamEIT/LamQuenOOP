using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LamQuenCSharp3
{
    public class TKTietKiem
    {
        private double laiSuat;
        private string maSoTK;
        private int soTien;

        public TKTietKiem()
        {
            throw new System.NotImplementedException();
        }

        public TKTietKiem(string id, int sTien)
        {
            this.AccountNumber = id;
            this.Savings = sTien;
        }

        public string AccountNumber
        {
            get
            {
                return this.maSoTK;
            }

            set
            {
                this.maSoTK = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return this.laiSuat;
            }

            set
            {
                this.laiSuat = value;
            }
        }

        public int Savings
        {
            get
            {
                return this.soTien;
            }

            set
            {
                this.soTien = value;
            }
        }

        static public void LoiChao()
        {
            Console.Write("Xin chao, ban đang gui tien vao Ngan hang ...");
        }

        public void Xuat()
        {
            Console.Write("\nTai khoan co ma so {0} co {1}, co lai suat {2} .", this.AccountNumber, this.Savings, this.InterestRate);
        }
    }
}