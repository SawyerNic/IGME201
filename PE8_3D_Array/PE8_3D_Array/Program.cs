using System;
using System.IO;

namespace numba
{
    class test
    {
        static void Main()
        {

            //we have to compute the value of z in z = 3y^2 + 2x - 1
            double x;
            double y;
            double z;
            double[,,] numArr = new double[21, 31, 3];
            int nx = 0;
            int ny = 0;


            for (x = -1; x <= 1; x += .1)
            {
                x = Math.Round(x, 1);

                for (y = 1; y <= 4; y += .1)
                {
                    y = Math.Round(y, 1);

                    z = 3 * Math.Pow(y, 2) + 2 * x - 1;
                    z = Math.Round(z, 3);
                    //Console.WriteLine(x + " " + y + " " + z);

                    numArr[nx, ny, 0] = x;
                    numArr[nx, ny, 1] = y;
                    numArr[nx, ny, 2] = z;

                    ny++;
                }

                nx++;
                ny = 0;
            }
        }
    }
}
