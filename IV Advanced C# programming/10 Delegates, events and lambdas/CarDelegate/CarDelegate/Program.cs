using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Delegates as event enablers ******\n");

            // First, make a Car object.
            Car c1 = new Car("Slugbug", 100, 10);

            // Now, tell the car which method to call when it wants to send us messages.
            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            // This time, hold onto the delegate object, so we can unregister later.
            Car.CarEngineHandler handler2 = new Car.CarEngineHandler(OnCarEngineEvent2);
            c1.RegisterWithCarEngine(handler2);

            // Speed up (this will trigger the events).
            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();

            // Unregister from the second handler.
            c1.unRegisterWithCarEngine(handler2);

            c1.CurrentSpeed = 30;

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
            {
                c1.Accelerate(20);
            }
            Console.ReadLine();

        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n***** Message from Car object *****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("************************\n");
        }

        public static void OnCarEngineEvent2(string msg)
        {
            Console.WriteLine("\n***** Message from Car object *****");
            Console.WriteLine("=> {0}", msg.ToUpper());
            Console.WriteLine("************************\n");
        }
    }
}
