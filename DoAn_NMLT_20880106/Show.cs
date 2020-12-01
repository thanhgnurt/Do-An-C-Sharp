using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Show
    {
        static void ShowItem(Struct.HOANGHOA Item, int stt, int select)
        {

            if (select == stt-1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
           // Console.CursorLeft = 100;
            Console.CursorTop = (stt-1)*5 +2;
            
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
        static void HienThi(ArrayList ArrayHH, int stt, int select)
        {
            
            int SoLuongHH = ArrayHH.Count;
            if (SoLuongHH == 0)
            {
                Console.WriteLine("Bạn Chưa Có Hàng Hóa Nào Trong Kho.");
            }
            else

                foreach (Struct.HOANGHOA Item in ArrayHH)
                {
                    ShowItem(Item, stt, select);
                    stt++;
                }

        }
        //---switch dieu huong
        static void inputSeclect(ref ArrayList ArrayHH,ref ArrayList ArrayLH, int stt, int select, string ChucNang)
        {
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    if (select == 0)
                    {
                        HienThi(ArrayHH, stt, select);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    else
                    {
                        select--;
                        HienThi(ArrayHH, stt, select);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    }
                    return;
                case ConsoleKey.DownArrow:
                    if (select == ArrayHH.Count - 1)
                    {
                        HienThi(ArrayHH, stt, select);
                        inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);

                    }
                    else
                    {
                        select++;
                        HienThi(ArrayHH, stt, select);
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
                            HienThi(ArrayHH, stt, select);
                            return;
                    }
                    return;
                case ConsoleKey.Escape:
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);
                    break;
                default:
                    inputSeclect(ref ArrayHH, ref ArrayLH, stt, select, ChucNang);
                    break;
            }
        }

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
            HienThi(ArrayHH, stt, select);
            inputSeclect(ref ArrayHH,ref ArrayLH, stt, select, ChucNang);

        }
    }
}
