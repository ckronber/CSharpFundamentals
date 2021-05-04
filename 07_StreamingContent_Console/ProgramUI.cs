using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();

        public void Run()
        {
            // called by program to start application
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Select a menu option: \n" +
                    "1: Create new Content\n" +
                    "2: View all Content\n" +
                    "3: View Content by Title\n" +
                    "4: Update Existing Content\n" +
                    "5: Delete Existing Content \n" +
                    "6: Exit\n");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "banana":
                        //Create New Content
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //View Content By Title
                        break;
                    case "4":
                    case "four":
                        //Update Existing Content
                        break;
                    case "5":
                    case "five":
                        //Delete Existing Content
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }

                Console.WriteLine("\n" +
                    "Please Press any Key to Continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent() //optional challenge - ask user to confirm information before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this Content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description:");
            newContent.Description = Console.ReadLine();

            //Star Rating
            Console.WriteLine("Enter Star Rating for content (0.0 - 5.0): ");
            //string starRatingAsString = Console.ReadLine();
            //double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            //newContent.StarRating = starRatingAsDouble;
            newContent.StarRating = Convert.ToDouble(Console.ReadLine()); //same as above 3 lines

            //GenreType
            Console.WriteLine("Enter the Genre Number for this Content \n" +
                "1. Horror \n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            int genreAsInt = Convert.ToInt32(Console.ReadLine());
            newContent.typeOfGenre = (GenreType)genreAsInt; // casting int to GenreType

            //MaturityRating
            Console.WriteLine("Enter the Maturity rating for this Content\n" +
                "1. G \n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. TV-G\n" +
                "5. TV-PG\n" +
                "6. TV-14\n" +
                "7. TV-R\n" +
                "8. TV-MA\n");

            int ratingAsInt = Convert.ToInt32(Console.ReadLine());
            newContent.MaturityRating = (MaturityRating)ratingAsInt; // casting int to GenreType

            bool wasAddedCorrectly = _repo.AddContentToDirecotry(newContent);//adding it to the repository so we can access it later
            
            if(wasAddedCorrectly)
                Console.WriteLine(newContent.Title + " was added correctly to the Repository.");
            else
                Console.WriteLine("Could not add the content.");


        }
        
        private void DisplayAllContent() //Display all all content in the directory
        {
            Console.Clear(); // clear the menu so we do not have anything there
            List<StreamingContent> AllContent = _repo.getContents();
            
            foreach(StreamingContent content in AllContent)  //holds streamingcontent objects
            {
                Console.ForegroundColor = ConsoleColor.Green; //green text displays in console
                Console.WriteLine($"Title: {content.Title}");
                Console.WriteLine($"Is Family Friendly: {content.isFamilyFriendly}\n");
                Console.ResetColor();
            }
        }
        
        private void DisplayContentByTitle() // get a title from the user then display all properties of the content that has that title
        {
            Console.Clear();
            DisplayAllContent();

            StreamingContent displayContent = new StreamingContent();
            Console.WriteLine("What title do you want to see?");
            
            string titleName = Console.ReadLine();
            displayContent = _repo.GetContentbyTitle(titleName);

            Console.WriteLine($"Title: {displayContent.Title}\n" +
                $"Description: {displayContent.Description}\n" +
                $"Star Rating: {displayContent.StarRating}\n" +
                $"Genre: {displayContent.typeOfGenre}\n" +
                $"Maturity Rating: {displayContent.MaturityRating}\n" +
                $"IsFamilyFriendly: {displayContent.isFamilyFriendly}\n");
        }
    }
}
