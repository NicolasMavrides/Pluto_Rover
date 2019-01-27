using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluto_Rover
{
    [TestFixture]
    class Tests
    {
        [TestCase]
        public void MovementTests()         // Test that Rover movement methods return expected x or y positions
        {
            Rover test = new Rover(23, 57, 0);
            // Simulate a simple North -> South -> East -> West movement
            Assert.AreEqual(58, test.MoveNorth(test));
            Assert.AreEqual(57, test.MoveSouth(test));
            Assert.AreEqual(24, test.MoveEast(test));
            Assert.AreEqual(23, test.MoveWest(test));

            // Test the grid wrapping with simple East -> West -> North - South movement
            Rover test_2 = new Rover(99, 99, 1);
            Assert.AreEqual(0, test_2.MoveEast(test_2));
            Assert.AreEqual(99, test_2.MoveWest(test_2));
            Assert.AreEqual(0, test_2.MoveNorth(test_2));
            Assert.AreEqual(99, test_2.MoveSouth(test_2));
        }

        [TestCase]
        public void TurningTests()         // Test that Rover movement methods return expected x or y positions
        {
            Rover test = new Rover(0, 0, 3);
            // Simulate a simple Right -> Right -> Left -> Left turn, including wrapping around the headings array
            Assert.AreEqual(0, test.TurnRight(test));
            Assert.AreEqual(1, test.TurnRight(test));
            Assert.AreEqual(0, test.TurnLeft(test));
            Assert.AreEqual(3, test.TurnLeft(test));
        }

    }
}