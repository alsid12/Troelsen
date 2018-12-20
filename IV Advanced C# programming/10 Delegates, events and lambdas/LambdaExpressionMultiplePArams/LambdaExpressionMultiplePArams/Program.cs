using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionMultiplePArams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Register wit delegate as lambda expression.
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) => { Console.WriteLine("Message: {0} Result: {1}", msg, result); });

            // This will execute the Lambda expression.
            m.Add(10, 10);
            Console.ReadLine();
        }
    }
}
