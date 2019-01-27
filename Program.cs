using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto_Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            // planet grid dimensions
            const int GRID_LENGTH = 100;
            const int GRID_HEIGHT = 100;

            // initialise a grid of zeros to represent Pluto's surface
            int[,] planet_grid = new int[GRID_LENGTH, GRID_HEIGHT];

            // position headings for North, East, South and West, whose index numbers correspond to each (eg. 0 = N)
            String[] headings = { "N", "E", "S", "W" };

            // rover object instance
            Rover rover = new Rover(0, 0, 0);

            String roverHeading = headings[rover.headingNum];

            Console.WriteLine("Coordinates of rover: ");
            Console.WriteLine(rover.xPos);
            Console.WriteLine(rover.yPos);
            Console.WriteLine(roverHeading);

        }
    }
}
