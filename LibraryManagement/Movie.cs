using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Movie
    {
        // data members, data fields or characteristics
        private string title;
        private string[] starring; // made this an array because there could be several people?
        private string director;
        private int duration; //min
        private enum Genre { Drama, Adventure, Family, Action, SciFi, Comedy, Animated, Thriller, Other };
        private Genre genre;
        private enum Classification { General, ParentalGuidance, Mature, MatureAccompanied };
        private Classification classification;
        private string releaseDate;

        // constructor

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

        // genre

        // classification

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
    }
}
