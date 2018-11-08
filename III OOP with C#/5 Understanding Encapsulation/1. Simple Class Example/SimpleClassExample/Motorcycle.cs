using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;

        // Constructor chaining.
        public Motorcycle()
        {
            Console.WriteLine("In default constructor");
        }

        public Motorcycle(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In ctor taking an int");
        }

        public Motorcycle(string name) : this(0, name)
        {
            Console.WriteLine("In ctor taking a string");
        }

        // This is the master constructor making the real work.
        public Motorcycle(int intensity, string name)
        {
            Console.WriteLine("In master constructor");
            if (intensity > 10)
            {
                intensity = 10;
            }

            driverIntensity = intensity;
            this.name = name;
        }

        public void SetDriverName(string name)
        {
            this.name = name;
        }


    }
}
