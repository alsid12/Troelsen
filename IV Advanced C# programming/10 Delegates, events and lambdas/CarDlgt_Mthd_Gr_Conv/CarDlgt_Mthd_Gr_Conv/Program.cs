using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDlgt_Mthd_Gr_Conv
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Method with group conversion *****\n");
            Car c1 = new Car();
            c1.RegisterWithCarEngine(CallMeHere);

            Console.WriteLine("***** Speeding up! *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);

            // Unregister the simple method name.
            c1.unRegisterWithCarEngine(CallMeHere);

            c1.CurrentSpeed = 20;

            // No more notifications.
            Console.WriteLine("***** Speeding up! *****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        static void CallMeHere(string msg)
        {
            Console.WriteLine(" Message from Car: {0}", msg);
        }

    }
}
