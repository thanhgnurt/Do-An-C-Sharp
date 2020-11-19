using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class Program
    {
        //tạo dữ liễu mẫu
        static ArrayList DuLieuMau()
        {
            ArrayList ArraySP = new ArrayList();
            Struct.HOANGHOA hh1, hh2, hh3, hh4;
            //hang hoa 1
            hh1.MaHH = "4215";
            hh1.TenHH = "Galaxy note p20";
            hh1.HanDung.Ngay = 20;
            hh1.HanDung.Thang = 5;
            hh1.HanDung.Nam = 2025;
            hh1.NamSX = 2019;
            hh1.CtySX = "SamSung";
            hh1.LoaiHang = "Điện tử";
            //hang hóa 2
            hh2.MaHH = "1256";
            hh2.TenHH = "Nước khoáng Aquafina";
            hh2.HanDung.Ngay = 15;
            hh2.HanDung.Thang = 5;
            hh2.HanDung.Nam = 2023;
            hh2.NamSX = 2019;
            hh2.CtySX = "Pepsi";
            hh2.LoaiHang = "Đồ uống";
            //hang hoa 3
            hh3.MaHH = "g125";
            hh3.TenHH = "Iphone";
            hh3.HanDung.Ngay = 05;
            hh3.HanDung.Thang = 07;
            hh3.HanDung.Nam = 2030;
            hh3.NamSX = 2020;
            hh3.CtySX = "Apple";
            hh3.LoaiHang = "Đồ điện tử";
            //hang hoa 4
            hh4.MaHH = "M125";
            hh4.TenHH = "Rượu vang";
            hh4.HanDung.Ngay = 10;
            hh4.HanDung.Thang = 02;
            hh4.HanDung.Nam = 2023;
            hh4.NamSX = 2019;
            hh4.CtySX = "ABC";
            hh4.LoaiHang = "Đồ uống có cồn";
            //
            ArraySP.Add(hh1);
            ArraySP.Add(hh2);
            ArraySP.Add(hh3);
            ArraySP.Add(hh4);

            return ArraySP;

        }
        
     
        //----------------------------------------------Main------------------------------------
        static void Main(string[] args)
        {
            ArrayList ArraySP = DuLieuMau();
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Select.LuaChonChinh(ref ArraySP, 0);

        }
    }
}
