using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class Delete
    {
         static int ChonXoaHangHoa()
        {
            for (; ; )
            {
                try
                {

                    Console.Write("Nhập vào số thứ tự hàng hóa để xóa:");        
                    int SttXoa = int.Parse(Console.ReadLine())-1;
                    return SttXoa;
                }
                catch
                {
                    Console.WriteLine("Ban nhap khong dung vui lòng chọn lại");
                    
                }

            }
        }

        static void Xoa(int index, ref ArrayList ArrayHH)
        {
            ArrayHH.RemoveAt(index);

        }

        public static void XoaHangHoa(ref ArrayList ArrayHH)
        {
            
            if (ArrayHH.Count==0)
            {
               // Console.Clear();
                Console.WriteLine("Kho hàng hóa của bạn đang trống.");
            } else
            {

               // Console.Clear();
                Console.WriteLine("Xóa Sản Phẩm.");
                Show.HienThiHangHoa(ArrayHH);
                int index = ChonXoaHangHoa();
                if (index>=ArrayHH.Count)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Số bạn nhập không có trong danh mục");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    XoaHangHoa(ref ArrayHH);
                }
                
               
                if (index>=0 && index < ArrayHH.Count)
                {
                    Xoa(index,ref ArrayHH);
                    Console.Clear();
                    Console.WriteLine("Sản phẩm xóa thành công");
                    XoaHangHoa(ref ArrayHH);
                } else
                {
                    
                    XoaHangHoa(ref ArrayHH);
                    Console.WriteLine("vui lòng chọn lại");
                }

            }

        }
    }
}
