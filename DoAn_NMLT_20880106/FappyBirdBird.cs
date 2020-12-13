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
                if (!evenSpace && deleteShadow)
                {
                    Thread.Sleep(200);
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
                if (input.Key == ConsoleKey.Spacebar && deleteShadow)
                {
                    hightBird = hightBird - 2;
                    deleteShadow = false;
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

        //---active move bird---
        public static void ActiveMoveBird(POINT[]pBird)
        {
            DeleteShadowUp(pBird);
            WriteBird(pBird);
        }
        //----delete shadow down---
        public static void DeleteShadowDown(POINT[] pBird)
        {
            for (int i = 0; i < pBird.Length; i++)
            {
                if (pBird[i].Y > 0)
                {
                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y );
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                }

            }
        }
        //----delete shadow up----
        public static void DeleteShadowUp(POINT[] pBird)
        {
            for (int i = 0; i < pBird.Length; i++)
            {

                Console.SetCursorPosition(pBird[i].X, pBird[i].Y + 2);
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write(" ");
                deleteShadow = true;


            }
        }
        //-----write move bird-----
        public static void WriteMoveBird(POINT[] pBird)
        {
            for (int i = 0; i < pBird.Length; i++)
            {
                if (pBird[0].Y >= 0)
                {
                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
                }

            }
        }
        //----active move bird--delete shadow bird---
        public static void DeleteShadowBird(POINT[] pBird, string direction)
        {
           
            if (direction == "MoveUp")
            {
                for (int i = 0; i < pBird.Length; i++)
                {

                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y + 1);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y + 2);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                    deleteShadow = true;


                }
            }

            if (direction == "MoveDown")
            {
                for (int i = 0; i < pBird.Length; i++)
                {
                    if (pBird[i].Y > 0 )
                    {
                        Console.SetCursorPosition(pBird[i].X, pBird[i].Y - 1);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }

                }

            }


        }
        //---active move bird--write bird---

        public static void WriteBird(POINT[] pBird)
        {
         
            for (int i = 0; i < pBird.Length; i++)
            {
                if (pBird[0].Y >= 0)
                {
                    Console.SetCursorPosition(pBird[i].X, pBird[i].Y);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                    Console.BackgroundColor = ConsoleColor.White;
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



       



        ///--end
    }
}
