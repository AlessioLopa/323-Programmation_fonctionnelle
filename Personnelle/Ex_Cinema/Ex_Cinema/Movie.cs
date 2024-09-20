using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Cinema
{
    public class Movie
    {
        public Movie()
        {
        }

        public Movie(string title, string genre, double rating, int year, string[] languageOptions, string[] streamingPlatforms)
        {
            Title = title;
            Genre = genre;
            Rating = rating;
            Year = year;
            LanguageOptions = languageOptions;
            StreamingPlatforms = streamingPlatforms;
        }

        public string Title { get; set; }
        public string Genre { get; set; }

        public double Rating { get; set; }
        public int Year { get; set; }

        public string[] LanguageOptions { get; set; }

        public string[] StreamingPlatforms { get; set; }
    }
}
