using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class MemberCollection
    {
        // initialisation/getters and setters 
        public static Member[] MemberArray { get; set; }
        public static int MemIncrement { get; set; }

        public static bool AddMemberToArray(Member member, Member[] memArray)
        {
            // method to add a new member to the member array
            // checks if member capacity has been reached and if there is already a member registered with the same full name
            // input: the member to be added, the array that the member will be added to
            // output: boolean value to indicate if the member was successfully added to the member array

            for (int i = 0; i < memArray.Length; i++)
            {
                if (memArray[i] == null)
                {
                    break;
                }
                else if (memArray[i].FullName == member.FullName) // duplicate full names are not allowed
                {
                    Console.WriteLine();
                    Console.WriteLine("A user with this name is already registered. Please use another name.");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    break;
                }
            }

            if (MemIncrement < 10) { // maximum of 10 members in the member array
                memArray[MemIncrement] = member;
                MemIncrement += 1;
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Member capacity has been reached. No more members can be registered.");
                Console.WriteLine();
                return false;
            }   
        }

        public static void SearchForMemberInArray(string fullName, Member[] memArray)
        {
            // method to search for a member in the array and print their phone number
            // input: full name of the member, the member array that will be searched 

            bool found = false;
            for (int i = 0; i < memArray.Length; i++)
            {
                if (memArray[i] != null && memArray[i].FullName == fullName) // if there is a member that corresponds to the entered full name
                {
                    found = true;
                    Console.WriteLine();
                    Console.WriteLine(fullName + "'s phone number is " + memArray[i].PhoneNumber);
                    Console.WriteLine();   
                }
            }
            if (!found)
            {
                // this code only executes if no members in the system have the entered full name
                Console.WriteLine();
                Console.WriteLine("There are no members in the system with the full name " + fullName + ".");
                Console.WriteLine();
            }
        }
    }
}
