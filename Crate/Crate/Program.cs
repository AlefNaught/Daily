using System;

namespace Crate
{

    class Rectangle
    {
        int x { get; set; }
        int y { get; set; }
        int z { get; set; }

        public Rectangle(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public int GetX()
        {
            return x;

        }

        public int GetY()
        {
            return y;
        }

        public int GetZ()
        {
            return z;
        }
    } // end of Rectangle

    public class Box
    {
        int x { get; set; }
        int y { get; set; }
        int z { get; set; }

        public Box(int X, int Y, int Z)
        {
            x = X;
            y = Y;
            z = Z;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetZ()
        {
            return z;
        }

    } // end of Box


    public class MainClass
    {
        public static void Main(string[] args)
        {
            Rectangle R = new Rectangle(12, 34, 56);
            Box B = new Box(7, 8, 9);
            int totalOld = 0;
            int totalNew = 0;
            int recX = R.GetX();
            int recY = R.GetY();
            int recZ = R.GetZ();
            int boxX = B.GetX();
            int boxY = B.GetY();
            int boxZ = B.GetZ();
            int valX = 0;
            int valY = 0;
            int valZ = 0;

            for (int i = 0; i < 6; i++)
            {
                var numbers = doAKickFlip(boxX, boxY, boxZ, i);
                valX = recX / numbers.Item1;
                valY = recY / numbers.Item2;
                valZ = recZ / numbers.Item3;

                totalNew = valX * valY * valZ;

                if (i == 0)
                {
                    totalOld = totalNew;
                    totalNew = 0;
                }
                if (totalNew > totalOld)
                {
                    totalOld = totalNew;
                    totalNew = 0;
                }
            }

            Console.WriteLine(totalOld);

        }// end of main class

        public static Tuple<int, int, int> doAKickFlip(int x, int y, int z, int i)
        {
            if (i == 1)
            {
                int temp = y;
                y = z;
                z = temp;
            }

            if (i == 2)
            {
                int temp = y;
                y = x;
                x = temp;
            }
            if (i == 3)
            {
                int temp = z;
                z = y;
                y = x;
                x = temp;

            }

            if (i == 4)
            {
                int temp = z;
                z = x;
                x = temp;
            }
            if (i == 5)
            {
                int temp = z;
                z = x;
                x = y;
                y = temp;
            }
            return Tuple.Create(x, y, z);

        }
    }

}
