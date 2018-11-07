using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    // Classes are always reference types.
    class PointRef
    {
        // Same members as in the Point structure...
        // Fields.
        public int X;
        public int Y;

        // Custom constructor.
        public PointRef(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        // Add 1 to the (X, Y) position.
        public void Increment()
        {
            X++; Y++;
        }

        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }

        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }
}
