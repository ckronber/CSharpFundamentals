using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private IConsole _console;
        private StreamingContentRepository _repo = new StreamingContentRepository();

        // Using Dependency Injection here
        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            // called by program to start application
            SeedContentList(); // if you want to interface with a different menu start here
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                _console.WriteLine("Select a menu option: \n" +
                    "1: Create new Content\n" +
                    "2: View all Content\n" +
                    "3: View Content by Title\n" +
                    "4: Update Existing Content\n" +
                    "5: Delete Existing Content \n" +
                    "6: Exit\n");

                string input = _console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                    case "banana":  // cheat to create content
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
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //Update Existing Content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //Delete Existing Content
                        deleteExistingContent();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number.");
                        break;
                }

                _console.WriteLine("\n" +
                    "Please Press any Key to Continue");
                _console.ReadKey();
                _console.Clear();
            }
        }
        private void CreateNewContent() //optional challenge - ask user to confirm information before adding to directory
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the title for this Content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the Description:");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter Star Rating for content (0.0 - 5.0): ");
            //string starRatingAsString = Console.ReadLine();
            //double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            //newContent.StarRating = starRatingAsDouble;
            newContent.StarRating = Convert.ToDouble(_console.ReadLine()); //same as above 3 lines

            //GenreType
            _console.WriteLine("Enter the Genre Number for this Content \n" +
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
            _console.WriteLine("Enter the Maturity rating for this Content\n" +
                "1. G \n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. TV-G\n" +
                "5. TV-PG\n" +
                "6. TV-14\n" +
                "7. TV-R\n" +
                "8. TV-MA\n");

            int ratingAsInt = Convert.ToInt32(_console.ReadLine());
            newContent.MaturityRating = (MaturityRating)ratingAsInt; // casting int to GenreType

            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);//adding it to the repository so we can access it later

            if (wasAddedCorrectly)
                _console.WriteLine(newContent.Title + " was added correctly to the Repository.");
            else
                _console.WriteLine("Could not add the content.");


        }

        private void DisplayAllContent() //Display all all content in the directory
        {
            _console.Clear(); // clear the menu so we do not have anything there
            List<StreamingContent> AllContent = _repo.getContents();

            foreach (StreamingContent content in AllContent)  //holds streamingcontent objects
            {
                Console.ForegroundColor = ConsoleColor.Green; //green text displays in console
                _console.WriteLine($"Title: {content.Title}");
                _console.WriteLine($"Is Family Friendly: {content.isFamilyFriendly}\n");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle() // get a title from the user then display all properties of the content that has that title
        {
            _console.Clear();
            DisplayAllContent();

            StreamingContent displayContent = new StreamingContent();
            _console.WriteLine("What title do you want to see?");

            string titleName = _console.ReadLine();
            displayContent = _repo.GetContentbyTitle(titleName);

            _console.Clear(); //clears the screen

            if (displayContent != null)
            {
                _console.WriteLine($"Title: {displayContent.Title}\n" +
                    $"Description: {displayContent.Description}\n" +
                    $"Star Rating: {displayContent.StarRating}\n" +
                    $"Genre: {displayContent.typeOfGenre}\n" +
                    $"Maturity Rating: {displayContent.MaturityRating}\n" +
                    $"IsFamilyFriendly: {displayContent.isFamilyFriendly}\n");
            }
            else
            {
                _console.WriteLine("Title was not found in repository");
            }
        }

        private void UpdateContent()
        {
            DisplayAllContent();

            _console.WriteLine("Enter the title to update content");
            string oldTitle = _console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            _console.WriteLine("What is the new title for this Content?");
            newContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Enter the new Description:");
            newContent.Description = _console.ReadLine();

            //Star Rating
            _console.WriteLine("Enter new Star Rating for content (0.0 - 5.0): ");
            //string starRatingAsString = _console.ReadLine();
            //double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            //newContent.StarRating = starRatingAsDouble;
            newContent.StarRating = Convert.ToDouble(_console.ReadLine()); //same as above 3 lines

            //GenreType
            _console.WriteLine("Enter the new Genre Number for this Content \n" +
                "1. Horror \n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            int genreAsInt = Convert.ToInt32(_console.ReadLine());
            newContent.typeOfGenre = (GenreType)genreAsInt; // casting int to GenreType

            //MaturityRating
            _console.WriteLine("Enter the new Maturity rating for this Content\n" +
                "1. G \n" +
                "2. PG\n" +
                "3. PG-13\n" +
                "4. TV-G\n" +
                "5. TV-PG\n" +
                "6. TV-14\n" +
                "7. TV-R\n" +
                "8. TV-MA\n");

            int ratingAsInt = Convert.ToInt32(_console.ReadLine());
            newContent.MaturityRating = (MaturityRating)ratingAsInt;

            bool isUpdated = _repo.UpdateExistingContent(oldTitle, newContent);

            if (isUpdated)
                _console.WriteLine($"{oldTitle} has been updated to {newContent.Title}");
            else
                _console.WriteLine("Failed to update.");
        }

        private void deleteExistingContent()
        {
            _console.Clear();
            DisplayAllContent();

            _console.WriteLine("Enter the Title You would like to delete: ");
            string titleToDelete = _console.ReadLine();
            bool wasDeleted = _repo.DeletExistingContent(titleToDelete);

            if (wasDeleted)
                _console.WriteLine($"{titleToDelete} was deleted.");
            else
                _console.WriteLine("Contents could not be deleted");
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets accidentally tranported back in time", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar Saves the Day", 3.1, GenreType.SciFi, MaturityRating.PG_13);
            StreamingContent rubber = new StreamingContent("Rubber", "A car tire comes to life and goes on a killing spree", 1.2, GenreType.Horror, MaturityRating.R);

            //adds the these to the directory
            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);

            //add a list
            //List<StreamingContent> seedContent = new List<StreamingContent>();
            //seedContent.Add(future)
        }

    }
}
