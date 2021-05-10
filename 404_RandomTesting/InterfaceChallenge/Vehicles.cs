using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_RandomTesting.InterfaceChallenge
{

    public enum doorType {two = 2,four = 4}
    public enum truckType {FullSize,MidSize,HeavyDuty,Compact,Electric,Hybrid,Luxury}
    public class Sedan : IVehicle
    {
        public Sedan() { }
        public Sedan(string make, string model, string color,doorType doors)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Doors = doors;
        }
        public string Make { get; set; }
        public string Model { get;set; }
        public string Color { get; set; }
        public doorType Doors { get; set; }

        public bool IsEngineOn { get; private set;}

        public bool StartVehicle() => IsEngineOn = true;

        public bool TurnOff() => IsEngineOn = false;
        public string Drive()
        {
            if (IsEngineOn == true)
                return $"{this.Make} {this.Model} is in Drive";
            else
                return $"Make sure vehicle is started first.";
        }
    }

    public class Truck: IVehicle
    {
        public Truck() { }
        public Truck(string make,string model,string color,truckType types)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
            this.Ttype = types;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public truckType Ttype { get; set; }
        
        public  bool IsEngineOn { get; private set; }

        public bool StartVehicle() => IsEngineOn = true;

        public bool TurnOff() => IsEngineOn = false;
        public string Drive()
        {
            if (IsEngineOn == true)
                return $"{this.Make} {this.Model} is in Drive";
            else
                return $"Make sure vehicle is started first.";
        }
    }

    public class Motorcycle : IVehicle
    {
        public Motorcycle() { }
        public Motorcycle(string make, string model, string color)
        {
            this.Make = make;
            this.Model = model;
            this.Color = color;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public bool IsEngineOn { get; set; }

        public bool StartVehicle() => IsEngineOn = true;

        public bool TurnOff() => IsEngineOn = false;
        public string Drive()
        {
            if (IsEngineOn == true)
                return $"{this.Make} {this.Model} is in Drive";
            else
                return $"Make sure vehicle is started first.";
        }

        public class SportsCar: IVehicle
        {
            SportsCar() { }
            SportsCar(string make, string model, string color, int year, string engine)
            {
                this.Make = make;
                this.Model = model;
                this.Color = color;
                this.Year = year;
                this.Engine = engine;
            }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            public string Engine { get; set; }

            public bool IsEngineOn { get; private set; }

            public bool StartVehicle() => IsEngineOn = true;

            public bool TurnOff() => IsEngineOn = false;
            public string Drive()
            {
                if (IsEngineOn == true)
                    return $"{this.Make} {this.Model} is in Drive";
                else
                    return $"Make sure vehicle is started first.";
            }
        }
    }
}
