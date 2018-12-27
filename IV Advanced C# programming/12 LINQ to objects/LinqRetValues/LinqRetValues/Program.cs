using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** LINQ return values *****\n");
            IEnumerable<string> subset = GetStringSubset();

            foreach (string s in subset)
                Console.WriteLine(s);

            foreach (string item in GetStringSubsetAsArray())
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        static IEnumerable<string> GetStringSubset()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Purple"};

            //Note subset is an IEnumeranble<string>-compatible object.
            IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;

            return theRedColors;
        }

        static string[] GetStringSubsetAsArray()
        {
            string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Purple" };

            //Note subset is an IEnumeranble<string>-compatible object.
            var theRedColors = from c in colors where c.Contains("Red") select c;

            // Map results into an array.
            return theRedColors.ToArray();
        }
    }
}
