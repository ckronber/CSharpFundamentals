using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _404_RandomTesting
{
    [TestClass]
    public class RandomTests
    {
        [DataTestMethod]
        [DataRow(100)]
        public void FizzBuzz(int number)
        {
            for(int i = 1;i<=number;i++)
            {
                if((i%3==0) && (i%5==0))
                    Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
