using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Add
    {
        
        public static void ThemSanPham(ref ArrayList ArrayHH)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("THÊM SẢN PHẨM");
            Struct.HOANGHOA SP;
            Console.WriteLine("Hãy nhập mã mặt hàng:");
            SP.MaHH = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập tên mặt hàng:");
            SP.TenHH = Console.ReadLine();
            Console.WriteLine("Hãy nhập hạn dùng");
            Console.WriteLine("Ngày:");
            SP.HanDung.Ngay = int.Parse(Console.ReadLine());
            Console.WriteLine("Tháng:");
            SP.HanDung.Thang = int.Parse(Console.ReadLine());
            Console.WriteLine("Năm:");
            SP.HanDung.Nam = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập công ty sản xuất :");
            SP.CtySX = Console.ReadLine();
            Console.WriteLine("Hãy nhập năm sản xuất :");
            SP.NamSX = int.Parse(Console.ReadLine());
            Console.WriteLine("Hãy nhập loại hàng hóa :");
            SP.LoaiHang = Console.ReadLine();
            Console.WriteLine("Để lưu bấm phím bât kì, để quay lại màn hình chính nhập 'exit', để nhập lại nhập 'cancel'.");
            string luaChon = Console.ReadLine().ToLower();
            Console.WriteLine(luaChon);
            if (luaChon == "cancel" || luaChon == "exit")
            {
                if (luaChon == "exit")
                {
                    Console.Clear();
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH);
                }
                else
                    Console.Clear();
                    ThemSanPham(ref ArrayHH);
            }
            else
            {
                ArrayHH.Add(SP);
                Console.Clear();
                Console.WriteLine("Bạn đã lưu thành công !");
                Select.LuaChonChinh(ref ArrayHH);
                
            }


        }
    }
}
