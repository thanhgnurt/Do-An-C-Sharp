using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Add
    {
        //-- nhập dữ liệu, int = 1, string = 0
        static void NhapInt(string tittle,ref int intBN, string DoiTuong)
        {
            for(; ; )
            {
                try
                {
                    Console.WriteLine(tittle);
                    intBN = int.Parse(Console.ReadLine());
                    return;
                  
                }
                catch
                {
                    Console.WriteLine("Bạn nhập sai định dạng {0} vui lòng nhập lại:", DoiTuong);
                }
            }
        }
        // điều hướng
        static void DieuHuong(ref ArrayList ArrayHH)
        {
            Console.CursorTop = 5;
            Console.CursorLeft = 40;
            Console.WriteLine("Để quay lại trang chính chọn BACKSPACE");
            Console.CursorTop = 6;
            Console.CursorLeft = 40;
            Console.WriteLine("Để thêm sản phẩm mới chọn ENTER");
            Console.CursorTop = 7;
            Console.CursorLeft = 40;
            Console.WriteLine("Để thoát chon ESC");
            Console.CursorTop = 8;
            Console.CursorLeft = 40;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    ThemSanPham(ref ArrayHH);
                    break;
                case ConsoleKey.Backspace:
                    Select.LuaChonChinh(ref ArrayHH);
                    break;
                default:
                    DieuHuong(ref ArrayHH);
                    break;
            }

        }


        public static void ThemSanPham(ref ArrayList ArrayHH)
        {
          

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("THÊM SẢN PHẨM |");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Struct.HOANGHOA SP;
            Console.WriteLine("Hãy nhập mã mặt hàng:");
            SP.MaHH = Console.ReadLine();
            Console.WriteLine("Hãy nhập tên mặt hàng:");
            SP.TenHH = Console.ReadLine();
            Console.WriteLine("Hãy nhập hạn dùng");
            int Ngay = 0;
            NhapInt("Nhập ngày", ref Ngay, "ngày");
            SP.HanDung.Ngay = Ngay;
            int Thang = 0;
            NhapInt("Nhập tháng", ref Thang, "tháng");
            SP.HanDung.Thang = Thang;
            int Nam = 0;
            NhapInt("Nhập năm", ref Nam, "năm");
            SP.HanDung.Nam = Nam;
            Console.WriteLine("Hãy nhập công ty sản xuất :");
            SP.CtySX = Console.ReadLine();
            int NamSanXuat=0;
            NhapInt("Hay nhập năm xản xuât",ref NamSanXuat,"năm sản xuất");
            SP.NamSX = NamSanXuat;
            Console.WriteLine("Hãy nhập loại hàng hóa :");
            SP.LoaiHang = Console.ReadLine();
            Console.WriteLine("Để lưu chọn phím bất kỳ");
            Console.WriteLine("Để quay lại trang chính chọn BACKSPACE ");
            Console.WriteLine("Để nhập lại chọn R");
            Console.WriteLine("Để thoát chon ESC");
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.R:
                    ThemSanPham(ref ArrayHH);
                    break;
                case ConsoleKey.Backspace:
                    Select.LuaChonChinh(ref ArrayHH);
                    break;
                default:
                    ArrayHH.Add(SP);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bạn đã lưu thành công!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    DieuHuong(ref ArrayHH);
                    break;
            }
            
     


        }
    }
}
