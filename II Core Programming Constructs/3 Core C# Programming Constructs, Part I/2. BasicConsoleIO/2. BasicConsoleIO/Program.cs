using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BasicConsoleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Basic Console IO *****");
            //GetUserData();
            FormatNumericData();

            Console.ReadKey();
        }

        static void GetUserData()
        {
            // Get name and age.
            Console.WriteLine("Please enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age: ");
            string userAge = Console.ReadLine();

            // Change echo color, for fun.
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Echo to the console.
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);

            // Restores previous color.
            Console.ForegroundColor = prevColor;
        }


        static void FormatNumericData()
        {
            Console.WriteLine("The value 99999 in various formats: ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f9}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
        }
    }
}
