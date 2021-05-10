using _404_RandomTesting.InterfaceChallenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _404_RandomTesting
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void TruckTest()
        {
            var myTruck = new Truck("Ford","Raptor","Blue",truckType.FullSize);
            myTruck.StartVehicle();
            Console.WriteLine(myTruck.Drive());
        }

        [TestMethod]
        public void SedanTest()
        {
            var mySedan = new Sedan("Volvo", "S60", "Blue",doorType.two);
            mySedan.StartVehicle();
            mySedan.TurnOff();
            mySedan.StartVehicle();
            Console.WriteLine(mySedan.Drive());
            Console.ReadKey();
        }
    }
}
