using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        [TestMethod]
        public void SwitchCases()
        {
            int input = 55;

            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("World");
                    break;
                case 55:
                    Console.WriteLine("Huh");
                    break;
                default:
                    Console.WriteLine("What are you doing?");
                    break;

            }
        }
    }
}