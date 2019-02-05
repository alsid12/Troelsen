using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle : Circle, IDraw3D
    {
        public new void Draw()
        {
            Console.WriteLine("Drawing a 3D circle");
        }

        // Hide PetName property above me.
        public new string PetName { get; set; }

        public void Draw3D()
        {
            Console.WriteLine("Drawing Circle in 3D!");
        }
    }
}
