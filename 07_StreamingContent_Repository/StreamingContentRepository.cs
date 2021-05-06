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
        public bool AddContentToDirectory(Show newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;

            return wasAdded;
        }

        //Episode
        public bool AddContentToDirectory(Episode newContent,string Show)
        {
            int startingCount = _contentDirectory.Count;

            Show showTitle = GetShowByTitle(Show);

            showTitle.Episode.Add(newContent);
            showTitle.EpisodeCount++;

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;

            return wasAdded;
        }

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
        public List<Episode> GetEpisodes(string Title)
        {
            //Setup the list
            Show SelectedShow = GetShowByTitle(Title);

            //setup get show by title first
            foreach(Episode episode in SelectedShow.Episode) // We have to look through the list
            {
                SelectedShow.Episode.Add(episode);
            }

            return SelectedShow.Episode;
        }
       

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
        public Movie GetMoviebyTitle(string Title)
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

        //Update Movie
        public bool UpdateExistingContent(string MovieTitle,Movie newContent)
        {
            Movie oldContent = GetMoviebyTitle(MovieTitle);
            
           if((oldContent != null) && (oldContent is Movie))
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.typeOfGenre = newContent.typeOfGenre;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.RunTime = newContent.RunTime;
                return true;
            }
            return false;
        }

        //Update Show
        public bool UpdateExistingContent(string showTitle, Show newContent)
        {
            Show oldContent = GetShowByTitle(showTitle);

            if(oldContent!= null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.typeOfGenre = newContent.typeOfGenre;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.Episode = newContent.Episode;
                oldContent.SeasonCount = newContent.SeasonCount;
                oldContent.EpisodeCount = newContent.SeasonCount;
                oldContent.AverageRunTime = newContent.AverageRunTime;
                return true;
            }
            return false;
        }

        //Update Episode
        public bool updateExistingContent(string showUpdate,string epidoseUpdate)
        {
            Show showToUpdate = GetShowByTitle(showUpdate);
            Episode newEpidose = new Episode();

            if(showToUpdate.Episode != null)
            {
                foreach (Episode oldEpisode in showToUpdate.Episode)
                {
                    if (oldEpisode.Title == epidoseUpdate)
                    {
                        oldEpisode.Title = newEpidose.Title;
                        oldEpisode.Runtime = newEpidose.Runtime;
                        oldEpisode.EpisodeNumber = newEpidose.EpisodeNumber;
                        oldEpisode.SeasonNumber = newEpidose.SeasonNumber;
                        return true;
                    }
                }
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
        //Delete Movie
        public bool DeleteExistingMovie(string MovieToDelete)
        {
            Movie movieToDelete = GetMoviebyTitle(MovieToDelete);

            if(movieToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(movieToDelete);
                return true;
            }
        }
        //Delete Show
        public bool DeleteExistingShow(string ShowToDelete)
        {
            Show showToDelete = GetShowByTitle(ShowToDelete);
            if (showToDelete == null)
                return false;
            else
            {
                _contentDirectory.Remove(showToDelete);
                return true;
            }    
        }
        //Delete Episode
        public bool DeleteExistingEpisode(string showWithEpisode,string EpisodeTitle)
        {
            Show EpToDelete = GetShowByTitle(showWithEpisode);

            foreach(Episode episode in EpToDelete.Episode)
            {
                if(episode.Title == EpisodeTitle)
                {
                    EpToDelete.Episode.Remove(episode);
                    EpToDelete.EpisodeCount--;
                    return true;
                }
            }
            return false;
        }
    }
}
