using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum GenreType
    {
        Horror, RomCom, SciFi, Documentary, Romance, Drama, Action,Comedy,Anime
    }
    public enum MaturityRating
    {
        G = 1,PG,PG_13,TV_G,TV_PG,TV_14,R,TV_MA
    }
    public class StreamingContent
    {
        //POCO - Plain old C# Object
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public GenreType typeOfGenre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool isFamilyFriendly {
            get
            {
                //Turnary
                // bool isFamilyFriendly = ((int)MaturityRating <= 6) ? true : false;
                if (MaturityRating == MaturityRating.TV_MA || MaturityRating == MaturityRating.R)
                    return false;
                else
                    return true;
            }
        }

        public StreamingContent() { }
        public StreamingContent(string title,string description,double starRating, GenreType typeOfGenre, MaturityRating maturityRating)
        {
            this.Title = title;
            this.Description = description;
            this.StarRating = starRating;
            this.typeOfGenre = typeOfGenre;
            this.MaturityRating = maturityRating;
        }
    }
}
