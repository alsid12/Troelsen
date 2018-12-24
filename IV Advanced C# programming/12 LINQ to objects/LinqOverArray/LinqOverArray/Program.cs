using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with LINQ to objects *****\n");
            //QueryOverStrings();
            //QueryOverStringsWithExtensionMethods();
            QueryOverInts();
            Console.ReadLine();
        }

        static void QueryOverStrings()
        {
            // An array of strings.
            string[] currentVideoGames = {"Red Dead Redemtopn 2", "Mario", "Fallout 3", "Daxter", "Morrowind" };

            // Build a query expression to find the items in the array that have an embedded space.
            var subset = from g
                                         in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;

            ReflectOverQueryResults(subset);

            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);

            
        }

        static void QueryOverStringsWithExtensionMethods()
        {
            // The same array of strings as in previous method.
            string[] currentVideoGames = { "Red Dead Redemtopn 2", "Mario", "Fallout 3", "Daxter", "Morrowind", "World Of Tanks", "Prince of Persia" };

            // Build a query expression which finds the elements with embedded spaces.
            IEnumerable<string> subset = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            ReflectOverQueryResults(subset, "Extension Methods");

            foreach (string s in subset)
                Console.WriteLine("Item: {0}", s);
        }

        static void ReflectOverQueryResults(object resultSet, string queryType = "Query Expressions")
        {
            Console.WriteLine($"***** Info about your query using {queryType} *****");
            Console.WriteLine("resultSet is of type: {0}", resultSet.GetType().Name);
            Console.WriteLine("resultSet location: {0}", resultSet.GetType().Assembly.GetName().Name);
        }

        static void QueryOverInts()
        {
            int[] numbers = { 10, 20 ,30, 40, 1, 2, 3, 8 };

            //Print only items less than 10.
            var subset = from i in numbers where i < 10 select i;



            foreach (int i in subset)
            {
                Console.WriteLine($"Item {i}");
            }

            ReflectOverQueryResults(subset);
        }
    }
}
