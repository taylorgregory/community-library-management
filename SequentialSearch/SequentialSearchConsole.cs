using System;

namespace SequentialSearch
{
    class SequentialSearchConsole
    {
        // Searches for a given value in a given array by sequential search
        // Input: An array A[0..n-1] and a search key K
        // Output: The index of the first element of A that matches K or -1 if there are no matching elements
        static void Main()
        {
            // Defining the array to be searched from user input
            Console.WriteLine("Type each element of the array that you would be searched. Separate each element with a single space. Press ENTER when complete.");
            string input = Console.ReadLine();
            string[] splitString = input.Split(" ");
            int[] inArray = new int[splitString.Length];

            for (int i = 0; i < splitString.Length; i++)
            {
                inArray[i] = int.Parse(splitString[i]);
            }

            // Defining the search key from user input
            Console.WriteLine("Type the value you would like to search for.");
            int searchKey = int.Parse(Console.ReadLine());

            // Sequential search algorithm
            int j = 0;
            while ((j < inArray.Length) && (inArray[j] != searchKey))
            {
                j += 1;
            }
            if (j < inArray.Length)
            {
                Console.WriteLine("The index of the search key is " + j.ToString());
            }
            else
            {
                Console.WriteLine("The search key does not appear in the given array");
            }
        }
    }
}
