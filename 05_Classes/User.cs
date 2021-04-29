using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    class User
    {
        public User()
        {

        }
        public User(string FirstName, string LastName,DateTime Birthday,int ID = 2939378)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.ID = ID;
        }

        public string FirstName { get; set; }

        private string _lastName; //Backing field last name
        public string LastName {
            get {return _lastName;} 
            set {
                //value comes from LastName, sets private field _lastname as LastName
                _lastName = value;} //value is built in and must be used here
        } 
        public int ID { get; private set; }
        public DateTime Birthday{ get; set; }

        //Using class as a type
        public Vehicle Transport { get; set; }

        public string PrintFullName()
        {
            return $"{FirstName}  {LastName}";
        }

        public int returnAge()
        {
            TimeSpan Age;
            Age = DateTime.Today - Birthday;
            int AgeVal = Convert.ToInt32(Math.Floor(Age.Days/365.25));
            return AgeVal;
        }

    }
}
