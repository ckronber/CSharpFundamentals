using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Person
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
    }

    public class Customer:Person
    {
        public bool isPremium { get; set;}
        public Customer() { }
        public Customer(bool isPremium)
        {
            this.isPremium = isPremium;
        }
    }
}
