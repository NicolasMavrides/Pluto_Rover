# Pluto Rover

**Rough idea and development steps:**

1. Program should store the planet grid as a multidimensional array (eg. a 2D array of 0s) 

2. The rover should be represented as a Rover object with its coordinates and heading stored as properties.

3. Start with a program that accepts a single character as input and performs a single move. Rover's position must be updated every time a command is issued.

4. Implement the "wrapping" technique to account for the fact Pluto is a sphere (eg. if rover is at (0,99,'E') on a 100x100 grid and 'F' command is given,
   new position should be (0,0,'E') ).

5. Program should then be able to take a string input of custom size, and iterate over the input to execute one command at a time.

6. Modify some random elements of the 2D array to specify whether there is an "obstacle" at that coordinate point (eg. if we have an array of 0s, change some random 0s 
   to 1s so that 0 = clear and 1 = obstacle). If the next coordinate point for the rover to move to is an obstacle, then skip the corresponding command.

----------------------------------------------------------------------------------------------------------------------------------------

**Further changes for improvement / Conclusions:**

1. Make planet grid size customisable.

2. Due to time constraints, obstacle detection and test cases for multi-command execution (ie. testing output when a string of commands is given)
   were not completed on time, so these are considered as further additions in a potential future iteration.

3. Implement a more realistic model for the planet's surface; for instance if the rover where to continuously move south, eventually 
   it would move over the south pole and eventually be facing North again. The program in its current form however does not account for this.
   
4. The movement methods could have been implemented in an alternative way; instead of issuing movement towards North/South/East/West directions,
   the rover could instead have only 2 methods, 1 for forward and 1 for backward and have each method determine the rover's direction and modify
   the appropriate coordinate points, instead of doing it before calling the movement methods. This admittedly could be considered an error in
   approach to the problem solution.
