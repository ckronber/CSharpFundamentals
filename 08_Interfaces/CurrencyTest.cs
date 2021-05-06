using _08_Interfaces.Currency;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_Interfaces
{
    [TestClass]
    public class CurrencyTest
    {
        [TestMethod]
        public void CurrencyValueTests()
        {
            ICurrency penny = new Penny();
            ICurrency dime = new Dime();
            ICurrency dollar = new Dollar();
            
            Assert.AreEqual(.01m, penny.Value);
            Assert.AreEqual(.10m, dime.Value);
            Assert.AreEqual(1m, dollar.Value);
        }

        [DataTestMethod] // used for testing values for inputs in a method
        [DataRow(100.2)] //adds 100.2 to value
        [DataRow(37.12)]
        [DataRow(1.5)]
        [DataRow(19)]

        public void EPaymentTest(double Value)
        {
            //DataRow uses double by default, so we need to convert to decimal first
            decimal convertedValue = Convert.ToDecimal(Value);
            var ePay = new ElectronicPayment(convertedValue);
            Assert.AreEqual(convertedValue, ePay.Value);
        }
    }
}
