using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Member
    {
        // initialisation
        //private string firstName;
        //private string lastName;
        private string fullName;
        private string address;
        private string phoneNumber;
        private Movie[] movies;

        private string username;
        private int password;

        // constructors
        public Member(string firstName, string lastName, string address, string phoneNumber)
        {
            fullName = firstName + " " + lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            username = lastName + firstName;
            password = -1; // means that password has not yet been set. prompt user to change password before first login  
        }

        // getters and setters -- make sure only necessary getters and setters are created !!
        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Movie[] Movies
        {
            get { return movies; }
            set { movies = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}
