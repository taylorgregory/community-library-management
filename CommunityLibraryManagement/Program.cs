using System;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using LibraryManagement;

namespace CommunityLibrary
{
    class Program
    {
        static void DisplayMainMenu()
        {
            // Reset the console
            Console.Clear();

            // Display main menu
            Console.WriteLine("Welcome to the Community Library");
            Console.WriteLine("=========== Main Menu ===========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("=================================");
            Console.WriteLine("Please make a selection (1-2, or 0 to exit):");
        }

        static void DisplayStaffLogin()
        {
            string username;
            string password;

            do {
                // Reset the console
                Console.Clear();

                // should add an error message ?

                Console.Write("Please enter your staff username: ");
                username = Console.ReadLine().ToString();

                Console.Write("Please enter your staff password: ");
                password = Console.ReadLine().ToString(); // do we need to censor password?

            } while (username != "staff" || password != "today123");

            FunctionalStaffMenu();
        }

        static void DisplayStaffMenu()
        {
            // Reset the console
            Console.Clear();

            // Display staff menu
            Console.WriteLine("=========== Staff Menu ===========");
            Console.WriteLine("1. Add a new movie DVD");
            Console.WriteLine("2. Remove a movie DVD");
            Console.WriteLine("3. Register a new member");
            Console.WriteLine("4. Find a registered member's phone number"); 
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("==================================");
            Console.WriteLine("Please make a selection (1-4 or 0 to return to main menu)");
        }

        static void AddMovie()
        {
            // Clear the console
            Console.Clear();

            // Entering movie details
            // need to check validity of each input individually
            Console.WriteLine("1. Add a new movie");
            Console.WriteLine("");

            Console.Write("Movie title: ");
            string ttl = Console.ReadLine().ToString();

            Console.Write("Starring actors (separated by commas): ");
            string star = Console.ReadLine().ToString(); // still need to separate this out
            string[] starArray = StringSplitOptions(star);

            Console.Write("Director: ");
            string dir = Console.ReadLine().ToString();

            Console.Write("Duration: ");
            int dur = int.Parse(Console.ReadLine());

            Console.Write("Genre (Drama, Adventure, Family, Action, SciFi, Comedy, Animated, Thriller or Other)"); // not case sensitive
            string gen = Console.ReadLine().ToString(); // convert this to Genre

            Console.Write("Classification (General (G), ParentalGuidance (PG), Mature (M) or MatureAccompanied (MA)): "); // not case sensitive // maybe remove spaces too?
            string classif = Console.ReadLine().ToString(); // convert this to Classification

            Console.Write("Release Date (dd-mm-yyyy): ");
            string relDate = Console.ReadLine().ToString();

            Console.Write("Available copies: ");
            string availCopies = Console.ReadLine().ToString();

            LibraryManagement.Movie movie = new Movie(ttl, starArray, dir, dur, gen, classif, relDate); //add available copies

            // use movie constructor here to add to movie collection. start with list ?
        }

        private static string[] StringSplitOptions(string star)
        {
            throw new NotImplementedException();
        }

        static void RemoveMovie()
        {
            // ?
        }

        static void RegisterMember()
        {
            // Clear the console
            Console.Clear();

            // Entering member details
            Console.WriteLine("3. Register a new member");
            Console.WriteLine("");
            
            Console.Write("First name: ");
            string fname = Console.ReadLine().ToString();

            Console.Write("Last name: ");
            string lname = Console.ReadLine().ToString();
            
            Console.Write("Address: ");
            string addr = Console.ReadLine().ToString();
            
            Console.Write("Phone number: ");
            string num = Console.ReadLine().ToString();


            // Message shown on successful/unsuccessful registration
            
            // LibraryManagement.Member new = new Member;

            // add an instance to member collection using (name, addr, num)

            Console.WriteLine("");
            Console.WriteLine("New member successfully created!"); // check that it was actually created.
            // Press 1 to add another new member, 2 to return to staff menu, 3 to return to main menu, 4 to exit
        }
        
        static void FindPhoneNumber()
        {
            Console.WriteLine("4. Find a registered member's phone number");
            Console.WriteLine("");
            Console.Write("Please enter the member's full name: ");
            // use getter with name to return phone number
        }

        static void DisplayMemberLogin()
        {
            string username;
            string password;

            do
            {
                // Reset the console
                Console.Clear();

                // should add an error message ?

                Console.Write("Please enter your member username: ");
                username = Console.ReadLine().ToString();

                // while get(username).password == -1,
                // show the screen which gets them to set password

                Console.Write("Please enter your staff password: ");
                password = Console.ReadLine().ToString(); // do we need to censor password?

            } while (username != "staff" || password != "today123"); // change this...

            FunctionalMemberMenu();
        }

        static void DisplayMemberMenu()
        {
            // Reset the console
            Console.Clear();

            // Display member menu 
            Console.WriteLine("=========== Member Menu ===========");
            Console.WriteLine("1. Display all movies");
            Console.WriteLine("2. Borrow a movie DVD");
            Console.WriteLine("3. Return a movie DVD");
            Console.WriteLine("4. List current borrowed movie DVDs");
            Console.WriteLine("5. Display top 10 most popular movies");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===================================");
            Console.WriteLine("Please make a selection (1-5 or 0 to return to main menu");
        }

        static void FunctionalMainMenu()
        {
            string mainMenuSelection;
            do
            {
                DisplayMainMenu();
                mainMenuSelection = Console.ReadLine().ToString();

                switch (mainMenuSelection)
                {
                    case "1":
                        DisplayStaffLogin(); // display staff login
                        break;

                    case "2":
                        DisplayMemberLogin(); // display member login
                        break;

                    case "0":
                        break; // exit 
                }
            } while (mainMenuSelection != "0");
        }

        static void FunctionalStaffMenu()
        {
            string staffMenuSelection;

            do
            {
                DisplayStaffMenu();
                staffMenuSelection = Console.ReadLine().ToString();

                switch (staffMenuSelection)
                {
                    case "1":
                        AddMovie(); // add a new movie DVD
                        break;

                    case "2":
                        RemoveMovie();// remove a movie DVD
                        break;

                    case "3":
                        RegisterMember(); // register new member
                        break;

                    case "4":
                        FindPhoneNumber();// find a registered member's phone number
                        break;

                    case "0":
                        FunctionalMainMenu(); // return to main menu
                        break;
                }
            } while (staffMenuSelection != "0");
        }

        static void FunctionalMemberMenu()
        {
            string memberMenuSelection;

            do
            {
                DisplayMemberMenu();
                memberMenuSelection = Console.ReadKey().ToString();

                switch (memberMenuSelection)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "0":
                        FunctionalMainMenu(); // return to main menu
                        break;
                }
            } while (memberMenuSelection != "0");

        }

        static void Main(string[] args)
        {
            FunctionalMainMenu();
        }
    }
}
