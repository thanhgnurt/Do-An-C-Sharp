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

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                            |");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" THỰC ĐƠN CHÍNH             |");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("____________________________|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i=0;i< ThucDon.Length; i++)
            {
                
                if (luaChon == i)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                            |");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(ThucDon[i]);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("____________________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                            |");
                    Console.WriteLine(ThucDon[i]);
                    Console.WriteLine("____________________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
               
            }
        }
        public static void LuaChonChinh(ref ArrayList ArrayHH, int select)
        {
            string them = " Thêm hàng hóa              |";
            string sua = " Sửa hàng hóa               |";
            string xoa = " Xóa hàng hóa               |";
            string timKiem = " Tìm kiếm hàng hóa          |";
            string KhoHang = " Kho Hàng Hóa               |";
            string thoat = " Thoát(ESC)                 |";
            string[] ThucDon = new string[6] { them, sua, xoa, timKiem, KhoHang, thoat };
            Tittle.TieuDe();
                    ThucDonChinh(select, ThucDon);
                    ChiDan();
                    //Console.WriteLine("__________________");
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    
                    switch (input.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (select == ThucDon.Length-1)
                            {
                                Console.Clear();
                                LuaChonChinh(ref ArrayHH, select);
                                

                            } else
                            {
                                select++;
                                Console.Clear();
                                LuaChonChinh(ref ArrayHH, select);

                            }
                            //Console.Clear();
                            //Add.ThemSanPham(ref ArrayHH);
                            return;
                        case ConsoleKey.UpArrow:
                            //Edit.SuaHangHoa(ref ArrayHH);
                            if (select == 0)
                            {
                                Console.Clear();
                                LuaChonChinh(ref ArrayHH, select);


                            } else
                            {
                                select--;
                                Console.Clear();
                                LuaChonChinh(ref ArrayHH, select);
                            }
                            return;
                        case ConsoleKey.Enter:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            
                            Console.Clear();
                            DieuHuong(select, ref ArrayHH);
                            //Delete.XoaHangHoa(ref ArrayHH);
                            return;
                        case ConsoleKey.Escape:
                            return;
                        default:
                            Console.Clear();
                            LuaChonChinh(ref ArrayHH, select);
                            return;
                    }
              

        }
    }
}
