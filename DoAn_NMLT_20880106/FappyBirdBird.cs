using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class FappyBirdBird : FappyBird
    {
        //------move down brid-------
        public static void MoveDownBird()
        {
            while (true)
            {
                if (gameOver)
                {
                    return;
                }
                if (!evenSpace)
                {
                    Thread.Sleep(250);
                    hightBird ++;

                } 
            }
        }
        //-------Listen key----
        public static void ListenKey(bool isTrue)
        {
            while (isTrue)
            {
                if (gameOver)
                {
                    return;
                }
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Spacebar)
                {
                    hightBird = hightBird - 1;
                    evenSpace = true;
                }
                

            }

        }
        //----tao chieu cao--
        public static int InitialHight()
        {
            int height = 14;
            return height;
        }
        //--- return hight---
        public static void ReturnHight()
        {
        }
        //-----Fappy Bird Main----
        public static void FappyBirdMain()
        {
            int hight = 14;
            POINT[] bird = new POINT[2];
            bird = pointBir;
            while (true)
            {
               
                ConsoleKeyInfo input;
                input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Spacebar)
                {
                    hight = hight - 2;
                }

            }
        }
        //---write bird---
        public static void WriteBird(ref POINT[] pBird, string direction)
        {
            for (int i = 0; i < pBird.Length; i++)
            {
                Console.SetCursorPosition(pBird[i].X, pBird[i].Y);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" ");
            }
            if (direction == "MoveDown")
            {
                for (int i = 0; i < pBird.Length; i++)
                {
                    Console.SetCursorPosition(pBird[i].X, hightBird - 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
  
            }
            if(direction == "MoveUp")
            {
                for (int i = 0; i < pBird.Length; i++)
                {
                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
            }

        }
        //point bird-----start
        public static POINT[] pointBird()
        {
            POINT[] bird = new POINT[2];
            POINT temp;
            int index = 0;
            for(int i =30; i< 32; i++)
            {
                    temp.X = i;
                    temp.Y = hightBird;
                    bird[index] = temp;
                    index++;
            
            }
            return bird;
        }

        //--- control bird---
        public static void ControlBird(int hight)
        {

            hight = hight -2;
        }

       



        ///--end
    }
}
