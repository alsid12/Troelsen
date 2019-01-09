using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SimpleException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple exception example *****\n");
            Console.WriteLine("=> creating a car and stepping on it!");
            Car myCar = new Car("Zippy", 35);
            myCar.CrankTunes(true);


            try
            {
                for (int i = 0; i < 10; i++)
                {
                    myCar.Accelerate(10);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n *** Error! ***");
                Console.WriteLine("Member name: {0}", e.TargetSite);
                Console.WriteLine("Class defining member: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Member type: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Method: {0}", e.Source);
                Console.WriteLine("Stack: {0}", e.StackTrace);
            }
            
            // The error has been handled, processing continues with the next statement.
            Console.WriteLine("\n ***** Out of exception logic *****");
            Console.ReadLine();
        }
    }
}
