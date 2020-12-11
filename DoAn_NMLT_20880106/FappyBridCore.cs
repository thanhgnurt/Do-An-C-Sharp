using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DoAn_NMLT_20880106
{
    public struct POINT
    {
       public int X;
       public int Y;

    }
    public class FappyBridCore
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
            bool check = false;
            bool first = true;
           
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





                Thread.Sleep(100);
                PointChimneyLeftXY = CreatePointChimneyLeft(10, 5, c1);
                PointChimneyRightXY = CreatePointChimneyRight(10, 5, c1 + 8);
                PointChimneyLeftXY1 = CreatePointChimneyLeft(15, 6, c2);
                PointChimneyRightXY1 = CreatePointChimneyRight(15, 6, c2 + 8);
                PointChimneyLeftXY2 = CreatePointChimneyLeft(8, 5, c3);
                PointChimneyRightXY2 = CreatePointChimneyRight(8, 5,c3+ 8);
                PointChimneyLeftXY3 = CreatePointChimneyLeft(8, 5, i + 120);
                PointChimneyRightXY3 = CreatePointChimneyRight(8, 5, i + 128);
                WriteChimneyRight(PointChimneyRightXY);
                WriteChimneyLeft(PointChimneyLeftXY);
                WriteChimneyRight(PointChimneyRightXY1);
                WriteChimneyLeft(PointChimneyLeftXY1);
                WriteChimneyRight(PointChimneyRightXY2);
                WriteChimneyLeft(PointChimneyLeftXY2);
                //WriteChimneyRight(PointChimneyRightXY3);
               // WriteChimneyLeft(PointChimneyLeftXY3);
                if (i == -9)
                {
                    check = !check;
                    i = 120;
                    first = false;
                }
            }

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
