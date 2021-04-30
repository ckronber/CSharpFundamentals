using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _06_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonTests()
        {
            Person larry = new Person();
            larry.FirstName = "Larry";
            larry.LastName = "Bird";
            Console.WriteLine(larry.FullName);

            Customer sal = new Customer();          // uses properties from the person class
            sal.FirstName = "Sal";
            sal.LastName = "Vulcano";
            sal.isPremium = true;
            Console.WriteLine(sal.FullName);
            Console.WriteLine(sal.isPremium);

            Employee joe = new Employee(2, new DateTime(2021, 01, 01), "Joe", "Smith", "1238484943", "joeyG@gmail.com");
            Console.WriteLine(joe.Email);


            SalaryEmployee brian = new SalaryEmployee(3, 500000);
            brian.FirstName = "Brian";
            brian.LastName = "Gwen";
            

        }
    }
}
