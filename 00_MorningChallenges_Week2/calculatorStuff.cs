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
            Console.WriteLine(calc.add(2.4m, 2.3m));
            Console.WriteLine(calc.add(4, 3));
        }

        [TestMethod]
        public void subtractNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.subtract(2.4m, 2.3m));
            Console.WriteLine(calc.subtract(4, 3));
        }

        public void multiplyNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.multiply(2.4m, 2.3m));
            Console.WriteLine(calc.multiply(4, 3));
        }

        public void divideNumbers()
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.divide(2.4m, 2.3m));
            Console.WriteLine(calc.divide(4, 3));
        }
    }

    public enum returnType {fractions,percentages,decimals}
    public enum functionType {add,subtract,multiply,divide}
    [TestClass]
    public class Calculator
    {
        public returnType screen { get; set; }

        public UInt64 add(UInt64 a, UInt64 b)
        {
            return a + b; 
        }
        public decimal add(decimal a, decimal b)
        {
            return a + b;
        }
        public UInt64 subtract(UInt64 a, UInt64 b)
        {
            return a - b;
        }
        public decimal subtract(decimal a, decimal b)
        {
            return a - b;
        }
        public UInt64 multiply(UInt64 a,UInt64 b)
        {
            return a * b;
        }
        public decimal multiply(decimal a, decimal b)
        {
            return a * b;
        }
        public UInt64 divide(UInt64 a, UInt64 b)
        { 
            return a / b;
        }
        public decimal divide(decimal a, decimal b)
        {
            return a / b;
        }
        /*
        public decimal divide(decimal a, decimal b,returnType fracPerc)
        {
            if (fracPerc == returnType.decimals)
                return a / b;
            else if (fracPerc == returnType.percentages)
                return (a / b * 100);
            else
               return ();
        }
        */
    }
}
