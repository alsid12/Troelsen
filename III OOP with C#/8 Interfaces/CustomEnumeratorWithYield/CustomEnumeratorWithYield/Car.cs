using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEnumeratorWithYield
{
    class Car
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
                    throw new Exception($"{PetName} has overheated!");
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
