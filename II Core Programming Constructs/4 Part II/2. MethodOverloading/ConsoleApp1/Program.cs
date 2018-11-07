using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with method overloading *****\n");

            // Calls int version of Add().
            Console.WriteLine(Add(10, 10));
            
            // Calls long version of Add().
            Console.WriteLine(Add(90000000000000, 9000000000000));

            // Calls double version of Add().
            Console.WriteLine(Add(4.3, 3.3));

            Console.ReadLine();
        }

        //Overloaded Add() method.
        static int Add(int x, int y)
        { return x + y; }

        static double Add(double x, double y)
        { return x + y; }

        static long Add(long x, long y)
        { return x + y; }
    }
}
