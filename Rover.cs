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
        public int MoveNorth(Rover rover, int yPos)
        {
            yPos+= 1;
            rover.yPos = yPos;
            return yPos;
        }

        public int MoveSouth(Rover rover, int yPos)
        {
            yPos -= 1;
            rover.yPos = yPos;
            return yPos;
        }

        public int MoveEast(Rover rover, int xPos)
        {
            xPos += 1;
            rover.xPos = xPos;
            return xPos;
        }

        public int MoveWest(Rover rover, int xPos)
        {
            xPos -= 1;
            rover.xPos = xPos;
            return xPos;
        }

    }
}
