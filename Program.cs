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
             

            Console.WriteLine("Enter a command: ");
            String command = Console.ReadLine();

            while (command != "Q")
            {
                // If a string of commands is given, then it must be broken down so each command is executed one at a time
                for (int i=0; i < command.Length; i++)
                {
                    ExecuteCommand(rover, command[i].ToString(), headings);
                }

                command = Console.ReadLine();
            }

        }

        public static void ExecuteCommand(Rover rover, String command, String[] headings)
        {
            String roverHeading = headings[rover.headingNum];

            if ((command == "F" && roverHeading == "N") || (command == "B" && roverHeading == "S"))
            {
                rover.MoveNorth(rover);
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else if ((command == "B" && roverHeading == "N") || (command == "F" && roverHeading == "S"))
            {
                rover.MoveSouth(rover);
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else if ((command == "F" && roverHeading == "E") || (command == "B" && roverHeading == "W"))
            {
                rover.MoveEast(rover);
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else if ((command == "F" && roverHeading == "W") || (command == "B" && roverHeading == "E"))
            {
                rover.MoveWest(rover);
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else if (command == "R")
            {
                rover.TurnRight(rover);
                roverHeading = headings[rover.headingNum];
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else if (command == "L")
            {
                rover.TurnLeft(rover);
                roverHeading = headings[rover.headingNum];
                Console.WriteLine("New rover position: " + rover.xPos + "," + rover.yPos + " and facing " + roverHeading);
            }
            else
            {
                Console.WriteLine("Unknown command...");
            }
        }

    }
}
