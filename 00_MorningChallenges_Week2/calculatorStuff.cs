using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_MorningChallenges_Week2
{
    [TestClass]
    public class calculatorStuff
    {
        [TestMethod]
        public void addNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.add(2.4, 2.3));
            Console.WriteLine(calc.add(4, 3));
        }

        [TestMethod]
        public void subtractNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.subtract(2.4, 2.3));
            Console.WriteLine(calc.subtract(4, 3));
        }

        public void multiplyNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.multiply(2.4, 2.3));
            Console.WriteLine(calc.multiply(4, 3));
        }

        public void divideNumbers()
        {
            Calculator calc = new Calculator();
            Assert.AreEqual(2,calc.divide(2.8, 1.4));
            Assert.AreEqual(2,calc.divide(6, 3));

        }
    }

    public enum returnType {fractions,percentages,doubles}
    public enum functionType {add,subtract,multiply,divide}
    [TestClass]
    public class Calculator
    {
        public returnType screen { get; set; }

        public int add(int a, int b)
        {
            return a + b; 
        }
        public double add(double a, double b)
        {
            return a + b;
        }
        public int subtract(int a, int b)
        {
            return a - b;
        }
        public double subtract(double a, double b)
        {
            return a - b;
        }
        public int multiply(int a,int b)
        {
            return a * b;
        }
        public double multiply(double a, double b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        { 
            return a / b;
        }
        public double divide(double a, double b)
        {
            return a / b;
        }
        public double divide(double a, double b,returnType fracPerc)
        {
            if (fracPerc == returnType.doubles)
                return a / b;
            else if (fracPerc == returnType.percentages)
                return (a / b * 100);
            else
               return 0;
        }
        
    }
}
