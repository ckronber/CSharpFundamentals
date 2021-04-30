using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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

            foreach(char x in superWord)
            {
                Console.Write(x + " ");
                iterator++;
            }

            iterator = 0;

            Console.WriteLine();

            while (iterator < superWord.Length)
            {
                if (superWord[iterator] == 'i' || superWord[iterator] == 'l')
                    Console.Write(superWord[iterator] + " ");
                else
                    Console.Write("Not an i ");
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

            //Declare and initialize an array
            string firstname = "Chris", lastName = "Kronberg";
            int age = 33;
            string[] collectionMovies = { "The Bourne Identity", "Bourne Supremacy", "Bourne Ultimatum", "Montey Python and the Holy Grail" };
            DateTime Birthday = new DateTime(1987, 11, 17);


            // Lists are similar to arrays
            List<DateTime> Dates = new List<DateTime>();

            Dates.Add(DateTime.Now);
            Dates.Add(Birthday);
            Dates.Add(DateTime.Today);



            TimeSpan Age = DateTime.Now - Birthday;


            Console.WriteLine(Dates[1]);


            //Write out to the Console the values calculated by your age variable and the number 7
            int myAge = 33;

            double div = myAge / 7;
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
