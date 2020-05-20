using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class MemberCollection
    {
        public static Member[] MemberArray { get; set; }
        public static int MemIncrement { get; set; }

        public static bool AddMemberToArray(Member member, Member[] memArray)
        {
            for (int i = 0; i < memArray.Length; i++)
            {
                if (memArray[i] == null)
                {
                    break;
                }
                else if (memArray[i].FullName == member.FullName)
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

            if (MemIncrement < 10) {// maximum of 10 members in the member array
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
            for (int i = 0; i < memArray.Length; i++)
            {
                if (memArray[i] == null)
                {
                    Console.WriteLine();
                    Console.WriteLine("There are no members in the system with the full name " + fullName + ".");
                    Console.WriteLine();
                    break;
                }
                else if (memArray[i].FullName == fullName)
                {
                    Console.WriteLine();
                    Console.WriteLine(fullName + "'s phone number is " + memArray[i].PhoneNumber);
                    Console.WriteLine();
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("There are no members in the system with the full name " + fullName + ".");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
