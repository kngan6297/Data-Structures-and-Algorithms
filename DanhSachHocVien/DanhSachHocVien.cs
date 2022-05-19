using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachHocVien
{
    class DanhSachHocVien
    {
        static StudentNode Head = null;
        static void Main(string[] args)
        {
            CreateNode(1, "1", "1",  1);
            PrintList();
        }
        static void CreateNode(int MaSo, string HoTen, string GioiTinh, int DiemTB)
        {
            StudentNode list = new StudentNode(MaSo, HoTen, GioiTinh, DiemTB, null);
            Console.WriteLine("Nhap vao ma so hoc vien: ");
            list.MaSo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vao ho va ten hoc vien: ");
            list.HoTen = Console.ReadLine();
            Console.WriteLine("Nhap vao gioi tinh hoc vien: ");
            list.GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhap vao diem trung binh hoc vien: ");
            list.DiemTB = Convert.ToInt32(Console.ReadLine());
        }
        static void insertHead(int MaSo, string HoTen, string GioiTinh, int DiemTB, StudentNode next)
        {
            StudentNode new_node = new StudentNode(MaSo, HoTen, GioiTinh, DiemTB, null);
            if (Head == null)
            {
                Head = new_node;
            }
            else
            {
                new_node.next = Head;
                Head = new_node;
            }
        }
        static void PrintList()
        {
            StudentNode p = Head;
            while (p != null)
            {
                Console.WriteLine("Ma so hoc vien: " + p.MaSo);
                Console.WriteLine("Ho va ten hoc vien: " + p.HoTen);
                Console.WriteLine("Gioi tinh hoc vien: " + p.GioiTinh);
                Console.WriteLine("Diem trung binh hoc vien: " + p.DiemTB);
                p = p.next;
            }
        }
        static void SearchDTB()
        {

        }
        static void SearchMaxDTB()
        {

        }
        static void CountMale()
        {

        }

    }
}
