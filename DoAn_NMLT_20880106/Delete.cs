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
                    int SttXoa = int.Parse(Console.ReadLine());
                    return SttXoa;
                }
                catch
                {
                    Console.WriteLine("Ban nhap khong dung vvui long nhap lai");
                    
                }

            }
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
                int SttXoa = ChonXoaHangHoa();
               
                if (SttXoa==1)
                {
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
