using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SimpleCSharpApp
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("******* My 1st app ******");
            Console.WriteLine("Hello World!");

            // Helper methid within the Program Class.
            ShowEnvironmentDetails();

            Console.ReadKey();

            

            return 0;
        }

        private static void ShowEnvironmentDetails()
        {
            //throw new NotImplementedException();
            // Print out the drives on this machine, and other interesting details.
            foreach (var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }

            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processes: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET version: {0}", Environment.Version);
        }
    }

        
}
