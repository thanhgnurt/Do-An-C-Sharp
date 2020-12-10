using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public class FappyBrid
    {
        public  static void FontGameFB()
        {
            FloorCeilingFB();
            Struct.DIEM widthDoor;
            widthDoor.x = 5;
            widthDoor.y = 6;
            //ChimenyFB(119, 10, widthDoor);
            List<Struct.DIEM> Chimeny = new List<Struct.DIEM>();
            //Chimeny = ChimenyFB2(50, 10 ,1 );
            //WriteChimeny(Chimeny);
            LoopFB();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Read();
        }
        //-- nền và trần game
        public static void FloorCeilingFB()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int top = 2;
            int bottom = 25;
            int maxWidth = 120;
            Console.Clear();
            for (int i = 0; i< maxWidth; i++ )
            {

                for (int j = top; j <= bottom; j++)
                {
                    if (j!= top || j != bottom)
                    {
                        Console.SetCursorPosition(i, j);
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }


                }
            }
            
        }
        //---ống khói
        static void ChimenyFB(int x, int height, Struct.DIEM widthDoor)
        {
            Random RandomFB = new Random();
            int ranDoor;
            ranDoor = RandomFB.Next(widthDoor.x, widthDoor.y);
            ranDoor = 4;
            int width = 7;
            int top = 2;
            int bottom = 25;
            int maxWidth = 120;
            //-- above chimery
            for (int i = top; i<= height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if(x+j > 119)
                    {
                        break;
                    }
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(x+j,i);
                    Console.WriteLine(" ");
                }
                

            }
            if (x + width < 119)
            {
                Console.SetCursorPosition(x + width, height);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x + width, height - 1);
                Console.WriteLine(" ");
                //
                Console.SetCursorPosition(x + width, height + ranDoor + 1);
                Console.WriteLine(" ");
                Console.SetCursorPosition(x + width, height + ranDoor);
                Console.WriteLine(" ");
            }
            
            Console.SetCursorPosition(x - 1, height);
            Console.WriteLine(" ");
            Console.SetCursorPosition(x - 1, height-1);
            Console.WriteLine(" ");
            // below chimeny
            for (int i = height+ranDoor; i <= bottom ; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (x + j > 119)
                    {
                        break;
                    }
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(x + j, i);
                    Console.WriteLine(" ");
                }
            }


            Console.SetCursorPosition(x - 1, height+ranDoor);
            Console.WriteLine(" ");
            Console.SetCursorPosition(x - 1, height + ranDoor +1);
            Console.WriteLine(" ");
            Console.BackgroundColor = ConsoleColor.White;
        }
        //------
        static void ChimneyFappyBrid(int indexDoor,int indexChimney)
        {

            int slit = 5;
            List<Struct.DIEM>[] ChimneyT = new List<Struct.DIEM>[2];
            List<Struct.DIEM>[] ChimneyB = new List<Struct.DIEM>[2];
            ChimneyT = ChimneyTop(indexDoor, indexChimney);
            ChimneyB = ChimneyBottom(indexDoor + slit, indexChimney);
            WriteChimney(ChimneyB);
            WriteChimney(ChimneyT);

        }
        //---chimney top---
        static List<Struct.DIEM>[] ChimneyTop(int indexDoor, int indexChimney)
        {
            int top = 2;
            int maxWidth = 120;
            int width = 8;
            Struct.DIEM pointTemp;
            pointTemp.x = 0;
            pointTemp.y = 0;
            List<Struct.DIEM> ChimneyLeft = new List<Struct.DIEM>();
            List<Struct.DIEM> ChimneyRight = new List<Struct.DIEM>();
            List<Struct.DIEM>[] Chimney = new List<Struct.DIEM>[2];


            for (int i = top; i <= indexDoor; i++)
            {
                //--1/2 chinemy left
                if (indexChimney < maxWidth)
                {
                    if (i == indexDoor || i == indexDoor - 1)
                    {
                        if (i == indexDoor)
                        {
                            for (int j = indexChimney - 1; j <= indexChimney + width; j++)
                            {
                                if (j < maxWidth)
                                {
                                    pointTemp.x = j;
                                    pointTemp.y = i;
                                    ChimneyLeft.Add(pointTemp);

                                }

                            }
                        }
                        else
                        {
                            pointTemp.x = indexChimney;
                            pointTemp.y = i;
                            ChimneyLeft.Add(pointTemp);
                            pointTemp.x = indexChimney - 1;
                            pointTemp.y = i;
                            ChimneyLeft.Add(pointTemp);

                        }


                    }
                    else
                    {
                        pointTemp.x = indexChimney;
                        pointTemp.y = i;
                        ChimneyLeft.Add(pointTemp);

                    }

                }
                //


                //---1/2 chimeny right
                if (indexChimney + width < maxWidth)
                {
                    if ((i == indexDoor || i == indexDoor - 1) && indexChimney + width + 1 < maxWidth)
                    {
                        pointTemp.x = indexChimney + width + 1;
                        pointTemp.y = i;
                        ChimneyRight.Add(pointTemp);

                    }
                    else
                    {
                        pointTemp.x = indexChimney + width;
                        pointTemp.y = i;
                        ChimneyRight.Add(pointTemp);

                    }

                }
            }
            Chimney[0] = ChimneyLeft;
            Chimney[1] = ChimneyRight;

            return Chimney;
        }
        //---chimney bottom---
        static List<Struct.DIEM>[] ChimneyBottom(int indexDoor, int indexChimney)
        {
            int bottom = 25;
            int width = 8;
            int maxWidth = 120;
            Struct.DIEM pointTemp;
            pointTemp.x = 0;
            pointTemp.y = 0;
            List<Struct.DIEM> ChimneyLeftB = new List<Struct.DIEM>();
            List<Struct.DIEM> ChimneyRightB = new List<Struct.DIEM>();
            List<Struct.DIEM>[] ChimneyB = new List<Struct.DIEM>[2];
            //---Bottom chimney left--
            for (int i = indexDoor; i<= bottom; i++)
            {
                if (i == indexDoor||i==indexDoor+1)
                {
                    if (i == indexDoor)
                    {
                        for(int j = indexChimney-1;j <= indexChimney+ width; j++)
                        {
                            if (j < maxWidth)
                            {
                                pointTemp.x = j;
                                pointTemp.y = i;
                                ChimneyLeftB.Add(pointTemp);

                            }
                        }
                    }
                    else
                    {
                        pointTemp.x = indexChimney;
                        pointTemp.y = i;
                        ChimneyLeftB.Add(pointTemp);
                        pointTemp.x = indexChimney - 1;
                        pointTemp.y = i;
                        ChimneyLeftB.Add(pointTemp);

                    }

                }
                else
                {
                    pointTemp.x = indexChimney;
                    pointTemp.y = i;
                    ChimneyLeftB.Add(pointTemp);

                }
                //---bottom chimney right--
                if (indexChimney + width < maxWidth)
                {
                    if ((i == indexDoor || i == indexDoor + 1)&& indexChimney + width + 1 < maxWidth)
                    {
                        pointTemp.x = indexChimney + width + 1;
                        pointTemp.y = i;
                        ChimneyRightB.Add(pointTemp);
                    }
                    else
                    {
                        pointTemp.x = indexChimney + width ;
                        pointTemp.y = i;
                        ChimneyRightB.Add(pointTemp);
                    }
                }

            }
            ChimneyB[0] = ChimneyLeftB;
            ChimneyB[1] = ChimneyRightB;
            return ChimneyB;
            
        }

        // --vong lap game---
        static void LoopWriteFB(List<Struct.DIEM>[] Chimney)
        {
            int i = 119;
            while (i!=0)
            {

                Thread.Sleep(300);
                WriteChimney(Chimney);
                i--;


            }
        }
        //
        static void LoopFB()
        {
            int i = 119;
            Thread T1 = new Thread(() =>
            {
                while (i != 0)
                {
                    Thread.Sleep(200);
                    ChimneyFappyBrid(10, i);
                    i--;

                }

            });
            
            int j = 119;
            Thread T2 = new Thread(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(10));
                while (j != 0)
                {
                    Thread.Sleep(200);
                    ChimneyFappyBrid(13, j);
                    j--;

                }

            });
            int k = 119;
            Thread T3 = new Thread(() =>
            {
                Thread.Sleep(TimeSpan.FromSeconds(20));
                while (k != 0)
                {
                    Thread.Sleep(200);
                    ChimneyFappyBrid(6, k);
                    k--;

                }

            });

            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
        }
        //----in chimeny
        static void WriteChimney(List<Struct.DIEM>[] Chimney)
        {
            //--- write left chimney
            for (int i = 0; i< Chimney[0].Count; i++)
            {
                if (Chimney[0].Count > 0)
                {
                    Console.SetCursorPosition(Chimney[0][i].x, Chimney[0][i].y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }
            //---write right chimney.
            for (int i = 0; i < Chimney[1].Count; i++)
            {
                if (Chimney[1].Count > 0 )
                {
                    Console.SetCursorPosition(Chimney[1][i].x, Chimney[1][i].y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }

            }
            
        }

        //---
        static void WriteBlank(List<Struct.DIEM> chimeny)
        {
            for (int i = 0; i < chimeny.Count; i++)
            {
                if (chimeny.Count > 0 && chimeny[0].x <=chimeny[i].x)
                {
                    Console.SetCursorPosition(chimeny[i].x, chimeny[i].y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }


            }
        }

















    }
}
