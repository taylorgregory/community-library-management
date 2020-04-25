using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Movie
    {
        // initialisation
        private string title;
        private string[] starring; // several people?
        private string director;
        private int duration; //min
        public enum Genre { Drama, Adventure, Family, Action, SciFi, Comedy, Animated, Thriller, Other };
        private Genre genre;
        public enum Classification { General, ParentalGuidance, Mature, MatureAccompanied };
        private Classification classification;
        private string releaseDate;

        private int borrowHistory;
        private int copiesAvailable;

        // constructor
        public Movie(string title, string[] starring, string director, int duration, Genre genre, Classification classification, string releaseDate)
        {
            this.title = title;
            this.starring = starring;
            this.director = director;
            this.duration = duration;
            this.genre = genre;
            this.classification = classification;
            this.releaseDate = releaseDate;
        }

        // getters and setters
        public string Title
        {
            get { return title; }
            set { title = value; }
        }



        // **** not sure about array (starring)

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        // genre (??)

        // classification (??)

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
    }
}
