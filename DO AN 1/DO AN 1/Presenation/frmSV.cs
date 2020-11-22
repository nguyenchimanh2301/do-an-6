using System;
using System.Collections.Generic;
using System.Text;
using DO_AN_1.Business.BLL;
using DO_AN_1.Business;
using DO_AN_1.DataAccessLayer.composn;
using DO_AN_1.DataAccessLayer;
using DO_AN_1.Entities;

namespace DO_AN_1.Presenation
{
    class frmSV
    {
        Bsinhvien sv  = new Bsinhvien();
        GD gd = new GD(100, 55);
            public void menuSV()
            {
                for (int i = 8; i < 22; ++i)
                {

                    gd.pain("║", 7, i);
                    gd.pain("║", 92, i);
                }

                gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╣", 7, 7);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
                gd.pain("╠═══════════════════════════════╦═══════════════════════════════════════════════════╣", 7, 13);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);

                for (int i = 11; i < 22; ++i)
                {

                    gd.pain("║", 39, i);
                }
                gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 22);
                gd.pain("CÁC THAO TÁC QUẢN LÍ SINH VIÊN", 30, 9);
                gd.pain("F1", 9, 12); gd.pain("THÊM SINH VIÊN", 60, 12);
                gd.pain("F2", 9, 15); gd.pain("XÓA SINH VIÊN", 60, 15);
                gd.pain("F2", 9, 15); gd.pain("SỬA THÔNG TIN SINH VIÊN", 60, 15);
                gd.pain("F3", 9, 18); gd.pain("HIỆN THÔNG TIN", 60, 18);
                gd.pain("F4", 9, 21); gd.pain("TRỞ LẠI", 60, 21);
              menuSV:
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1: Console.Clear(); themsv(); break;
                    case ConsoleKey.F5: Console.Clear(); menuSV(); break;
                    //case ConsoleKey.F3: Console.Clear(); hient(); break;
                    default:
                    Console.WriteLine("SAI THAO TÁC!!MỜI NHẬP LẠI");
                    goto menuSV;
                }
            }
            public void themsv()
            {

                for (int i = 8; i < 25; ++i)
                {
                    gd.pain("║", 7, i);
                    gd.pain("║", 92, i);

                }
                gd.pain("╠════════════════════════════════════════════════════════════════════════════════════╣", 7, 7);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
                gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 19);
                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 22);

                for (int i = 8; i < 25; ++i)
                {

                    gd.pain("║", 39, i);
                }
                gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 25);
            maph: gd.pain("", 60, 9); string maph;
                try
                {
                    Console.SetCursorPosition(9, 12); Console.WriteLine("Nhập mã phòng đang ở");

                    Console.SetCursorPosition(50, 12); maph = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu mời nhập lại");
                    goto maph;
                }

            masv: gd.pain("", 50, 15); string masv;
                try
                {
                    Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập mã sinh viên");
                    Console.SetCursorPosition(50, 15); masv = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có thông tin mời nhập lại");
                    goto masv;
                }
            tensv: gd.pain("", 50, 18); string tensv;
                try
                {
                    Console.SetCursorPosition(9, 18); Console.WriteLine("Nhập tên sinh viên");
                    Console.SetCursorPosition(50, 18); tensv = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu,mời nhập lại");
                    goto tensv;
                }
            diachi: gd.pain("", 50, 21); string diachi;
                try
                {
                    Console.SetCursorPosition(9, 21); Console.WriteLine("Nhập địa chỉ sinh viên");
                    Console.SetCursorPosition(50, 21); diachi=Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu,mời nhập lại");
                goto diachi;
                }
            sdt: gd.pain("", 50, 24); string sdt;
                try
                {
                    Console.SetCursorPosition(9, 24); Console.WriteLine("cho biết số điện thoại");
                    Console.SetCursorPosition(50, 24); sdt = Console.ReadLine();
                }
                catch
                {
                    Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                    goto sdt;
                }

            }
        }
    }

