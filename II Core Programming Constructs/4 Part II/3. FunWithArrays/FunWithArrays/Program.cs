using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // SimpleArrays();
            // ArrayInitialization();
            // ArrayOfObjects();
            // RectMultiDimensionalArray();
            // JaggedMultiDimArray();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple array creation.");
            // Create an array of ints containing 3 elements indexed 0, 1, 2.
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (var i in myInts)
            {
                Console.WriteLine(i);
            }

            // Create a 100 item string array, indexed 0-99
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();

        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array initialization.");

            // Array initialization syntax using the "new" keyword.
            string[] stringArray = new string[] {"one", "two", "three"};
            Console.WriteLine("stringArray has {0} elements.", stringArray.Length);

            // Array initialization syntax without using the "new" keyword.
            bool[] boolArray = {false, false, true};
            Console.WriteLine("boolArray has {0} elements.", boolArray.Length);

            // Array initialization syntax with the "new" keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements.", intArray.Length);
            Console.WriteLine();
        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of objects.");

            //An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (var obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}", obj.GetType(), obj);
            }
            Console.WriteLine();
        }

        static void RectMultiDimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array");
            // A rect MD array.
            int[,] myMAtrix;
            myMAtrix = new int[6,6];

            // Populate an array.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    myMAtrix[i, j] = i * j;
                }
            }

            // Print (6 *6) array.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(myMAtrix[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultiDimArray()
        {
            Console.WriteLine("=> Jagged multidimensional array");
            // Array of arrays. Here we have array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }

            // Print each row (remember, each member is zero by default).
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order.
            Console.WriteLine("-> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                //Print a name.
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine("-> The reversed array");
            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Clear out all but the final member.
            Console.WriteLine("-> Clear out all but one...");
            Array.Clear(gothicBands, 1, 2);
            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");
        }
    }
}
