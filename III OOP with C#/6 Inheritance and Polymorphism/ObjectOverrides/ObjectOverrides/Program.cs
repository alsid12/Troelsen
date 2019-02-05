using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with System.Object *****\n");
            //Person p1 = new Person();

            //// Use inherited members of System.Object
            //Console.WriteLine("ToString: {0}", p1.ToString());
            //Console.WriteLine("Hash code {0}", p1.GetHashCode());
            //Console.WriteLine("Type {0}:", p1.GetType());

            //// Make some other references to p1.
            //Person p2 = p1;
            //object o = p2;

            //// Are the references pointing to the same object in memory?
            //if (o.Equals(p1) && p2.Equals(o))
            //    Console.WriteLine("Same instance!");

            Console.WriteLine("Testing modified Person class\n");

            Person p1 = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);

            // Get stringified version of objects.
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());

            // Test overriden Equals().
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");

            // Test hash codes.
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");

            // Change age of p2 and test again:
            p2.Age = 45;
            Console.WriteLine("p1.ToString() = {0}", p1.ToString());
            Console.WriteLine("p2.ToString() = {0}", p2.ToString());
            Console.WriteLine($"p1 = p2?: {p1.Equals(p2)}");
            Console.WriteLine($"Same hash codes?: {p1.GetHashCode() == p2.GetHashCode()}");

            Console.ReadLine();
        }
    }
}
