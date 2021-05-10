using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    class FunConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        public ConsoleKeyInfo ReadKey()
        {
            Console.WriteLine("Reading your keypress, I swear I won't sell this data to a third party");
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            string input = Console.ReadLine();
            return input.ToUpper();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            Random rand = new Random();
            int bgColor = rand.Next(0,4);
            
            switch (bgColor)
            {
                case 0:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case 1:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 3:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }

            Thread.Sleep(bgColor);

            string derpString = "";
            bool capitalize = false;
            foreach(char c in s)
            {
                if (capitalize)
                {
                    derpString += c.ToString().ToUpper();
                    capitalize = false;
                }
                else
                {
                    derpString += c.ToString().ToLower();
                    capitalize = true;
                }
            }

            Console.WriteLine(derpString);
        }

        public void WriteLine(object o)
        {
            Console.WriteLine(o);
        }

        public void WriteLine(DateTime d)
        {
            Console.WriteLine(d);
        }
    }
}
