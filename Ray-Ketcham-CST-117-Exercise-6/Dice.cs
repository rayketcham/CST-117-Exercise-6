//Name: Ray Ketcham
//Class: CST-117
//Instructor: Dr. Smithers
//Date: 08/01/2018
using System;

namespace Ray_Ketcham_CST_117_Exercise_6
{
    class Die
    {
        Random genRandNumb = new Random();
        public int numberOfSides { get; set; }
        public int rollCount { get; set; }

        public Die()
        {
            numberOfSides = 6;
        }

        public int rollDie()
        {
            rollCount++;
            return genRandNumb.Next(1, numberOfSides + 1);
        }

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }
    }
}