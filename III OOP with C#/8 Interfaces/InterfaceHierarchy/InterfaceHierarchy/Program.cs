using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple interface hierarchy *****\n");
            

            // Call from object level!
            BitmapImage myBitMap = new BitmapImage();
            myBitMap.Draw();
            myBitMap.DrawInBoundingBox(10, 10, 100, 150);
            myBitMap.DrawUpsideDown();

            // Get IAdvancedDraw explicitly.
            IAdvancedDraw iAdvDraw = myBitMap as IAdvancedDraw;
            if (iAdvDraw != null)
            {
                iAdvDraw.DrawUpsideDown();
            }

            Console.ReadLine();

        }
    }
}
