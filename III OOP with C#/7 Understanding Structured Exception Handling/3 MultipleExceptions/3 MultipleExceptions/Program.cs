using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_MultipleExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
                // Trip Arg out of range exception.
                //myCar.Accelerate(-10);
            }
            catch (Exception e2)
            {
                // Throw an exception that records the new exception, as well as the message of the first exception.
                throw new CarIsDeadException(e2.Message, e2);
            }
            //catch (CarIsDeadException e)
            //{
            //    Console.WriteLine(e.Message);
            //    // Attempt to open a file named carErrors.txt on the C drive.
            //    FileStream fs = File.Open(@"C:\carErrors.txt", FileMode.Open);
            //}
            //catch (ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception e)
            //{
            //    // Process all other exceptions?
            //    Console.WriteLine(e.Message);
            //}
            Console.ReadLine();
        }
    }
}
