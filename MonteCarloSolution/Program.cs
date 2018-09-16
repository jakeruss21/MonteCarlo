using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int totalPairs = 1000;
            Coordinates[] coords = new Coordinates[totalPairs];
            double hypotCount = 0;
            double mcPI = 0.0;
            double absDiff = 0;

            for(int i = 0; i < coords.Length; i++) // insert coordinate pairs into array of coordinates
            {
                coords[i] = new Coordinates(totalPairs);
                Console.WriteLine($"{coords[i].xCoord}, {coords[i].yCoord}"); //Used to check 'randomness'
                System.Threading.Thread.Sleep(31); // Used because if there isn't a pause between numbers many of the coordinates repeat themselves
            }

            hypotCount = ManipulateCoordinates.PointInCircle(coords);

            mcPI = ((hypotCount / coords.Length) * 4);
            absDiff = Math.Abs((mcPI - Math.PI));

            Console.WriteLine($"PI with a value of:    {Math.PI}");
            Console.WriteLine($"Estimated PI value of: {mcPI}");
            Console.WriteLine($"Absolute difference of: {absDiff}");

        }
    }
}
