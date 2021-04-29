using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum vehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter }  //predefined set that cannot change
    public class Vehicle   // Any class can reference this class if it is Public
    {
        //1 Access Modifier
        //2 Type - type the property holds
        //3 Name
        //4 Getters and setters

        //1    //2     //3      //4
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public vehicleType TypeOfVehicle { get; set; }
        public bool isRunning { get; private set; } // private set for only accessing at this level
        public Indicator isIndicating { get; set; }
       

        public void TurnOn()
        {
            isRunning = true;
            Console.WriteLine("You turned on the vehicle");
        }

        public void TurnOff()
        {
            isRunning = false;
            Console.WriteLine("You turned off the vehicle");
        }

        // public int MyProperty { get; set; }         // prop then tab tab is a shortcut to this

        public bool RightIndicator { get; set; }
        public bool LeftIndicator { get; set; }

       

        public void IndicateRight()
        {
            RightIndicator = true;
            LeftIndicator = false;
        }

        public void IndicateLeft()
        {
            LeftIndicator = true;
            RightIndicator = false;
        }

        public void TurnOnHazards()
        {
            LeftIndicator = true;
            RightIndicator = true;
        }

        public void TurnOffHazards()
        {
            LeftIndicator = false;
            RightIndicator = false;
        }

        //Challenge
        //make indicator it's own custom class
        //properties including IsFlashing
        //methods for TurnOn() and TurnOff()
        // - methods would set value of IsFlashing
    }

    public class Indicator
    {
        public bool IsFlashing {  get; set; }

        public bool TurnOn()
        {
            IsFlashing = true;
            return IsFlashing;
        }

        public bool TurnOff()
        {
            IsFlashing = false;
            return IsFlashing;
        }
    }
}
