using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class Person
    {
        public Person()
        {

        }
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Birthday = dateOfBirth;
        }

        public string FirstName { get; set; }

        private string _lastName; //Backing field last name
        public string LastName
        {
            get { return _lastName; }
            set
            {
             //value comes from LastName, sets private field _lastname as LastName
                _lastName = value;
            } //value is built in and must be used here
        }
        public DateTime Birthday { get; set; }

        //Using class as a type
        public Vehicle Transport { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName}  {LastName}";
            }
        }

        public int returnAge
        {
            get
            {
                TimeSpan Age;
                Age = DateTime.Today - Birthday;  //DateTime.Now works also
                int AgeVal = Convert.ToInt32(Math.Floor(Age.Days / 365.25));
                return AgeVal;
            }
        }
    }
}
