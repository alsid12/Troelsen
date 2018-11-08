using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

            // Make a motorcycle.
            Motorcycle c = new Motorcycle(5, "Fred");
            c.SetDriverName("Billy");

            Console.WriteLine("Rider name is {0}", c.name);
            Console.ReadLine();
        }
    }
}
