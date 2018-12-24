using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        #region Fields
        // Field data.
        private string empName;
        private string empSSN;
        private int empAge;
        #endregion

        #region Properties
        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                else
                    empName = value;
            }
        }

        public int ID { get; set; }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        public float Pay { get; set; }

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        #endregion

        #region Constructors
        public Employee() { }
        public Employee(string name, int id, float pay) : this(name, id, pay, 0, "") { }

        public Employee(string name, int id, float pay, int age, string ssn)
        {
            empName = name;
            ID = id;
            Pay = pay;
            Age = age;
            empSSN = ssn;
        }
        #endregion

        #region Methods
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Pay {0}", Pay);
            Console.WriteLine("Age {0}", Age);
        }
        #endregion
    }
}
