using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Garage
    {
        // The hidden int backing field is set to zero.
        public int NumberOfCars { get; set; }

        // The hidden Car backing field is set to null.
        public Car MyAuto { get; set; }
    }
}
