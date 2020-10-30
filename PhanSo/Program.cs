using System;

namespace PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo phanso1 = new PhanSo(1, 2);
            PhanSo phanso2 = new PhanSo(1, 3);
            DanhSachPhanSo danhsachphanso = new DanhSachPhanSo();
            Console.WriteLine(phanso2.ToString());
            Console.WriteLine(phanso1.Equals(phanso2));
            danhsachphanso.themPhanSo(phanso1);
            danhsachphanso.themPhanSo(phanso2);
            danhsachphanso.xoaPhanSo(phanso1);
            danhsachphanso.capNhatPhanSo(phanso2, phanso1);
            Console.WriteLine(danhsachphanso.ToString());
        }
    }
}
