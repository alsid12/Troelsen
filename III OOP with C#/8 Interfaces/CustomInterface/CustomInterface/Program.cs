using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");
            // Call Points property defined by IPointy.
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0}", hex.Points);

            // Catch a possible InvalidCastException
            Circle c = new Circle("Lisa");
            IPointy itfPt = null;

            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }

            // Make an array of Shapes.
            Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            for (int i = 0; i < myShapes.Length; i++)
            {
                myShapes[i].Draw();

                // Who's Pointy?
                if (myShapes[i] is IPointy ip)
                    Console.WriteLine("-> Points: {0}", ip.Points);
                else
                    Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
                //if (myShapes[i] is IDraw3D)
                //    DrawIn3D((IDraw3D)myShapes[i]);
            }

            for (int i = 0; i < myShapes.Length; i++)
            {
                // Can I draw you in 3D?
                
            }


            Console.ReadLine();
        }

        // I'll draw anyone supporting IDraw3D.
        static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }
    }
}
