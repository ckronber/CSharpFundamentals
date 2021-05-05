using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class Movie:StreamingContent
    {
        public Movie() { }
        //base with 1 added constructor 
        public Movie(string title, string description, double stars,MaturityRating maturity,GenreType genre, double runTime) : base(title, description, stars, genre, maturity)
        {
            //Setting properties that aren't included in the base constructor
            this.RunTime = runTime;
        }
        public double RunTime { get; set; }
    }
}
