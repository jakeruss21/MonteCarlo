using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSolution
{

    struct Coordinates
    {
        public double xCoord, yCoord;

        public Coordinates(double x, double y) // creates coordinates for each point
        {
            Random rand = new Random();

            this.xCoord = x;
            this.yCoord = y;
        }

    }

    class ManipulateCoordinates
    {

        public static double Hypoteneus(double xCoord, double yCoord)
        {
            double hypot = 0.0;
            double firstPart = 0.0;

            firstPart = Math.Pow(xCoord, 2) + Math.Pow(yCoord, 2);
            hypot = Math.Sqrt(firstPart);

            return hypot;
        }

        public static double PointInCircle(Coordinates[] coordArray)
        {
            double hypot = 0.0;
            double hypotCount = 0.0;

            for (int i = 0; i < coordArray.Length; i++) // 
            {
                hypot = Hypoteneus(coordArray[i].xCoord, coordArray[i].yCoord);

                if (hypot <= 1)
                {
                    hypotCount++;
                }
            }

            return hypotCount;
        }

    }
}
