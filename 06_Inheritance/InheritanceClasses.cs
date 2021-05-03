using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _06_Inheritance
{
    //abstract makes it so a class can only be inherited from
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Person() { }

        public Person(string firstName, string lastName,string phoneNumber, string email){
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

        //virtural overrides the method in a child class
        public virtual void WhoAmI()
        {
            Console.WriteLine("I am a person");
        }

        //abstracts do not declare a body
        public abstract void WhoisI();
        //{
            //Console.WriteLine("I am a person");
        //}
    }

    public class Customer:Person
    {
        public bool isPremium { get; set;}
        public Customer() { }
        public Customer(bool isPremium)
        {
            this.isPremium = isPremium;
        }

        // overrides a virtual method in the parent class
        public override void WhoAmI()
        {
            base.WhoAmI();
          //  Console.WriteLine("I am a customer");
        }

        public override void WhoisI()
        {
            Console.WriteLine("I am a customer");
        }
    }

    public class Employee : Person
    {
        public int EmployerNumber { get; set; }
        public DateTime HireDate { get; set; }
        public int yearsWithCompany {
            get
            {
                double totalTime = (DateTime.Now - HireDate).TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalTime));
            }
        } // challenge - remove the set and calculate years based on Hire date

        public Employee(int EmployeeNumber) {
            this.EmployerNumber = EmployeeNumber;
        }
        //referencing person class with base
        public Employee(int employeeNumber, DateTime hireDate, string firstName, string lastName, string phoneNumber, string email) : base(firstName, lastName, phoneNumber, email)
        {
            this.EmployerNumber = employeeNumber;
            this.HireDate = hireDate;
        }

        public override void WhoAmI()
        {
            base.WhoAmI();
        }

        public override void WhoisI()
        {
            Console.WriteLine("I am an employee");
        }
    }

    public class SalaryEmployee:Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee(int employeeNumber, decimal salary) : base(employeeNumber)
        {
            this.Salary = salary;
        }
        public SalaryEmployee(int Salary) : base(Salary) {
            this.Salary = Salary;
        }
    }
}
