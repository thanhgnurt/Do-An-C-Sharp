using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Select
    {
        //----điều hướng 
        static void DieuHuong(int select, ref ArrayList ArrayHH)
        {
            switch (select)
            {
                case 0:
                    Add.ThemSanPham(ref ArrayHH);
                    return;
                case 1:
                    Edit.SuaHangHoa(ref ArrayHH);
                    return;
                case 2:
                    Delete.XoaHangHoa(ref ArrayHH);
                    return;
                case 3:
                    Find.TimKiemHangHoa(ref ArrayHH);
                    return;
                case 4:
                    Store.KhoHang(ref ArrayHH);
                    return;
                case 5:
                    return;
            }

        }
        //---Chỉ dẫn
        static void ChiDan()
        {
           
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorTop = 12;
            Console.CursorLeft = 40;
            Console.WriteLine("                                                               ");
            Console.CursorTop = 13;
            Console.CursorLeft = 40;
            Console.WriteLine("                   **       **                          ");
            Console.CursorTop = 14;
            Console.CursorLeft = 40;
            Console.WriteLine("                  ****      **                          ");
            Console.CursorTop = 15;
            Console.CursorLeft = 40;
            Console.WriteLine(" Sử dụng mũi tên ******     **  ,Và phím Enter để chọn. ");
            Console.CursorTop = 16;
            Console.CursorLeft = 40;
            Console.WriteLine("                   **     ******                        ");
            Console.CursorTop = 17;
            Console.CursorLeft = 40;
            Console.WriteLine("                   **      ****                         ");
            Console.CursorTop = 18;
            Console.CursorLeft = 40;
            Console.WriteLine("                   **       **                          ");
            Console.CursorTop = 19;
            Console.CursorLeft = 40;
            Console.WriteLine("                                                               ");
            Console.CursorTop = 5;
            Console.CursorLeft = 50;

        }
        static void ChiDan2()
        {
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorTop = 5;
            Console.CursorLeft = 40;
            Console.WriteLine("                                                  ");
            Console.CursorTop = 6;
            Console.CursorLeft = 40;
            Console.WriteLine(" Sử dụng mũi tên lên xuống và phím Enter để chọn. ");
            Console.CursorTop = 7;
            Console.CursorLeft = 40;
            Console.WriteLine("                                                  ");
            Console.BackgroundColor = ConsoleColor.Blue;

        }

    
        // thực đơn chính
        static void ThucDonChinh(int luaChon, string[] ThucDon)
        {
            
          //  Console.BackgroundColor = ConsoleColor.DarkGray;
           // Console.ForegroundColor = ConsoleColor.Black;
           // Console.WriteLine("                            |");
           // Console.ForegroundColor = ConsoleColor.White;
           // Console.ForegroundColor = ConsoleColor.Black;
           // Console.WriteLine(" MENU                       |");
           // Console.WriteLine("____________________________|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int topRow1 = 7;
            int topRow2 = topRow1;
            int topRow3 = topRow1;
            Console.CursorTop = topRow1;
            
            for (int i=0;i< ThucDon.Length; i++)
            {
                int left = 30;
                if (i > 3)
                {
                    left = 50;
                    Console.CursorTop = topRow2;
                    topRow2 += 5;

                }
                if (i > 7)
                {
                    left = 70;
                    Console.CursorTop = topRow3;
                    topRow3 += 5;

                }



                if (luaChon == i)
                {
                 
                    

                    Console.CursorLeft = left;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.CursorLeft = left;
                    Console.WriteLine(ThucDon[i]);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("___________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                   

                    Console.CursorLeft = left;
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine(ThucDon[i]);
                    Console.CursorLeft = left;
                    Console.WriteLine("                   |");
                    Console.CursorLeft = left;
                    Console.WriteLine("___________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }

            }

        }
        public static void LuaChonChinh(ref ArrayList ArrayHH, int select)
        {
            string ThemHangHoa = " Thêm hàng hóa     |";
            string SuaHangHoa = " Sửa hàng hóa      |";
            string XoaHangHoa = " Xóa hàng hóa      |";
            string TimKiemHangHoa = " Tìm kiếm hàng hóa |";
            string ThemLoaiHang = " Thêm Loại Hàng    |";
            string SuaLoaiHang = " Sửa Loại Hàng     |";
            string XoaLoaiHang = " Xóa Loại Hàng     |";
            string TimKiemLoaiHang = " Tìm Kiếm Loại Hàng|";
            string KhoHang = " Kho Hàng Hóa      |";
            string About = " About             |";
            string Thoat = " Thoát(ESC)        |";
            string[] ThucDon = new string[11] { ThemHangHoa,SuaHangHoa,XoaHangHoa,TimKiemHangHoa,
                ThemLoaiHang, SuaLoaiHang, XoaLoaiHang, TimKiemLoaiHang, KhoHang, About, Thoat};
            Tittle.TieuDe();
            ThucDonChinh(select, ThucDon);
                    //ChiDan();
            ConsoleKeyInfo input;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            input = Console.ReadKey(true);
                switch (input.Key)
                {
                case ConsoleKey.DownArrow:
                    if (select == ThucDon.Length-1)
                    {
                        //Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);
                                

                    } else
                    {
                        select++;
                        //Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);

                    }
                    return;
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {
                       // Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);


                    } else
                    {
                        select--;
                       // Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);
                    }
                    return;
                case ConsoleKey.RightArrow:
                    if (select <ThucDon.Length-4)
                    {
                        select += 4;
                       // Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);

                    } else
                    {
                       // Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);
                    }

                    return;
                case ConsoleKey.LeftArrow:
                    if (select >=4)
                    {
                        select -= 4;
                        //Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);

                    }
                    else
                    {
                        //Console.Clear();
                        LuaChonChinh(ref ArrayHH, select);
                    }
                    return;
                case ConsoleKey.Enter:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                            
                   Console.Clear();
                    DieuHuong(select, ref ArrayHH);
                    return;
                case ConsoleKey.Escape:
                    Console.Clear();
                    return;
                default:
                    //Console.Clear();
                    LuaChonChinh(ref ArrayHH, select);
                    return;
                }
              

        }
    }
}
