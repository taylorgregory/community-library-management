using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LibraryManagement
{
    public class Movie
    {
        // initialisation
        private string title;
        private string[] starring;
        private string director;
        private int duration;
        public enum Genre { Drama, Adventure, Family, Action, SciFi, Comedy, Animated, Thriller, Other };
        private Genre genre;
        public enum Classification { General, ParentalGuidance, Mature, MatureAccompanied };
        private Classification classification;
        private string releaseDate;
        private int totalCopies;
        private int copiesAvailable;
        private int borrowHistory;


        // constructor
        public Movie(string title, string[] starring, string director, int duration, Genre genre, Classification classification, string releaseDate, int totalCopies)
        {
            this.title = title;
            this.starring = starring;
            this.director = director;
            this.duration = duration;
            this.genre = genre;
            this.classification = classification;
            this.releaseDate = releaseDate;
            this.totalCopies = totalCopies;
            this.copiesAvailable = totalCopies;
            this.borrowHistory = 0;
        }

        // getters and setters
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string[] Starring 
        {
            get { return starring; }
            set { starring = value; }
        }

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

        public Genre genre_getset
        {
            get { return genre; }
            set { genre = value; }
        }

        public Classification class_getset
        {
            get { return classification; }
            set { classification = value; }
        }

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public int TotalCopies 
        {
            get { return totalCopies; }
            set { totalCopies = value; }
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set { copiesAvailable = value; }
        }
        public int BorrowHistory 
        {
            get { return borrowHistory; }
            set { borrowHistory = value; }
        }
    }
}
