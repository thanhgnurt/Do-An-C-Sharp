using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Show
    {
        static void ShowItem(Struct.HOANGHOA Item, int stt, int select, int top)
        {

           
           // Console.CursorLeft = 100;
            Console.CursorTop = (stt-1)*5 +2 + top;
            
            if (select == stt - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Hàng Hóa {0}.", stt);
            Console.Write("Mã Hàng Hóa : {0}, ", Item.MaHH);
            Console.Write("Tên Hàng Hóa : {0}, ", Item.TenHH);
            Console.Write("Công Ty Sản Xuất : {0}, ", Item.CtySX);
            Console.Write("Hạn Sử Dụng : {0}/{1}/{2}, ", Item.HanDung.Ngay, Item.HanDung.Thang, Item.HanDung.Nam);
            Console.Write("Năm Sản Xuất : {0},", Item.NamSX);
            Console.WriteLine("Loại Hàng Hóa: {0}, ", Item.LoaiHang);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Black;
           

        }
        //
        static void ShowItemLH(Struct.LOAIHANG Item, int stt, int select, int top)
        {


            // Console.CursorLeft = 100;
            Console.CursorTop = (stt - 1) * 5 + 2 + top;

            if (select == stt - 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.WriteLine("Hàng Hóa {0}.", stt);
            Console.Write("Mã Hàng Hóa : {0}, ", Item.MaLH);
            Console.Write("Tên Hàng Hóa : {0}, ", Item.TenLH);
            Console.WriteLine("Công Ty Sản Xuất : {0}, ", Item.MotaLH);
            Console.WriteLine("________________");
            Console.ForegroundColor = ConsoleColor.Black;


        }
        //
        static void HienThi(ArrayList ArrayHH, int stt, int select, int top)
        {
            
            int SoLuongHH = ArrayHH.Count;
            if (SoLuongHH == 0)
            {
                Console.WriteLine("Bạn Chưa Có Hàng Hóa Nào Trong Kho.");
            }
            else

                foreach (Struct.HOANGHOA Item in ArrayHH)
                {
                    ShowItem(Item, stt, select, top);
                    stt++;
                }

        }
        //
        static void HienThiLH(ArrayList ArrayLH, int stt, int select, int top)
        {

            int SoLuongHH = ArrayLH.Count;
            if (SoLuongHH == 0)
            {
                Console.WriteLine("Bạn Chưa Có Hàng Hóa Nào Trong Kho.");
            }
            else

                foreach (Struct.LOAIHANG Item in ArrayLH)
                {
                    ShowItemLH(Item, stt, select, top);
                    stt++;
                }

        }
        //---switch dieu huong
        static void inputSeclect(ref ArrayList ArrayHH,ref ArrayList ArrayLH, int stt, int select, string ChucNang)
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            int top = 0;
            if (ChucNang == "Find")
            {
                top = 6;
            }
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {

                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    else
                    {
                        select--;
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.DownArrow:
                    if (select == ArrayHH.Count - 1)
                    {
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);

                    }
                    else
                    {
                        select++;
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.Enter:
                    switch (ChucNang)
                    {
                        case "Delete HH":
                            Delete.XoaHH(ref ArrayHH, ChucNang, select);
                            return;
                        case "Edit HH":
                            Console.Clear();
                            
                            Edit.SuaHH(ref ArrayHH, ref ArrayLH, ChucNang, select, 1);
                            return;
                    }
                    return;
                case ConsoleKey.Escape:
                    Tittle.TieuDe();
                    int index = 1;
                    if (ChucNang == "Delete HH")
                    {
                        index = 2;
                    }
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, index);
                    break;
                default:
                    inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    break;
            }
        }
        //
        static void inputSeclectLH(ref ArrayList ArrayHH, ref ArrayList ArrayLH, int stt, int select, string ChucNang)
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            int top = 0;
            if (ChucNang == "Find")
            {
                top = 6;
            }
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {

                        HienThiLH(ArrayHH, stt, select, top);
                        inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    else
                    {
                        select--;
                        HienThiLH(ArrayHH, stt, select, top);
                        inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.DownArrow:
                    if (select == ArrayHH.Count - 1)
                    {
                        HienThiLH(ArrayHH, stt, select, top);
                        inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);

                    }
                    else
                    {
                        select++;
                        HienThiLH(ArrayHH, stt, select, top);
                        inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.Enter:
                    switch (ChucNang)
                    {
                        case "Delete HH":
                            Delete.XoaHH(ref ArrayHH, ChucNang, select);
                            return;
                        case "Edit HH":
                            Console.Clear();

                            Edit.SuaHH(ref ArrayHH, ref ArrayLH, ChucNang, select, 1);
                            return;
                    }
                    return;
                case ConsoleKey.Escape:
                    Tittle.TieuDe();
                    int index = 1;
                    if (ChucNang == "Delete HH")
                    {
                        index = 2;
                    }
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, index);
                    break;
                default:
                    inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    break;
            }
        }

        //
        static void inputSeclectFind(ArrayList ArrayHH,ArrayList ArrayLH, int stt, int select, string ChucNang)
        {
            
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            int top = 0;
            if (ChucNang == "Find")
            {
                top = 6;
            }
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {

                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    else
                    {
                        select--;
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.DownArrow:
                    if (select == ArrayHH.Count - 1)
                    {
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);

                    }
                    else
                    {
                        select++;
                        HienThi(ArrayHH, stt, select, top);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.Enter:
                    switch (ChucNang)
                    {
                        case "Delete HH":
                            Delete.XoaHH(ref ArrayHH, ChucNang, select);
                            return;
                        case "Edit HH":
                            Console.Clear();
                            Edit.SuaHH(ref ArrayHH, ref ArrayLH, ChucNang, select, 1);
                            return;
                        case "Find":
                            HienThi(ArrayHH, stt, select, top);
                            return;
                    }
                    return;
                case ConsoleKey.Escape:
                    Tittle.TieuDe();
                    ArrayHH = Program.DuLieuMauHangHoa();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 3);
                    break;
                default:
                    inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    break;
            }
        }
        //

        public static void HienThiHangHoa(ref ArrayList ArrayHH, ref ArrayList ArrayLH, string ChucNang)
        {
           // Struct.HOANGHOA hh = (Struct.HOANGHOA)ArrayHH[1];
          
            int stt = 1;
            int select = 0;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.CursorTop = 0;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" "+ChucNang+" ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            HienThi(ArrayHH, stt, select, 0);
            inputSeclect(ref ArrayHH,ref ArrayLH, stt, select, ChucNang);

        }
        //
        public static void HienThiLoaiHang(ref ArrayList ArrayHH, ref ArrayList ArrayLH, string ChucNang)
        {
            // Struct.HOANGHOA hh = (Struct.HOANGHOA)ArrayHH[1];

            int stt = 1;
            int select = 0;
            Console.CursorTop = 0;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.CursorTop = 0;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(" " + ChucNang + " ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            HienThiLH(ArrayHH, stt, select, 0);
            inputSeclectLH(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);

        }

        public static void HienThiHangHoaTimKiem(ArrayList ArrayHH,ArrayList ArrayLH, string ChucNang)
        {
            // Struct.HOANGHOA hh = (Struct.HOANGHOA)ArrayHH[1];

            int top = 6;
            int stt = 1;
            int select = 0;
            Console.CursorTop = 6;
            Console.CursorLeft = 0;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.CursorTop = 6;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("                      " + ChucNang + "                          ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            HienThi(ArrayHH, stt, select, top);
            inputSeclectFind(ArrayHH, ArrayLH, stt, select, "Find");


        }
    }
}
