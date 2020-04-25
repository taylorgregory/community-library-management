using System;
using System.ComponentModel.Design;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace CommunityLibrary
{
    class Program
    {
        static int mainMenuSelection;
        static int staffMenuSelection;
        static int memberMenuSelection;

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
            string username = null;
            string password;

            do
            {
                // Reset the console
                Console.Clear();

                if (!string.IsNullOrEmpty(username)) // this means that it is not the first time this has happened --- not necessarily...
                {
                    Console.WriteLine("Incorrect username or password. Press any key to try again or press 0 to return to the main menu.");
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine("Please enter your staff username: ");
                username = Console.ReadLine().ToString();

                Console.WriteLine("Please enter your staff password");
                password = Console.ReadLine().ToString(); // do we need to censor password?

            } while (username != "staff" || password != "today123");

            DisplayStaffMenu();
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

        }

        static void RemoveMovie()
        {

        }

        static void RegisterMember()
        {
            Console.WriteLine("3. Register a new member");
            Console.WriteLine("");
            
            Console.Write("Full name: ");
            string name = Console.ReadLine().ToString();
            
            Console.Write("Address: ");
            string addr = Console.ReadLine().ToString();
            
            Console.Write("Phone number: ");
            string num = Console.ReadLine().ToString(); 

            // LibraryManagement.Member new = new Member;

            // add an instance to member collection using (name, addr, num)
        }

        static string FindPhoneNumber(string name)
        {
            string number = 

            return "answer"; 
        }

        static void DisplayMemberLogin()
        {

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
            do
            {
                DisplayMainMenu();
                mainMenuSelection = Convert.ToInt32(Console.ReadKey().KeyChar);
                Console.WriteLine(mainMenuSelection.ToString());
                Console.ReadKey();

                switch (mainMenuSelection)
                {
                    case 149:
                        FunctionalStaffMenu(); // display staff menu
                        break;

                    case 2:
                        FunctionalMemberMenu(); // display member menu
                        break;

                    case 0:
                        break; // exit 
                }
            } while (mainMenuSelection != 0);
        }

        static void FunctionalStaffMenu()
        {
            do
            {
                DisplayStaffMenu();
                staffMenuSelection = (int)Console.ReadKey().KeyChar;

                switch (staffMenuSelection)
                {
                    case 1:
                        // add a new movie DVD
                        break;

                    case 2:
                        // remove a movie DVD
                        break;

                    case 3:
                        // register a new member
                        break;

                    case 4:
                        // find a registered member's phone number
                        break;

                    case 0:
                        FunctionalMainMenu(); // return to main menu
                        break;
                }
            } while (memberMenuSelection != 0);
        }

        static void FunctionalMemberMenu()
        {
            DisplayMemberMenu();
            memberMenuSelection = (int)Console.ReadKey().KeyChar;

            switch (memberMenuSelection)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;

                case 0:
                    FunctionalMainMenu(); // return to main menu
                    break;
            }
        }

        static void Main(string[] args)
        {
            DisplayStaffLogin();
        }
    }
}
