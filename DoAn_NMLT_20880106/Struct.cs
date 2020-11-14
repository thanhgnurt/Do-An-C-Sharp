using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class Struct
    {
        //--------------------------------Kiểu dữ liệu tự định nghĩa----------------------------
        public struct NGAYTHANGNAM
        {
            public int Ngay;
            public int Thang;
            public int Nam;
        }

        public struct HOANGHOA
        {
            public int MaHH;
            public string TenHH;
            public NGAYTHANGNAM HanDung;
            public string CtySX;
            public int NamSX;
            public string LoaiHang;
        }
    }
}
