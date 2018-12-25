using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with extension methods *****\n");

            // This int has assumed a new identity!
            int myInt = 12345678;
            myInt.DisplayDefiningAssembly();

            // So has the data set!
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAssembly();

            // And the soundplayer!
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.DisplayDefiningAssembly();

            // Use new integer functionality.
            Console.WriteLine("Value of myInt: {0}", myInt.ReverseDigits());

            Console.ReadLine();
        }
    }
}
