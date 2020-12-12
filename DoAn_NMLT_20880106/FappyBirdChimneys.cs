using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    
    public class FappyBirdChimneys:FappyBirdBird
    {
        
        //----function FB
        public static void FappyBrid()
        {
            List<POINT> PointChimneyLeftXY = new List<POINT>();
            List<POINT> PointChimneyRightXY = new List<POINT>();
            List<POINT> PointChimneyLeftXY1 = new List<POINT>();
            List<POINT> PointChimneyRightXY1 = new List<POINT>();
            List<POINT> PointChimneyLeftXY2 = new List<POINT>();
            List<POINT> PointChimneyRightXY2 = new List<POINT>();
            List<POINT> PointChimneyLeftXY3 = new List<POINT>();
            List<POINT> PointChimneyRightXY3 = new List<POINT>();
            int c1;
            int c2=160;
            int c3 = 200;
            int hChimney1 = 10;
            int spaceC1 = 5;
            int spaceC2 = 6;
            int spaceC3 = 5;
            int hChimney2 = 13;
            int hChimney3 = 7;
            bool check = false;
            bool first = true;
            int skip = 1;
            string direction = "MoveDown";
            Random randomObj = new Random();
            int hight = hightBird;
            POINT[] bird = new POINT[2];
            for (int i = 120; i>=-9; i--)
            {

                c1 = i;
                if(!check )
                {
                    c2 = c1 + 40;
                }
                
                if (c1 >= 80 && !first)
                {
                    c2 = 31 - 120 + c1;
                }
                if (check && c1<80)
                {
                    c2 = c1 + 40;
                }
               
                if (!check )
                {

                    c3 = c2 + 40;
                }
                if(c2>=80 && !first)
                {
                    c3 = 31 - 120 + c2;

                }
                if (check && c2 < 80)
                {
                    c3 = c2 + 40;
                }
                //reandom h and space
                if (c1 == 120)
                {
                    hChimney1 = randomObj.Next(5, 16);
                    spaceC1 = randomObj.Next(5, 7);
                }
                if (c2 == 120)
                {
                    hChimney2 = randomObj.Next(5, 17);
                    spaceC2 = randomObj.Next(5, 7);
                }
                if (c3 == 120)
                {
                    hChimney3 = randomObj.Next(5, 17);
                    spaceC3 = randomObj.Next(5, 7);
                }

                PointChimneyLeftXY = CreatePointChimneyLeft(hChimney1, spaceC1, c1);
                PointChimneyRightXY = CreatePointChimneyRight(hChimney1, spaceC1, c1 + 8);
                PointChimneyLeftXY1 = CreatePointChimneyLeft(hChimney2, spaceC2, c2);
                PointChimneyRightXY1 = CreatePointChimneyRight(hChimney2, spaceC2, c2 + 8);
                PointChimneyLeftXY2 = CreatePointChimneyLeft(hChimney3, spaceC3, c3);
                PointChimneyRightXY2 = CreatePointChimneyRight(hChimney3, 5,c3+ 8);
                WriteChimneyRight(PointChimneyRightXY);
                WriteChimneyLeft(PointChimneyLeftXY);
                WriteChimneyRight(PointChimneyRightXY1);
                WriteChimneyLeft(PointChimneyLeftXY1);
                WriteChimneyRight(PointChimneyRightXY2);
                WriteChimneyLeft(PointChimneyLeftXY2);
                if (c1 > 25 && c1 < 32)
                {

                    for(int k = 0; k< PointChimneyLeftXY.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY[k].Y)
                        {
                            //===end game
                            i = -20;
                           
                        }
                    }
                    if (c1 == 26)
                    {
                        score++;
                        PrintScore();
                    }
                }
                if (c2 > 25 && c2 < 32)
                {
                    for (int k = 0; k < PointChimneyLeftXY1.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY1[k].Y)
                        {
                            //===end game
                            i = -20;
                        }
                    }
                    if (c2 == 26)
                    {
                        score++;
                        PrintScore();
                    }
                }
                if (c3 > 25 && c3 < 32)
                {
                    for (int k = 0; k < PointChimneyLeftXY2.Count; k++)
                    {
                        if (hightBird == PointChimneyLeftXY2[k].Y)
                        {
                            //===end game
                            i = -20;
                        }
                    }
                    if (c3 == 26)
                    {
                        score++;
                        PrintScore();
                    }
                }
                if(hightBird ==2 || hightBird == 27)
                {
                    //end game
                    i = -20;
                }
                Thread.Sleep(50);
                pointBir[0].Y = hightBird;
                pointBir[1].Y = hightBird;
                bird = pointBir;
                if (evenSpace)
                {
                    direction = "MoveUp";
                } else
                {
                    direction = "MoveDown";
                }
                if (direction == "MoveUp")
                {
                    WriteBird(ref bird, direction);
                    direction = "MoveDown";
                    evenSpace = false;

                }
                if(skip == 1 && direction=="MoveDown")
                {

                    WriteBird(ref bird,direction);
                }
                if (i == -9)
                {
                    check = !check;
                    i = 120;
                    first = false;
                }
                
                    skip++;

                if(skip == 2)
                {
                    skip = 1;
                }


            }
            GameOverFB();

        }


        //---function create chimney XY left----
        public static List<POINT> CreatePointChimneyLeft(int heightChT, int spaceChs, int x)
        {
            int top = 2;
            int bottom = 26;
            int widthCh = 8;
            List<POINT> PointXY = new List<POINT>();
            POINT temp;
            //----chimneyX topleft---
            for (int i = top; i<=heightChT; i++)
            {
                if (i<heightChT-1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if (i == heightChT-1)
                {
                    temp.X = x - 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                    temp.X = x ;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                //---head chimneyX---
                if (i == heightChT)
                {
                    for(int j = -1; j< widthCh-1; j++)
                    {
                        temp.X = x + j;
                        temp.Y = i;
                        PointXY.Add(temp);
                    }
                }
            }
            //----chimneyX bottomleft---
            for (int i = bottom; i >= (heightChT + spaceChs) ; i--)
            {
                if(i > heightChT + spaceChs + 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if (i == heightChT + spaceChs + 1)
                {
                    temp.X = x - 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                if(i== heightChT+ spaceChs)
                {
                    for(int j = -1; j<widthCh-1; j++)
                    {
                        temp.X = x + j;
                        temp.Y = i;
                        PointXY.Add(temp);
                    }
                }
            }

            return PointXY;
        }

        //--function create chimney XY right---
        public static List<POINT> CreatePointChimneyRight(int heightChT, int spaceChs, int x)
        {
            int top = 2;
            int bottom = 26;
            List<POINT> PointXY = new List<POINT>();
            POINT temp;
            //----chimneyX top right---
            for (int i = top; i <= heightChT; i++)
            {
                if (i < heightChT - 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                else
                {
                    temp.X = x + 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
               
            }
            //----chimneyX bottomleft---
            for (int i = bottom; i >= (heightChT + spaceChs); i--)
            {
                if (i > heightChT + spaceChs + 1)
                {
                    temp.X = x;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
                else
                {
                    temp.X = x + 1;
                    temp.Y = i;
                    PointXY.Add(temp);
                }
            }

            return PointXY;

        }









        //----write chimney---
        static void WriteChimneyLeft(List<POINT> chimneys)
        {
            for (int i =0; i< chimneys.Count; i++)
            {
                if(chimneys[i].X< 120 && chimneys[i].X>=0)
                {
                    Console.SetCursorPosition(chimneys[i].X, chimneys[i].Y);
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" ");
                }
            }
        }
        //----write chimney---
        static void WriteChimneyRight(List<POINT> chimneys)
        {
            for (int i = 0; i < chimneys.Count; i++)
            {
                if(chimneys[i].X < 120 && chimneys[i].X >= 0)
                {
                    Console.SetCursorPosition(chimneys[i].X, chimneys[i].Y);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(" ");
                }
                
            }
        }





        //end
    }
}
