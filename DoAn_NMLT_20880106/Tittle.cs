using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class Tittle
    {
        //--Tiêu đề
        public static void TieuDe()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
           // Console.WriteLine("                            |");
            Console.WriteLine(" Họ và Tên : Lê Thành Trung |");
            Console.WriteLine(" MSSV: 20880106             |");
            Console.WriteLine("____________________________|");
            TenPhanMem();
            Console.ForegroundColor = ConsoleColor.Black;
           // Console.WriteLine("____________________________");
        }
        static void TenPhanMem()
        {
            Console.CursorTop = 3;
            Console.CursorLeft = 42;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                    ");
            Console.CursorTop = 4;
            Console.CursorLeft = 42;
            Console.WriteLine("  ĐỒ ÁN: PHẦN MỀM QUẢN LÝ HÀNG HÓA  ");
            Console.CursorTop = 5;
            Console.CursorLeft = 42;
            Console.WriteLine("                                    ");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
