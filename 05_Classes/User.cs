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
        public User(string firstName, string LastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = LastName;
            this.birthday = birthday;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string ID { get; private set; }
        public DateTime birthday{ get; set; }

        public string PrintFullName()
        {
            return $"{firstName}  {lastName}";
        }

        public int returnAge()
        {
            TimeSpan Age;
            Age = DateTime.Today - birthday;
            int AgeVal = Age.Days/365;
            return AgeVal;
        }

    }
}
