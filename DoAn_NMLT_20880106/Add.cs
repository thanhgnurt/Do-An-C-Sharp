using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Add
    {
       
        // -- nhập ngày tháng
        static void NhapNgayThangNam(ref int ngay, ref int thang, ref int nam, int top, int left)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.CursorTop = top * 4 - 2;
            Console.CursorLeft = 1;
            Console.WriteLine("Hãy nhập hạn sử dụng:");
            Console.CursorTop = top * 4-1 ;
            Console.CursorLeft = 2;
            Console.WriteLine("Ngày:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 8;
            Console.WriteLine("-------------");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorLeft = 8;
            Console.WriteLine("             ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 9;
            ngay = NhapInt(ngay, "Ngày", 14, 9);
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 24;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Tháng:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 31;
            Console.WriteLine("--------------");
            Console.CursorLeft = 31;
            Console.WriteLine("              ");
            Console.CursorLeft = 31;
            Console.WriteLine("              ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 32;
            thang = NhapInt(thang, "Tháng", 14, 32);
            Console.CursorTop = top * 4-1;
            Console.CursorLeft = 49;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine("Năm:");
            Console.BackgroundColor = ConsoleColor.White;
            Console.CursorTop = top * 4 - 1;
            Console.CursorLeft = 54;
            Console.WriteLine("--------------");
            Console.CursorLeft = 54;
            Console.WriteLine("              ");
            Console.CursorLeft = 54;
            Console.WriteLine("              ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = 55;
            nam = NhapInt(nam,"Năm", 14, 55);


        }
        //-- nhập dữ liệu, int = 1, string = 0
        static int NhapInt(int intBN, string DoiTuong, int top, int left)
        {
            int flag = 1;
            for(; ; )
            {
                try
                {

                    if (flag==1)
                    {
                       
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    if (flag == 2)
                    {

                        Console.BackgroundColor = ConsoleColor.Magenta;
                    }
                    if (flag == 3)
                    {

                        Console.BackgroundColor = ConsoleColor.Cyan;
                    }
                    intBN = int.Parse(Console.ReadLine());
                    return intBN;
                  
                }
                catch
                {
                    if (flag == 3)
                    {
                        flag = 0;
                    }
                    flag++;
                    Console.CursorTop = top ;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("  ");
                    Console.CursorLeft = 2;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(" Bạn nhập sai định dạng ");
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" {0} ",DoiTuong);
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write(" vui lòng nhập số!     ");
                    //Console.BackgroundColor = ConsoleColor.Black;
                    //Console.Write("     ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.CursorTop = top - 2;
                    Console.CursorLeft = left;

                }
            }
        }
        // điều hướng
        static void DieuHuong(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
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
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    ThemHangHoa(ref ArrayHH, ref ArrayLH);
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH,ref ArrayLH, 0);
                    break;
                default:
                    DieuHuong(ref ArrayHH, ref ArrayLH);
                    break;
            }

        }

        //  input
        public static void InputHH(int top, int left, string header)
        {
            //first top 4 left 1
            Console.CursorTop = top * 4 -2;
            Console.CursorLeft = 0;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine(" {0}",header);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("                                                                    ");
            Console.WriteLine("                                                                    ");
            Console.CursorTop = top * 4;
            Console.CursorLeft = left;

        }
        // sửa lại thêm laoij hang
        public static void ThemLoaiHang(ref ArrayList ArrayLH, ref ArrayList ArrayHH)
        {
            Form.FormLoaiHang();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine("THÊM LOẠI HÀNG |");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Struct.LOAIHANG LH;
            InputHH(1, 2, "");
            LH.MaLH = Console.ReadLine();
            InputHH(2, 2, "");
            LH.TenLH = Console.ReadLine();
            InputHH(3, 2, "");
            LH.MotaLH = Console.ReadLine();
            Console.CursorTop = 15;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Để lưu chọn phím bất kỳ");
            Console.WriteLine(" Để quay lại trang chính chọn BACKSPACE ");
            Console.WriteLine(" Để nhập lại chọn R");
            Console.WriteLine(" Để thoát chon ESC");
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.R:
                    ThemLoaiHang(ref ArrayLH, ref ArrayLH);
                    break;
                case ConsoleKey.Backspace:
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayLH, ref ArrayLH, 0);
                    break;
                default:
                    ArrayLH.Add(LH);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bạn đã lưu thành công!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    DieuHuong(ref ArrayLH, ref ArrayLH);
                    break;
            }




        }
        
        public static void ThemHangHoa(ref ArrayList ArrayHH, ref ArrayList ArrayLH)
        {

            Form.FormHangHoa("THÊM HÀNG HÓA");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.WriteLine(" THÊM HÀNG HÓA |");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------*");
            Struct.HOANGHOA SP;
            InputHH(1, 2, "Hãy nhập mã mặt hàng:");
            SP.MaHH = Console.ReadLine();
            InputHH(2, 2, "Hãy nhập tên hàng hóa");
            SP.TenHH = Console.ReadLine();
            int ngay=0, thang=0, nam=0;
            NhapNgayThangNam(ref ngay, ref thang, ref nam, 3, 1);
            SP.HanDung.Ngay = ngay;
            SP.HanDung.Nam = nam;
            SP.HanDung.Thang = thang;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            InputHH(4, 2, "Hãy nhập công ty sản xuất:                                           ");
            SP.CtySX = Console.ReadLine();
            InputHH(5, 1, "Hay nhập năm xản xuât");
            int namSX = 0;
            Console.CursorLeft = 2;
            SP.NamSX = NhapInt(namSX, "Năm Sản Xuất", 22, 2);
            InputHH(6, 2, "Hãy nhập loại hàng hóa:                                              ");
            SP.LoaiHang = Console.ReadLine(); 

            Console.CursorTop = 27;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" Để lưu chọn phím bất kỳ");
            Console.WriteLine(" Để quay lại trang chính chọn BACKSPACE ");
            Console.WriteLine(" Để nhập lại chọn R");
            Console.WriteLine(" Để thoát chon ESC");
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.R:
                    ThemHangHoa(ref ArrayHH, ref ArrayLH);
                    break;
                case ConsoleKey.Backspace:
                    Console.Clear();
                    Select.LuaChonChinh(ref ArrayHH,ref ArrayLH, 0);
                    break;
                default:
                    ArrayHH.Add(SP);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Bạn đã lưu thành công!");
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    DieuHuong(ref ArrayHH, ref ArrayLH);
                    break;
            }
            
     


        }
    }
}
