using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_API_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            JokeService jokeService = new JokeService();
            Console.WriteLine("if you would like to see a specific category of joke type it in below");
            Console.WriteLine("Categories: Misc, Programming, Dark, Pun, Spooky, or Christmas");
            Console.Write("Category (leave blank for any joke): ");
            string category = Console.ReadLine().ToLower();
            
            if (category == "")
                category = "Any";
            Joke newJoke = jokeService.getJoke(category).Result;

            if(newJoke != null)
            {
                Console.WriteLine($"\nThis Joke is in Category: {newJoke.Category}");
                Console.WriteLine($"This Joke ID: {newJoke.Id}");
                Console.WriteLine($"Error: {newJoke.Error}");
                Console.WriteLine($"Language of Joke: {newJoke.Lang}");
                Console.WriteLine($"Is Joke Safe?: {newJoke.Safe}");
                Console.WriteLine($"Joke Type: {newJoke.Type}");

                Console.WriteLine($"\nExplicit?: {newJoke.Flags.Explicit}");
                Console.WriteLine($"NSFW?: {newJoke.Flags.Nsfw}");
                Console.WriteLine($"Political?: {newJoke.Flags.Political}");
                Console.WriteLine($"Racist?: {newJoke.Flags.Racist}");
                Console.WriteLine($"Religious?: {newJoke.Flags.Religious}");
                Console.WriteLine($"Sexist?: {newJoke.Flags.Sexist}");

                Console.WriteLine($"\nJoke Setup: {newJoke.Setup}");
                Console.WriteLine($"Joke: {newJoke.Delivery}");
            }
            else
            {
                Console.WriteLine("Joke Not Avaliable");
            }

        }
    }
}
