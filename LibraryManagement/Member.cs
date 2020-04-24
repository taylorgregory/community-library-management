using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Member
    {
        // initialisation
        private string fullName;
        private string address;
        private string phoneNumber;
        private Movie[] movies;

        // constructors
        public Member(string fullName, string address, string phoneNumber, Movie[] movies)
        {
            this.fullName = fullName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.movies = movies;
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

        // what do i do about the movies array??

    }
}
