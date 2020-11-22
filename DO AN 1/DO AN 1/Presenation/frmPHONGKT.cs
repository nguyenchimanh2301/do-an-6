using System;
using System.Collections.Generic;
using System.Text;
using DO_AN_1.Business.BLL;
using DO_AN_1.Business;
using DO_AN_1.Entities;
namespace DO_AN_1.Presenation
{
    class frmPHONGKT
    {
        Bphongkt frmP = new Bphongkt();
        GD gd = new GD(100, 45);
        public void menuphong()
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
                gd.pain("CÁC THAO TÁC QUẢN LÍ PHÒNG KÍ TÚC", 30, 9);
                gd.pain("F1", 9, 12); gd.pain("THÊM TẦNG KÍ TÚC", 60, 12);
                gd.pain("F2", 9, 15); gd.pain("XÓA PHÒNG KÍ TÚC", 60, 15);
                gd.pain("F3", 9, 18); gd.pain("HIỆN THÔNG TIN", 60, 18);
                gd.pain("F4", 9, 21); gd.pain("TRỞ LẠI", 60, 21);
                ConsoleKeyInfo kt = Console.ReadKey();
                switch (kt.Key)
                {
                    case ConsoleKey.F1: Console.Clear(); themt(); break;
                    case ConsoleKey.F5: Console.Clear(); menuphong(); break;
                    //case ConsoleKey.F3: Console.Clear(); hient(); break;
                    default:
                        return;
                }
            }
        public void themt()
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
                Console.SetCursorPosition(9, 12); Console.WriteLine("Nhập mã phòng");

                Console.SetCursorPosition(50, 12); maph = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20,40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto maph;
            }

        tenday: gd.pain("", 50, 15); string tenday;
            try
            {
                Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập ten day");
                Console.SetCursorPosition(50,15); tenday = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto tenday;
            }
        slmax: gd.pain("", 50, 18); int slmax;
            try
            {
                Console.SetCursorPosition(9, 18); Console.WriteLine("Nhập sl hoc sinh max");
                Console.SetCursorPosition(50,18); slmax = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto slmax;
            }
        dango: gd.pain("", 50, 21); int dango;
            try
            {
                Console.SetCursorPosition(9, 21); Console.WriteLine("Nhập sl hoc sinh đang ở");
                Console.SetCursorPosition(50,21); dango = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu là chữ,mời nhập lại");
                goto dango;
            }
        tinhtrang: gd.pain("", 50, 24); string tinhtrang;
            try
            {
                Console.SetCursorPosition(9, 24); Console.WriteLine("Cho biết trạng thái của  phòng");
                Console.SetCursorPosition(50,24); tinhtrang = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu ,mời nhập lại");
                goto tinhtrang;
            }
        
        }
//            public void hient()
//            {
//                for (int i = 8; i < 19; ++i)
//                {
//                    gd.pain("║", 7, i);
//                    gd.pain("║", 92, i);

//                }

//                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
//                gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
//                gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);

//                for (int i = 11; i < 19; ++i)
//                {

//                    gd.pain("║", 39, i);
//                }
//                gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 19);

//                gd.pain("TÊN TẦNG ", 9, 12); Console.SetCursorPosition(50, 12); Console.WriteLine(tentang);
//                gd.pain("SÔ PHÒNG", 9, 15); Console.SetCursorPosition(50, 15); Console.WriteLine(slp + "phòng");
//                Tangkt t = new Tangkt(tentang, slp);
//                ConsoleKeyInfo kt = Console.ReadKey();
//                switch (kt.Key)
//                {
//                    case ConsoleKey.Enter: Console.Clear(); btang.them(t); break;
//                    case ConsoleKey.Tab: Console.Clear(); menutangkt(); break;
//                    default:
//                        return;
    }
}