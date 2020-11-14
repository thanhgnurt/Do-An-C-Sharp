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
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Vui lòng chọn một trong những chức năng sau đây:");
                    Console.WriteLine("Nhấn 1: Thêm sản phẩm");
                    Console.WriteLine("Nhấn 2: Sửa sản phẩm");
                    Console.WriteLine("Nhấn 3: Xóa sản phẩm");
                    Console.WriteLine("Nhấn 4: Tìm kiếm mặt hàng");
                    Console.WriteLine("=========================================");
                    int luaChon = int.Parse(Console.ReadLine());
                    switch (luaChon)
                    {
                        case 1:
                            Add.ThemSanPham(ref ArrayHH);
                            return;
                        case 2:
                            Edit.SuaHangHoa();
                            return;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Delete.XoaHangHoa(ref ArrayHH);
                            return;
                        case 4: return;
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
