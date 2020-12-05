using System;
using System.Collections.Generic;
using System.Text;

namespace DoAn_NMLT_20880106
{
    public class Caculator
    {
        public static void PageMainCacu()
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WriteLine("Bảng tính đang được cập nhật.......");
            Console.CursorTop = 7;
            Console.CursorLeft = 40;
            Console.WriteLine("Để thoát chon ESC");

            while (true)
            {
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    break;
                   
                }
            }
            Program.AppMain();  
            
        }
    }
}
