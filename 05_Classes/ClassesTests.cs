using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _05_Classes
{
    [TestClass]
    public class ClassesTests
    {
        [TestMethod]
        public void VehiclePropertiesTest()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Ferrari";
            firstVehicle.Model = "F8 Spider";
            firstVehicle.Mileage = 25321;

            Console.WriteLine(firstVehicle.Make);
            Console.WriteLine(firstVehicle.Model);

            firstVehicle.TypeOfVehicle = vehicleType.Car;
            Console.WriteLine(firstVehicle.Model);
            Console.WriteLine(firstVehicle.Mileage);
            Console.WriteLine(firstVehicle.TypeOfVehicle);
        }

        [TestMethod]
        public void VehicleMethodsTests()
        {
            Vehicle secondVehicle = new Vehicle();
            secondVehicle.Make = "Tesla";
            secondVehicle.Model = "Model S";
            secondVehicle.TurnOn();
            Console.WriteLine(secondVehicle.isRunning);
            secondVehicle.TurnOff();
            Console.WriteLine(secondVehicle.isRunning);
            
            secondVehicle.IndicateRight();
            Console.WriteLine(secondVehicle.RightIndicator); 
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOnHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);
            secondVehicle.TurnOffHazards();
            Console.WriteLine(secondVehicle.RightIndicator);
            Console.WriteLine(secondVehicle.LeftIndicator);

        }

        [TestMethod]
        public void GreeterMethodTests()
        {
            Greeter greeterInstance = new Greeter();
            greeterInstance.SayHello("Chris");

            List<string> students = new List<string>();
            students.Add("Hannan");
            students.Add("Joel");
            students.Add("Jay");
            students.Add("Lauren");
            students.Add("Luis");

            foreach (string student in students)
            {
                greeterInstance.SayHello(student);
            }

            string greeting = greeterInstance.GetRandomGreeting();
            Console.WriteLine(greeting);
        }

        [TestMethod]
        public void CalculatorTests()
        {
            //DateTime birthday = new DateTime(1987, 11, 17);
            Calculator Calc1 = new Calculator();

            double sum = Calc1.GetSum(3.5, 100.9);
            Console.WriteLine(sum);

            int myAge = Calc1.CalculateAge(new DateTime(1987,11,17));
            Console.WriteLine(myAge);
        }

        

    }
}
