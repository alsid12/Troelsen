using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypeContainingRefType();
            Console.ReadLine();
        }

        static void AssignRefTypes()
        {
            Console.WriteLine("Assigning reference types \n");
            PointRef p1 = new PointRef(10, 10);
            PointRef p2 = p1;

            // Print both point refs.
            p1.Display();
            p2.Display();

            // Change p1.X and print again.
            p1.X = 100;
            Console.WriteLine("\n => Changed p1.X \n");
            p1.Display();
            p2.Display();
        }

        static void ValueTypeContainingRefType()
        {
            // Create first Rectangle.
            Console.WriteLine("-> Creating r1");
            Rectangle r1 = new Rectangle("First rect", 10, 10, 50, 50);

            // Now assign a new Rectangle to r1.
            Console.WriteLine("-> Assigning r2 to r1");
            Rectangle r2 = r1;

            // Change some values of r2.
            Console.WriteLine("-> Changing values of r2");
            r2.rectInfo.infoString = "This is new info!";
            r2.rectBottom = 444;

            //Prints values of both rectangles.
            r1.Display();
            r2.Display();
        }
    }

    struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

        // Custom constructor.
        public Point(int xPos, int yPos)
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

    struct Rectangle
    {
        // The rectangle structure contains a reference type member.
        public ShapeInfo rectInfo;

        public int rectTop, rectLeft, rectBottom, rectRight;

        public Rectangle(string info, int top, int left, int bottom, int right)
        {
            rectInfo = new ShapeInfo(info);
            rectTop = top;
            rectBottom = bottom;
            rectLeft = left;
            rectRight = right;
        }

        public void Display()
        {
            Console.WriteLine("String = {0}, top = {1}, Bottom = {2}, Left = {3}, Right = {4}", rectInfo.infoString, 
                rectTop, rectBottom, rectLeft, rectRight);
        }
    }
}
