using System;
using System.Collections.Generic;
using System.Text;

namespace PhanSo
{
    public class PhanSo
    {
        // thuoc tinh va phuong thuc
        private int tuso,mauso;// ctrl + R+ E

        public PhanSo()
        {
            this.Tuso = 0;
            this.Mauso = 1;
        }

        public PhanSo(int tuso, int mauso)
        {
            this.Tuso = tuso;
            this.Mauso = mauso;
        }
        public int Tuso { get => tuso; set => tuso = value; }
        public int Mauso { get => mauso; set => mauso = value; }

        public override bool Equals(object obj)
        {
            ((PhanSo)obj).rutGonPhanSo();
            this.rutGonPhanSo();
            return this.tuso == ((PhanSo)obj).Tuso && this.mauso == ((PhanSo)obj).Mauso;
        }
        public override string ToString()
        {
            this.rutGonPhanSo();
            return this.tuso + "/" + this.mauso;
        }
        public void rutGonPhanSo()
        {
            int usc = Math.USCLN(this.tuso, this.mauso);
            this.tuso = this.tuso / usc;
            this.mauso = this.mauso / usc;
        }
    }
}
