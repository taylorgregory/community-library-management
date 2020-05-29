using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Member
    {
        // initialisation / getters and setters
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Movie[] Movies { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // constructor
        public Member(string firstName, string lastName, string address, string phoneNumber)
        {
            FullName = firstName + " " + lastName; // full name is constructed based on user input for first name and last name
            Address = address;
            PhoneNumber = phoneNumber;
            Movies = null; // no movies borrowed at this point
            Username = lastName + firstName;
            Password = "none"; // means that password has not yet been set. prompt user to change password before first login  
        }
    }
}
