using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ExtensionMethods
{
    static class MyExtensions
    {
        // This method allows any object to display the assembly it is defined in.
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here: => {Assembly.GetAssembly(obj.GetType()).GetName().Name}\n");
        }

        // This method allows any integer to reverse its digits.
        // For example, 56 would return 65.
        public static int ReverseDigits(this int i)
        {
            // Translate int to a string and then ge tall the characters.
            char[] digits = i.ToString().ToCharArray();

            // Now, reverse items in the resulting array.
            Array.Reverse(digits);

            // Put back to a string.
            string newDigits = new string(digits);

            // Finally, return the modified string back as an int.
            return int.Parse(newDigits);
        }
    }
}
