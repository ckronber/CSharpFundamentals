using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_ConditionsAndLoopsChallenges
{
    [TestClass]
    public class NameAndAge
    {
        [TestMethod]
        public void NameCondition()
        {
            string firstname = "Chris", lastName = "Kronberg";
            int age = 33;
            string[] collectionMovies = { "The Bourne Identity", "Bourne Supremacy", "Bourne Ultimatum", "Montey Python and the Holy Grail" };
            DateTime Birthday = new DateTime(1987, 11, 17);
            
            List<DateTime> Dates = new List<DateTime>();

            Dates.Add(DateTime.Now);
            Dates.Add(Birthday);
            Dates.Add(DateTime.Today);

            Console.WriteLine(Dates[1]);

            //displayBirthday(new DateTime());
        }
        /*
        [TestMethod]
        public void displayBirthday(DateTime Bday)
        {
            TimeSpan age = DateTime.Now - Bday;
            int Yearage = Convert.ToInt32(Math.Floor(age.Days/365.25));
            System.Console.WriteLine($"You are {Yearage} years old");
        }
        */
    }
}
