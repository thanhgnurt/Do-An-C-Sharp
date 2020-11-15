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
            Console.WriteLine("Họ và Tên : Lê Thành Trung  |");
            Console.WriteLine("MSSV: 20880106              |");
            Console.WriteLine("____________________________|");
            TenPhanMem();
            Console.WriteLine("_____________________");
        }
        static void TenPhanMem()
        {
            Console.CursorTop = 4;
            Console.CursorLeft = 40;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ĐỒ ÁN: PHẦN MỀM QUẢN LÝ HÀNG HÓA ");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            
        }
    }
}
