using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
namespace DoAn_NMLT_20880106
{
    public class Find
    {
        public static void TimKiemHangHoa(ArrayList ArrayHH, ArrayList ArrayLH)
        {
            string keySearch = " ";
            ArrayList ArrayFind = new ArrayList();
            ArrayFind.Clear();
            Form.FormTimKiem("TÌM KIẾM HÀNG HÓA!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            keySearch = Console.ReadLine();
            ArrayFind = FindHH(ArrayHH, keySearch);
            Show.HienThiHangHoaTimKiem(ArrayFind,ArrayLH, "Danh sách hàng hóa");
            Console.CursorTop = 4;
            Console.CursorLeft = 2;
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.Escape:
                    Tittle.TieuDe();
                    Select.LuaChonChinh(ref ArrayHH, ref ArrayLH, 0);
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    TimKiemHangHoa(ArrayHH,ArrayLH);
                    break;

            }


        }
        //--function tim kiem hang hoa
        static ArrayList FindHH(ArrayList ArrayHH, string keySearch)
        {
            ArrayList ArrayFind = new ArrayList();
           
            ArrayFind.Clear();
            for(int i=0; i<ArrayHH.Count; i++)
            {
                Struct.HOANGHOA item = (Struct.HOANGHOA)ArrayHH[i];
                string tenHH = item.TenHH.Trim().ToLower();
                keySearch = keySearch.Trim().ToLower();
                if (tenHH.Contains(keySearch))
                {
                    ArrayFind.Add(item);
                }
                
            }
          
            return ArrayFind;
        }

























    }
}
