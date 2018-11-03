using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with methods *****\n");

            //Pass two variables in by value.
            int x = 9, y = 10;
            Console.WriteLine("Before call: X {0}, Y: {1}", x, y);
            Console.WriteLine("Answer is: {0}", Add(x, y));
            Console.WriteLine("After call: X {0}, Y: {1}", x, y);

            Console.WriteLine("With out keyword: {0}", Add(x, y, out int ans));
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            int ans = x + y;
            //Caller will not see these changes as you are modifying a copy of the original data.
            x = 10000;
            y = 88888;
            return ans;
        }

        static void Add(int x, int y, out int ans)
        {
            ans = x + y;
        }
    }
}
