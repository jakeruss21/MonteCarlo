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
            Random rand = new Random();
            int totalPairs = 0;
            double xCoord = 0;
            double yCoord = 0;
            Boolean answer = false;

            Console.WriteLine("Please enter number of desired points: ");
            do
            {

                try
                {
                    totalPairs = int.Parse(Console.ReadLine());
                    answer = true;
                }
                catch (Exception)
                {
                    Console.Write("Please enter a valid number:  ");
                    answer = false;
                }
            } while (answer == false);

            Coordinates[] coords = new Coordinates[totalPairs];
            double hypotCount = 0;
            double mcPI = 0.0;
            double absDiff = 0;

            for(int i = 0; i < coords.Length; i++) // insert coordinate pairs into array of coordinates
            {
                xCoord = rand.NextDouble();
                yCoord = rand.NextDouble();
                coords[i] = new Coordinates(xCoord, yCoord);
                Console.WriteLine($"{coords[i].xCoord}, {coords[i].yCoord}"); //Used to check 'randomness'
                //System.Threading.Thread.Sleep(31); // Used because if there isn't a pause between numbers many of the coordinates repeat themselves
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
