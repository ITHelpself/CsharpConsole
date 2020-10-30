using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace PhanSo
{
    public class DanhSachPhanSo
    {
        private List<PhanSo> danhsachphanso;
        public DanhSachPhanSo()
        {
            danhsachphanso = new List<PhanSo>();
        }
        public override string ToString()
        {
            string result = "";
            foreach (PhanSo phanso in danhsachphanso)
            {
                result += phanso.ToString() + " ";
            }
            return result;
        }
        public void themPhanSo(PhanSo other)
        {
            foreach (PhanSo phanso in danhsachphanso)
            {
                if (phanso.Equals(other))
                {
                    Console.WriteLine("phan so da ton tai trong danh sach");
                    return;
                }
            }
            danhsachphanso.Add(other);
        }
        public void xoaPhanSo(PhanSo other)
        {
            bool coTonTai = false;
            foreach (PhanSo phanso in danhsachphanso)
            {
                if (phanso.Equals(other))
                {
                    danhsachphanso.Remove(other);
                    coTonTai = true;
                    break;
                }
            }
            if (!coTonTai)
            {
                Console.WriteLine("khong co phan so trong danh sach");
            }
        }
        public void capNhatPhanSo(PhanSo phanso,PhanSo other)
        {
            xoaPhanSo(phanso);
            themPhanSo(other);
        }
        public bool timKiemPhanSo(PhanSo other)
        {
            bool coTonTai = false;
            foreach (PhanSo phanso in danhsachphanso)
            {
                if (phanso.Equals(other))
                {
                    danhsachphanso.Remove(other);
                    coTonTai = true;
                }
            }
            return coTonTai;
        }
    }
}
