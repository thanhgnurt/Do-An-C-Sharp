using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Select
    {
        //---điều hướng

    
        // thực đơn chính
        static void ThucDonChinh(int luaChon)
        {
            string them = "Thêm hàng hóa        |";
            string sua = "Sửa hàng hóa         |";
            string xoa = "Xóa hàng hóa         |";
            string timKiem = "Tìm kiếm hàng hóa    |";
            string thoat = "Exit                 |";
            string[] ThucDon = new string[5] { them, sua, xoa, timKiem, thoat };
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                     |");
            Console.WriteLine("Thực Đơn Chính       |");
            Console.WriteLine("_____________________|");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            for (int i=0;i< ThucDon.Length; i++)
            {
                
                if (luaChon == i)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                     |");
                    Console.WriteLine(ThucDon[i]);
                    Console.WriteLine("_____________________|");
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                    Console.WriteLine("                     |");
                    Console.WriteLine(ThucDon[i]);
                    Console.WriteLine("_____________________|");
                }
               
            }
        }
        public static void LuaChonChinh(ref ArrayList ArrayHH, int select)
        {
            

                    Tittle.TieuDe();
                    ThucDonChinh(select);
                    //Console.WriteLine("__________________");
                    ConsoleKeyInfo input;
                    input = Console.ReadKey(true);
                    
                    switch (input.Key)
                    {
                        case ConsoleKey.DownArrow:
                            if (select == 4)
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
                            Delete.XoaHangHoa(ref ArrayHH);
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
