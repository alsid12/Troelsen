using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ThreeDCircle : Circle
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }

        // Hide PetName property above me.
        public new string PetName { get; set; }
    }
}
