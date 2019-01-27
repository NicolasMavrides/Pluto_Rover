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

            // rover object instance. Starting position 0,0 and facing North
            Rover rover = new Rover(0, 0, 0);
            String roverHeading = headings[rover.headingNum];

            String command = Console.ReadLine();

            while (command != "Q")
            {
                if (command == "F")
                {
                    rover.MoveNorth(rover);
                    Console.Write("New rover position: "+rover.xPos + "," + rover.yPos+" and facing "+headings[rover.headingNum]);
                }
                else if (command == "B")
                {
                    rover.MoveSouth(rover);
                    Console.Write("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + headings[rover.headingNum]);
                }
                else if (command == "R")
                {
                    rover.TurnRight(rover);
                    Console.Write("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + headings[rover.headingNum]);
                }
                else if (command == "L")
                {
                    rover.TurnLeft(rover);
                    Console.Write("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + headings[rover.headingNum]);
                }

                command = Console.ReadLine();
            }

        }
    }
}
