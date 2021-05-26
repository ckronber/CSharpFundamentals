using System;

namespace _10_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to make a meal");
            Console.ReadKey();
            Kitchen kitchen = new Kitchen();
            Potato potato = new Potato();
            //Synchronously peel a potato
            //Can't do other stuff while peeling a potato
            potato.Peel();

           //Asynchronously drop the frids
           //Asynch so I can do other things
            var fries = kitchen.FryPotatoesAsync(potato);

            var hamburger = kitchen.AssembleHamburger();

            Console.WriteLine("Doing Other Stuff");

            kitchen.ServeMeal(fries.Result,hamburger);

            Console.ReadKey();
        }
    }
}
