using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_ConditionsAndLoopsChallenges
{
    [TestClass]
    public class SuperWord
    {
        [TestMethod]
        public void  Super()
        {
            string superWord = "Supercalifragilisticexpialidocious";
            int iterator = 0;

            while (iterator < superWord.Length)
            {
                Console.Write(superWord[iterator] + " ");
                iterator++;
            }

            iterator = 0;

            Console.WriteLine();

            while (iterator < superWord.Length)
            {
                if (superWord[iterator] == 'i' || superWord[iterator] == 'l')
                    Console.Write(superWord[iterator] + " ");
                else
                    Console.WriteLine("Not an i ");
                iterator++;
            }

            Console.WriteLine();

            // determining the length of superWord

            iterator = 0;
            while (iterator < superWord.Length)
            {
                iterator++;
            }

            Console.WriteLine(iterator);




            //Switch Statement
            int feelValue = 3;

            Console.Write ("How you are feeling today: ");

            switch(feelValue)
            {
                case 5:
                    Console.WriteLine("Great");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 3:
                    Console.WriteLine("Okay");
                    break;
                case 2:
                    Console.WriteLine("Bad");
                    break;
                case 1:
                    Console.WriteLine(":(");
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;

            }
        }
    }
}
