using System;
using DO_AN_1.Business;
using DO_AN_1.DataAccessLayer;
using DO_AN_1.Presenation;
using DO_AN_1.Business.BLL;
using DO_AN_1.Entities;
namespace DO_AN_1.Presenation
{

    class frmTANGKT
    {
        GD gd = new GD(100, 45);
        Btangkt btang = new Btangkt();

        public void menutangkt()
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
            gd.pain("CÁC THAO TÁC QUẢN LÍ TẦNG KÍ TÚC", 30, 9);
            gd.pain("F1", 9, 12); gd.pain("THÊM TẦNG KÍ TÚC", 60, 12);
            gd.pain("F2", 9, 15); gd.pain("SỐ PHÒNG KÍ TÚC", 60, 15);
            gd.pain("F3", 9, 18); gd.pain("HIỆN THÔNG TIN", 60, 18);
            gd.pain("F4", 9, 21); gd.pain("TRỞ LẠI", 60, 21);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.F1: Console.Clear(); themt(); break;
                case ConsoleKey.F4: Console.Clear(); menutangkt(); break;
            /*    case ConsoleKey.F3: Console.Clear(); hient(); break*/;
                default:
                    return;
            }
        }
        public void themt()
        {

            for (int i = 8; i < 19; ++i)
            {
                gd.pain("║", 7, i);
                gd.pain("║", 92, i);

            }

            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
            gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
            gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);

            for (int i = 11; i < 19; ++i)
            {

                gd.pain("║", 39, i);
            }
            gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 19);

        tentang: gd.pain("", 60, 9); string tentang;
            try
            {
                Console.SetCursorPosition(9, 12); Console.WriteLine("Nhập tên tầng");

                Console.SetCursorPosition(50, 12); tentang = Console.ReadLine();
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("khong co thong tin mi nhap lai");
                goto tentang;
            }

        slp: gd.pain("", 50, 15); int slp;
            try
            {
                Console.SetCursorPosition(9, 15); Console.WriteLine("Nhập số lượng phòng");
                Console.SetCursorPosition(50, 15); slp = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.SetCursorPosition(20, 40); Console.WriteLine("không có dữ liệu hoặc dữ liệu sai mời nhập lại");
                goto slp;
            }
            Tangkt t = new Tangkt(tentang, slp);
            gd.pain("ẤN ENTER ĐỂ THÊM TẦNG KÍ TÚC", 35, 27);
            gd.pain("ẤN TAB ĐỂ QUAY LẠI GIAO DIỆN TẦNG ", 35, 28);
            ConsoleKeyInfo kt = Console.ReadKey();
            switch (kt.Key)
            {
                case ConsoleKey.Enter:
                    Console.Clear(); btang.them(t);
                    Console.Clear(); menutangkt(); break;
                default:
                    return;

            }

        }
    }
}
    //    public void hient()
    //    {
    //        for (int i = 8; i < 19; ++i)
    //        {
    //            gd.pain("║", 7, i);
    //            gd.pain("║", 92, i);

    //        }

    //        gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 10);
    //        gd.pain("╠═══════════════════════════════╬════════════════════════════════════════════════════╣", 7, 13);
    //        gd.pain("╠═══════════════════════════════╦════════════════════════════════════════════════════╣", 7, 16);

    //        for (int i = 11; i < 19; ++i)
    //        {

    //            gd.pain("║", 39, i);
    //        }
    //        gd.pain("╠═══════════════════════════════╩════════════════════════════════════════════════════╣", 7, 19);

    //        gd.pain("TÊN TẦNG ", 9, 12); Console.SetCursorPosition(50, 12); Console.WriteLine(tentang);
    //        gd.pain("SÔ PHÒNG", 9, 15); Console.SetCursorPosition(50,15); Console.WriteLine(slp+"phòng");
           
    //        ConsoleKeyInfo kt = Console.ReadKey();
    //        switch (kt.Key)
    //        { 
    //            case ConsoleKey.Tab: Console.Clear(); menutangkt(); break;
    //            default:
    //                return;

    //        }
    //    }
    //}
    
//}
