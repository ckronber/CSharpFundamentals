using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparisons
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Chris";
            bool isEqual = (age == 41);  //the value of isEqual depends on the comparison in the ()

            bool userIsMichael = userName == "Michael";

            //Console.WriteLine(isEqual);
            //Console.WriteLine(userIsMichael);

            bool isNotEqual = age != 23;  // This evaluates to True because age is not 23. It is 25
            //Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();    //new string
            firstList.Add(userName);                        //added a string to the list

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = (firstList == secondList);
            //Console.WriteLine(listsAreEqual);       //false because addresses are different from eachother in memory

            bool isGreaterThan = age > 36;
            //Console.WriteLine(isGreaterThan);

            bool isLessThan = age < 36;
            //Console.WriteLine(isLessThan);

            bool isGreaterorEqual = age <= 36;
            //Console.WriteLine(isGreaterorEqual);

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue && isFalse;
            bool anotherAndvalue = (age == 25) && (userName == "Chris");

            bool orValue = (age == 25 || userName == "Michael");
            
        }
    }
}
