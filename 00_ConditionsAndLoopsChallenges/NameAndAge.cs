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

            Console.WriteLine(Dates[1]);
        }
    }
}
