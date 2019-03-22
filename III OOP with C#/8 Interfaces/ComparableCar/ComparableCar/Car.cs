using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    public class Car: IComparable
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        #region Properties and fields.

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        // Property to return the PetNameComparer.
        public static IComparer SortByPetName
        {
            get { return (IComparer) new PetNameComparer(); }
        }

        private bool carIsDead;

        // Car has-a radio.
        private Radio theMusicBox = new Radio();
        #endregion

        #region Constructors

        public Car(){}

        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }

        #endregion

        #region Methods
        public void CrankTunes(bool state)
        {
            //Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        // See if the car has overheated.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine($"{PetName} is out of order...");
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine($"{PetName} has overheated");
                    CurrentSpeed = 0;
                    carIsDead = true;

                    CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!", "You have a lead foot", DateTime.Now);
                    ex.HelpLink = "http://www.CarsRUs.com";
                    throw ex;
                }
                else
                {
                    Console.WriteLine($"=> CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
        #endregion

        #region IComparable interface implementation
        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                return this.CarID.CompareTo(temp.CarID);
            }
            else
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
        }
        #endregion

    }
}
