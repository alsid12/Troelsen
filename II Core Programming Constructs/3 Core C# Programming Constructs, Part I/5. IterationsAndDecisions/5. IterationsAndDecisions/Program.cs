using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IterationsAndDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ForLoopExample();
            //ForEachLoopExample();
            //LinqQueryOverInts();
            WhileLoopExample();
            Console.ReadKey();
        }

        // A basic for loop.
        static void ForLoopExample()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
        }

        static void ForEachLoopExample()
        {
            string[] carTypes = { "Ford", "BMW", "Toyota" };
            foreach (var c in carTypes)
            {
                Console.WriteLine(c);
            }

            int[] myInts = { 10, 20, 30, 40 };
            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }
        }

        static void LinqQueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 23, 254 };

            // LINQ query!
            var subset = from i in numbers where i < 10 select i;
            Console.WriteLine("Values in subset: ");
            foreach (var i in subset)
            {
                Console.WriteLine("{0} ", i);
            }
        }
        static void WhileLoopExample()
        {
            string userIsDone = "";
            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.WriteLine("In while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
        }
        static void DoWhileLoopExample()
        {
            string userIsDone = "";
            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            }
            while (userIsDone.ToLower() != "yes"); // Note the semicolon!
        }
    }
}
