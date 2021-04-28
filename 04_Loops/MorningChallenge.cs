using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class MorningChallenge
    {
        [TestMethod]
        public void SuperLoop()
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
                if(superWord[iterator] == 'i' || superWord[iterator] == 'l')
                    Console.Write(superWord[iterator] + " ");
                iterator++;
            }

            Console.WriteLine();

            // determining the length of superWord

            iterator = 0;
            while(iterator < superWord.Length)
            {
                iterator++;
            }

            Console.WriteLine(iterator);
        }
    }
}