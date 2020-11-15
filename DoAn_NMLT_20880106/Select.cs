using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Select
    {
        public static void LuaChonChinh(ref ArrayList ArrayHH)
        {


            for (; ; )
            {

                try
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine("Họ và Tên : Lê Thành Trung  |");
                    Console.WriteLine("MSSV: 20880106              |");
                    Console.WriteLine("-----------------------------");
                    Tittle.TieuDe();
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Chọn chức năng:");
                    Console.WriteLine("Nhấn 1: Thêm sản phẩm");
                    Console.WriteLine("Nhấn 2: Sửa sản phẩm");
                    Console.WriteLine("Nhấn 3: Xóa sản phẩm");
                    Console.WriteLine("Nhấn 4: Tìm kiếm mặt hàng");
                    Console.WriteLine("=========================================");
                    int luaChon = int.Parse(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Add.ThemSanPham(ref ArrayHH);
                            return;
                        case 2:
                            Edit.SuaHangHoa(ref ArrayHH);
                            return;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Delete.XoaHangHoa(ref ArrayHH);
                            return;
                        case 4:
                            Find.TimKiem(ref ArrayHH);
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Bạn nhập không đúng vui lòng nhập lại");
                            return;
                    }
                } catch
                {

                    Console.Clear();
                    Console.WriteLine("Bạn nhập không đúng vui lòng nhập lại");
                }

            }

        }
    }
}
