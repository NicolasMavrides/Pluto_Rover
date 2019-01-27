using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto_Rover
{
    public class Rover
    {
        public int xPos { get; set; }
        public int yPos { get; set; }
        public int headingNum { get; set; }

        public Rover(int xpos, int ypos, int headingnum)
        {
            xPos = xpos;
            yPos = ypos;
            headingNum = headingnum;
        }

    }
}
