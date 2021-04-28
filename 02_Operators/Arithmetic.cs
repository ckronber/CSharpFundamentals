using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void Operators()
        {
            int a = 22;
            int b = 15;

            //Addition
            int sum = a + b;
            Console.WriteLine(sum);

            //Subtraction
            int difference = a - b;
            Console.WriteLine(difference);

            //Multiplication
            int product = a * b;
            Console.WriteLine(product);

            //Quotient
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Modulus
            int remainder = a % b;
            Console.WriteLine(remainder);
        }
    }
}
