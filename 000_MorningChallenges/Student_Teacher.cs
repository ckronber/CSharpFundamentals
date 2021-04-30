using _000_MorningChallenges_Week1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _000_MorningChallenges
{
    [TestClass]
    public class Student_Teacher
    {
        [TestMethod]
        public void StuTeacher()
        {
            Student Student_1 = new Student("Arthur", "KingOfTheBritains", new DateTime(1600, 2, 3), 384.43m, CourseType.Cyber_Security, BadgeType.Red, true);

            Console.WriteLine($"{Student_1.FirstName} {Student_1.LastName}");
            Console.WriteLine($"{ Student_1.DateofBirth}");
        }
    }
}
