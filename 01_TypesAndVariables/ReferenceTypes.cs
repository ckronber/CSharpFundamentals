using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            string firstName = "Chris";
            string lastName = "Kronberg";

            //Concatenation
            string concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            //Compositing
            string compositeFullName = string.Format("{0} {1} is the best coder {2}", firstName, lastName, ", seriously!");
            Console.WriteLine(compositeFullName);

            //Interpolation
            string interpolatedFullName = $"{firstName} \"The Goat\" {lastName} is the best...";
            Console.WriteLine(interpolatedFullName);

        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };

            string interpolatedStrings = $"{stringArray[2]} {stringArray[5]}";
            Console.WriteLine(interpolatedStrings);

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();

            listOfStrings.Add("Hello");
            listOfStrings.Add("World");

            listOfIntegers.Add(23);

            Console.WriteLine(listOfIntegers[0]);  //23
            Console.WriteLine(listOfStrings[1]);  //World

            listOfStrings.Remove(listOfStrings[0]); // Removed Hello

            Console.WriteLine(listOfStrings[0]); //world because Hello was removed

            //Queues
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");
            firstInFirstOut.Enqueue("I'm last");

            string whosFirst = firstInFirstOut.Peek();
            Console.WriteLine(whosFirst);
            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string whosFirstNow = firstInFirstOut.Peek(); // looks at what is about to dequeue
            Console.WriteLine(whosFirstNow);

            //Dictionaries
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(001, "EFA Office");

            string badgeDoor = keyAndValue[001];
            Console.WriteLine(badgeDoor);

            //SortedLists
            // you can make a predetermined sorted list, not sure why this is useful but might be

            //HashSet
                // like a set but has some aditional methods

            //Stack
                // like a queue but it is FILO instead of FIFO
        }
    }

}