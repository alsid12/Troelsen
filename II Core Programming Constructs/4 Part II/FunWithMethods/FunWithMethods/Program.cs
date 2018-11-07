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
            //int x = 9, y = 10;
            //Console.WriteLine("Before call: X {0}, Y: {1}", x, y);
            //Console.WriteLine("Answer is: {0}", Add(x, y));
            //Console.WriteLine("After call: X {0}, Y: {1}", x, y);

            //int ans;
            //AddAlt(90, 90, out ans);
            //Console.WriteLine("With out keyword: 90 + 90 = {0}", ans);

            //int i; string str; bool b;
            //FillTheseValues(out i, out str, out b);
            //Console.WriteLine("Int is: {0}. String is: {1}. Bool is {2}", i, str, b);

            //string str1 = "Flip";
            //string str2 = "Flop";
            //Console.WriteLine("Before: {0}, {1}", str1, str2);
            //SwapStrings(ref str1, ref str2);
            //Console.WriteLine("After: {0}, {1}", str1, str2);

            //// Pass in a comma-delimited list of doubles.
            //double average;
            //average = CalculateAverage(4.0, 3.2, 5.7, .3, 64.22, 87.2);
            //Console.WriteLine("Average of data is: {0:0.000}.", average);

            //// Or pass ana array of doubles.
            //double[] data = {4.0, 3.2, 5.7};
            //average = CalculateAverage(data);
            //Console.WriteLine("Average of data is: {0:0.000}.", average);

            //// Average of 0 is 0!
            //Console.WriteLine("Average of data is: {0:0.000}.", CalculateAverage());

            //EnterLogData("Oh no! Grid can't find data!");
            //EnterLogData("Oh no! Сan't find the payroll data!", "CFO");

            DisplayFancyMessage(message: "Wow! Very fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

            DisplayFancyMessage(backgroundColor: ConsoleColor.Cyan, message: "Testing...", textColor: ConsoleColor.DarkGreen);
            DisplayFancyMessage();

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

        static void AddAlt(int x, int y, out int ans)
        {
            ans = x + y;
        }

        static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Enjoy your string";
            c = true;
        }

        static void SwapStrings(ref string s1, ref string s2)
        {
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;
        }

        //Return average of some number of doubles.
        static double CalculateAverage(params double[] values)
        {
            Console.WriteLine("You sent me {0} doubles.", values.Length);

            double sum = 0;
            if (values.Length == 0)
                return sum;

            for (int i = 0; i < values.Length; i++)
                sum += values[i];
            return (sum / values.Length);
        }

        static void EnterLogData(string message, string owner = "Programmer")
        {
            // Console.Beep();
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine("Owner of error: {0}", owner);
        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.Blue, ConsoleColor backgroundColor = ConsoleColor.White, string message = "Test message")
        {
            // Store old colors to restore after message is printed.
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldbackgroundColor = Console.BackgroundColor;

            // Set new colors and print message.
            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            // Restore previous colors.
            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldbackgroundColor;
        }
    }
}
