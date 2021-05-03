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
        public bool AddContentToDirecotry(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        

    }
}
