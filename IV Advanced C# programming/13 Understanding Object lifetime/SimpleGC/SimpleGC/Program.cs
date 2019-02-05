using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** GC BAsics *****\n");

            // Create a new Car object on the managed heap. We are returned a reference to his object ("refToMyCar").
            Car refToMyCar = new Car("Zippy", 50);

            // The C# dot operator (.) is used to invoke members of the object using our reference variable.
            Console.WriteLine(refToMyCar.ToString());
            Console.ReadLine();

        }
    }
}
