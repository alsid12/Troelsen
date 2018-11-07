using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefTypeAndValTypeParams
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passing ref-types by value.
            Console.WriteLine("***** Passing Person object by value *****");
            Person fred = new Person("Fred", 12);
            Console.WriteLine("\nBefore by value call, Person is:");
            fred.Display();
            SendAPersonByValue(fred);
            Console.WriteLine("\nAfter by value call, Person is:");
            fred.Display();
            Console.ReadLine();
        }

        static void SendAPersonByValue(Person p)
        {
            

            //Will the caller see this reassignment?
            p = new Person("Nikki", 99);

            // Change the age of p.
            p.personAge = 990;
        }
    }

    class Person
    {
        public int personAge;
        public string personName;

        // Constructors.
        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName, personAge);
        }
    }
}
