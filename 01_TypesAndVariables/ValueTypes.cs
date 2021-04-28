using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            bool isDeclaredandInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void wholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;              //default for SQL
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.987435987858757874345324f;  // need an f to recognize as float
            double doubleExample = 1.3498875873094805234543d; // DO NOT need but can add a d for a double
            decimal decimalExample = 1.38747983749089345435m; // need an m on decimal because Microsoft is stupid

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType {Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Struct()
        {
            DateTime Today = DateTime.Today;
            Console.WriteLine(Today);
            Console.WriteLine(DateTime.Now);
            DateTime Birthday = new DateTime(1987, 11, 17);

            TimeSpan age = Today - Birthday;  // math between datetimes
            int ageInDays = age.Days/365;
            Console.WriteLine(ageInDays);
        }
    }
}
