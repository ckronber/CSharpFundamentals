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

        //Read
        public List<StreamingContent> getContents()
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentbyTitle(string Title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == Title.ToLower())
                    return content;
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
