using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Async
{
    class Kitchen
    {
        public async Task<Fries> FryPotatoesAsync(Potato potato)  //add async keyword to async methods
        {
            if(potato.IsPeeled)
            {
                Prettyprint("Dropping in the fries",14);
                //await, move on bro, but it's local to the method
                await Task.Delay(5000);
                Prettyprint("The fries are frying!", 14);
                await Task.Delay(5000);
                Prettyprint("The fries are done!",14);
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This potato isn't peeled");
                return null;
            }
        }

        public Hamburger AssembleHamburger()
        {
            var time = 2000;
            Prettyprint("Assembling the Burger", 13);
            Prettyprint("Setting the bun down", 4);
            Task.Delay(time).Wait();
            Prettyprint("Set the patty down gently",12);
            Task.Delay(time).Wait();
            Prettyprint("Place down some cheese", 6);
            Task.Delay(time).Wait();
            Prettyprint("Lettuce, its there now", 10);
            Task.Delay(time).Wait();
            Prettyprint("Remember the pickles", 2);
            Task.Delay(time).Wait();
            Prettyprint("Adding the sauce", 12);
            Task.Delay(time).Wait();
            Prettyprint("Slap the top bun on there", 4);
            Prettyprint("Burger Assembled!!", 13);
            return new Hamburger();
        }

        public bool ServeMeal(Fries fries,Hamburger hamburgy)
        {
            if (fries == null)
            {
                Console.WriteLine("The fries aren't ready");
                return false;
            }
            else
            {
                Console.WriteLine("You combine the burger and fries, and serve the meal");
                return true;
            }
        }

        public void Prettyprint(string step, int color)
        {
            //Black   0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed 4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray    7
            //DarkGray    8
            //Blue    9
            //Green   10
            //Cyan    11
            //Red 12
            //Magenta 13
            //Yellow  14
            //White   15

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(step);
            Console.ResetColor();
        }
    }
}
