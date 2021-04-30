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
        public void IndicatorVehicleTests()
        {
            // Cannot be set outside of class, private set
            Vehicle thirdVehicle = new Vehicle();
            Indicator indicator = new Indicator();
            Console.WriteLine(indicator.IsFlashing);
            indicator.TurnOn();
            Console.WriteLine(indicator.IsFlashing);
        }

        [TestMethod]
        public void VehicleConstructorTest()
        {
            Vehicle car = new Vehicle();
            car.Make = "Nissan";
            car.Model = "Skyline";
            car.Mileage = 50000;
            car.TypeOfVehicle = vehicleType.Car;

            Console.WriteLine(car.Make + " " + car.Model);

            Vehicle car2 = new Vehicle("Ford", "Taurus", 12938, vehicleType.Car);
            Console.WriteLine(car2.Make + " " + car2.Model);

            Vehicle rocket = new Vehicle("Enterprise", "Galaxy", 1000000, vehicleType.Plane);
            Console.WriteLine($"I rode on spaceship, it was the {rocket.Make}");

            rocket.Model = "Constellation";
            Console.WriteLine($"That ship is a {rocket.Model}");
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

        [TestMethod]
        public void Users()
        {
            User newUser = new User("Chris","Kronberg",new DateTime(1987,11,17));
            Console.WriteLine(newUser.FirstName);
            Console.WriteLine(newUser.LastName);
            Console.WriteLine(newUser.PrintFullName());
            Console.WriteLine(newUser.returnAge());
            Console.WriteLine(newUser.ID);
        }

        [TestMethod]
        public void PersonTest()
        {
            Person person = new Person("Chris","Kronberg",new DateTime(2000,01,31));
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.FullName);
            Console.WriteLine(person.returnAge);


            //Why blank constructors can be unhelpful, they can have missing data
            Person jake = new Person();
            jake.FirstName = "Jacob";
            jake.Birthday = new DateTime(1991, 05, 04);
            Console.WriteLine(jake.FullName);
            Console.WriteLine(jake.Birthday);

            //Single statement instance of new'ing up a person
            Person andrew = new Person(){FirstName = "Andrew",LastName = "Torr",Birthday = new DateTime(1950, 12, 25)};

            //Asserting with a test that these two are equal
            Assert.AreEqual("Jacob", jake.FirstName);
            //Asserting with a test that these two are not equal
            //Assert.AreEqual("Jac", jake.FirstName);
        }

        //Within the scope of the namespace, but outside of a method
        // Field type variable
        Person _person = new Person("Luke", "Skywalker", new DateTime(1987, 7, 4));

        [TestMethod]
        public void PersonTransportTest()           // using class variable in another class in this method
        {
            _person.Transport = new Vehicle("X-Wing","Starship",1000,vehicleType.Plane);
            Console.WriteLine($"{_person.FullName} drives an {_person.Transport.Make}");

            _person.Transport.Model = "T16 Skyhopper";
            Console.WriteLine($"{_person.FullName} drives an {_person.Transport.Make} {_person.Transport.Model}");
            Console.WriteLine();

            Person blank = new Person();
           // Console.WriteLine($"Fullname: {blank.FullName}");
           // Console.WriteLine($"Unset Class: {blank.Transport.Make}");
            Console.WriteLine($"Unset struct: {blank.Birthday}");
            Console.WriteLine($"Unset struct: {blank.returnAge}");
        }
    }
}
