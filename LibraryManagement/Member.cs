using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Member
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Movie[] Movies { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // constructor
        public Member(string firstName, string lastName, string address, string phoneNumber)
        {
            FullName = firstName + " " + lastName;
            Address = address;
            PhoneNumber = phoneNumber;
            Movies = null; // not sure if this is correct?
            Username = lastName + firstName;
            Password = "none"; // means that password has not yet been set. prompt user to change password before first login  
        }
    }
}
