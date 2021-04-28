using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public enum vehicleType { Car, Truck, Van, Motorcycle, Plane, Boat, Scooter}  //predefined set of options
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
    }
}
