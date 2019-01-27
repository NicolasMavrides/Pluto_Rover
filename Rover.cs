using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto_Rover
{
    public class Rover
    {
        // properties
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int headingNum { get; set; }

        // contructor
        public Rover(int xpos, int ypos, int headingnum)
        {
            xPos = xpos;
            yPos = ypos;
            headingNum = headingnum;
        }

        // movement methods
        public int MoveNorth(Rover rover)
        {
            rover.yPos += 1;
            return yPos;
        }

        public int MoveSouth(Rover rover)
        {
            rover.yPos -= 1;
            return yPos;
        }

        public int MoveEast(Rover rover)
        {
            rover.xPos += 1;
            return xPos;
        }

        public int MoveWest(Rover rover)
        {
            rover.xPos -= 1;
            return xPos;
        }

        // turn methods
        public int TurnRight(Rover rover)
        {
            rover.headingNum += 1;

            // prevent out of bounds error in the heading array by setting to 0 (ie. so if facing W, set to N which is the next heading)
            if (rover.headingNum > 3)
            {
                rover.headingNum = 0;
            }

            return rover.headingNum;
        }

        public int TurnLeft(Rover rover)
        {
            rover.headingNum -= 1;

            // prevent out of bounds error in the heading array by setting to 3 (ie. so if facing N, set to W which is the next heading)
            if (rover.headingNum < 0)
            {
                rover.headingNum = 3;
            }

            return rover.headingNum;
        }

    }
}
