using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        //Using a field to store data
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        
        //CRUD medthods below - Create Read Update Delete

        //Create
        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Show
        
        //Episode

        //Read All
        //Content Read All
        public List<StreamingContent> getContents()
        {
            return _contentDirectory;
        }

        //Movie Read All
        public List<Movie> getMovies()
        {
            //Initialize empty list 
            List<Movie> allMovies = new List<Movie>();
            //Look through our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                //check if object is a Movie class
                if(content is Movie)
                {
                    //Load into our list
                    allMovies.Add(content as Movie);
                }
            }
            return allMovies;
        }

        //Show Read All
        public List<Show> getShows()
        {
            //Setup Our list
            List<Show> allShows = new List<Show>();
            //Find our shows
            foreach (StreamingContent content in _contentDirectory)
            {
                //Check that it is a show
                if (content is Show)
                {
                    //Yes? Add to the list
                    allShows.Add(content as Show);
                }
            }
            return allShows;
        }

        //Episode Read All
       

        //Get by Title
        //Content

        public StreamingContent GetContentbyTitle(string Title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == Title.ToLower())
                    return content;
            }
            return null;
        }

        //Movie
        public StreamingContent GetMoviebyTitle(string Title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.Title.ToLower() == Title.ToLower() && movie is Movie) // Using int is to amke sure move 'is' of type Movie
                {
                    //return (Movie)movie;  // both of these lines are the same
                    return movie as Movie;
                }
            }
            return null;
        }

        //Show
        //GetShowByTitle
        // Accessor // Return Type // Name (Parameters)
        public Show GetShowByTitle(string Title)
        {
            foreach(StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == Title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContent(string originalTitle,StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentbyTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.MaturityRating = newContentValues.MaturityRating;
                oldContent.typeOfGenre = newContentValues.typeOfGenre;
                return true;
            }
            return false;
        }

        //Delete
        public bool DeletExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentbyTitle(titleToDelete);
            if (contentToDelete == null)
                return false;
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
