using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegate
{
    public class SimpleDelegate
    {
        // This delegate can point to any method, taking two integers and returning an integer.
        public delegate int BinaryOp(int x, int y);


    }

    public class SimpleMath
    {
        // This class contains methods BinaryOp will point to.
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Simple delegate example *****\n");

            // Create a BinaryOp delegate object that "points to" SimpleMath().
            SimpleMath m =  new SimpleMath();
            SimpleDelegate.BinaryOp b =  new SimpleDelegate.BinaryOp(m.Add);
            // Invoke Add() method indirectly using delegate object.
            Console.WriteLine($"10 + 10 is {b(10, 10)}");
            DisplayDelegateInfo(b);
            Console.ReadLine();
        }

        static void DisplayDelegateInfo(Delegate delObj)
        {
            // Print the names of each member in the delegate's invocation list.
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Method name: {0}", d.Method);
                Console.WriteLine("Type name: {0}", d.Target);
            }
        }
    }
}
