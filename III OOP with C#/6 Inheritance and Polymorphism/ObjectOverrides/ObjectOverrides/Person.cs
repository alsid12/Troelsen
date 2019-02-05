using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        #region Properties
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; }
        public string SSN { get; set; } = "";
        #endregion

        #region Constructors
        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge; 
        }
        
        public Person() { }
        #endregion

        #region Methods
        public override string ToString() => $"[First Name: {FirstName}; Last Name: {LastName}; Age: {Age}]";

        //public override bool Equals(object obj)
        //{
        //    if (obj is Person && obj != null)
        //    {
        //        Person temp;
        //        temp = (Person)obj;
        //        if (temp.FirstName == this.FirstName
        //            && temp.LastName == this.LastName
        //            && temp.Age == this.Age)
        //        {
        //            return true;
        //        }
        //        else return false;
        //    }
        //    return false;
        //}

        public override bool Equals(object obj) => obj.ToString() == ToString();

        public override int GetHashCode() => ToString().GetHashCode();
        #endregion

    }
}
