using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MultipleExceptions
{
    public class Car
    {
        // Constant for maximum speed.
        public const int MaxSpeed = 100;

        #region Properties and fields.

        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        private bool carIsDead;

        // Car has-a radio.
        private Radio theMusicBox = new Radio();
        #endregion

        #region Constructors

        public Car(){}

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
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
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero");

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

    }
}
