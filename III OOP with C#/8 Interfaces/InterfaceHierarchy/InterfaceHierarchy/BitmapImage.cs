using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    class BitmapImage: IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        public void DrawInBoundingBox(int top, int left, int right, int bottom)
        {
            Console.WriteLine("Drawing in a box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
    }
}
