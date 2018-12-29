using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions ******\n");

            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[] {
                new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},
                new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},
                new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},
                new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},
                new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},
                new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
            };

            // We will call various methods here!
            SelectEverything(itemsInStock);

            Console.WriteLine();
            ListProductNames(itemsInStock);

            Console.WriteLine();
            GetOverStock(itemsInStock);

            Console.WriteLine();
            GetNamesAndDescriptions(itemsInStock);

            Console.WriteLine();
            Array objs = GetProjectedSubset(itemsInStock);
            foreach (object o in objs)
                Console.WriteLine(o);

            Console.WriteLine("Get count from query");
            GetCountFromQuery();

            Console.WriteLine("Reversed list of products:");
            ReverseEverything(itemsInStock);

            Console.WriteLine("Aplhabetized list of products:");
            AlphabetizeProductNames(itemsInStock);

            Console.WriteLine();
            DisplayDiff();

            Console.WriteLine();
            DisplayIntersection();

            Console.WriteLine();
            DisplayUnion();

            Console.ReadLine();
        }

        static void SelectEverything(ProductInfo[] products)
        {
            // Get everything from collection!
            Console.WriteLine("All product details:");
            var allProducts = from p in products select p;

            foreach (var prod in allProducts)
                Console.WriteLine(prod.ToString());
        }

        static void ListProductNames(ProductInfo[] products)
        {
            // Now get only names of the products.
            Console.WriteLine("Only product names:");
            var names = from p in products select p.Name;

            foreach (var n in names)
                Console.WriteLine("Name: {0}", n);
        }

        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items:");

            // Get only items where we have more than 25 in stock.
            var overstock = from p in products where p.NumberInStock > 25 select p;

            foreach (ProductInfo c in overstock)
                Console.WriteLine(c.ToString());
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and descriptions:");
            var nameDesc = from p in products select new { p.Name, p.Description };

            foreach (var item in nameDesc)
                Console.WriteLine(item.ToString());
        }

        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };

            // Map set of anonymous objects to an Array object.
            return nameDesc.ToArray();
        }

        static void GetCountFromQuery()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System shock 2" };

            // Get count from query.
            int numb = (from g in currentVideoGames where g.Length > 6 select g).Count();

            // Prints out the number of items.
            Console.WriteLine("{0} items honor LINQ query.", numb);
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Products in reverse:");
            var allProducts = from p in products select p;
            foreach (var prod in allProducts.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products)
        {
            // Get names of products, alphabetized.
            var subset = from p in products orderby p.Name select p;

            Console.WriteLine("Ordered by Name:");
            foreach (var p in subset)
            {
                Console.WriteLine(p.ToString());
            }
        }

        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);

            Console.WriteLine("Here is what you don't have, but I do:");
            foreach (string s in carDiff)
                Console.WriteLine(s); // Prints Yugo.
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            // Get the common members.
            var carIntersect = (from c in myCars select c).Intersect(from c2 in yourCars select c2);

            Console.WriteLine("Here is what we have in common:");
            foreach (string s in carIntersect)
            {
                Console.WriteLine(s);
            }
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            // Get the union of these containers.
            var carUnion = (from c in myCars select c).Union(from c2 in yourCars select c2);

            Console.WriteLine("Here is everything:");
            foreach (string s in carUnion)
            {
                Console.WriteLine(s);
            }
        }
    }
}
