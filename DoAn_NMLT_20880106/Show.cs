using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DoAn_NMLT_20880106
{
    public class Show
    {
        public static void HienThiHangHoa(ArrayList ArrayHH)
        {
            
            int stt = 1;
            int SoLuongHH = ArrayHH.Count;
            if (SoLuongHH==0)
            {
                Console.WriteLine("Bạn Chưa Có Sản Phẩm Nào Trong Kho.");
            } else
 
            foreach(Struct.HOANGHOA SP in ArrayHH)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("Hàng Hóa {0}.", stt);
                Console.Write("Mã Hàng Hóa : {0}, ", SP.MaHH);
                Console.Write("Tên Hàng Hóa : {0}, ", SP.TenHH);
                Console.Write("Công Ty Sản Xuất : {0}, ", SP.CtySX);
                Console.Write("Hạn Sử Dụng : {0}/{1}/{2}, ", SP.HanDung.Ngay, SP.HanDung.Thang, SP.HanDung.Nam);
                Console.Write("Năm Sản Xuất : {0},", SP.NamSX);
                Console.WriteLine("Loại Hàng Hóa: {0}, ", SP.LoaiHang);
                Console.WriteLine("--------------------------------------------------------------------");
                stt++;
            }

        }
    }
}
