using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CarEvents;

namespace CarDelegate
{
    public class Car
    {
        #region Feilds and properties
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;

        public string PetName { get; set; }

        // Is the car alive or dead?
        private bool carIsDead;
        #endregion

        #region Constructors
        // Class constructors.
        public Car() { }

        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
        #endregion

        #region Events
        // This car can send these events.
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;
        #endregion

        // 1) Define a delegate type.
        public delegate void EventHandler<CarEventArgs>(object sender, CarEventArgs e);

        //// 2) Define a member variable of this delegate.
        //private CarEngineHandler listOfHandlers;

        //// 3) Add registration function for the caller.
        //public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers += methodToCall;
        //}

        //public void unRegisterWithCarEngine(CarEngineHandler methodToCall)
        //{
        //    listOfHandlers -= methodToCall;
        //}

        // 4) Implement the Accelerate() method to invoke the delegate's
        // invocation list under the correct circumstances.
        public void Accelerate(int delta)
        {
            // If this car is "dead," fire Exploded event.
            if (carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;

                // Almost dead?
                if (10 == MaxSpeed - CurrentSpeed)
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
                }
                // Still OK!
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                {
                    Console.WriteLine($"CurrentSpeed = {CurrentSpeed}");
                }
            }
        }
    }
}
