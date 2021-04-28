﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while(total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            int someCount = 0;
            bool keepLooping = true;

            while(keepLooping)
            {
                if(someCount <= 100)
                {
                    Console.WriteLine(someCount);
                    someCount++;
                }
                else
                {
                    keepLooping = false;
                }    
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 28;
            int i;
            
            //1 starting point
            //2 Condition
            //3 What to do after each loop
            //4 Body of the loop - what gets executed each loop

                //1         //2      //3
            for(i = 0;i<studentCount;i++)
            {
                //4
                Console.WriteLine(i);
            }

            int e = 0;

            while(e < studentCount)
            {
                Console.WriteLine(++e);
            }
        }

        [TestMethod]
        public void ForeachLooops()
        {
            string[] students = {"Aaron","Alexandra","Andrew","Ben","Chris"};

            //1 Collection being worked on
            //2 Name of the curent iteration
            //3 Type that is held in the collection
            //4 End key word

                    //3      //2   //4    //1
            foreach(string student in students)
                Console.WriteLine(student + " is a student in this class");

            string myName = "Chris Kronberg";

            foreach(char letter in myName)
                Console.Write(letter);
        }

        [TestMethod]
        public void DoWhile()
        {
            int iterator = 0;

            do
            {
                Console.WriteLine("Hello");
                Console.WriteLine(iterator); 
                iterator++;
            } while (iterator < 5);
        }
    }
}