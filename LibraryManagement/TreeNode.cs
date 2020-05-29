using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class TreeNode
    {
        // initialisation/getters and setters
        public TreeNode left { get; set; }
        public Movie data { get; set; }
        public TreeNode right { get; set; }

        public static void DisplayData(TreeNode node)
        {
            // method to display all relevant information about a given movie with appropriate formatting 
            // input: node that contains the movie that is to be displayed

            Console.WriteLine("Title: " + node.data.Title);

            Console.Write("Starring:");
            for (int i = 0; i < node.data.Starring.Length - 1; i++)
            {
                Console.Write(" " + node.data.Starring[i] + ',');
            }
            Console.Write(" " + node.data.Starring[node.data.Starring.Length - 1]); // putting this outside of the loop means it won't finish on a comma
            Console.WriteLine();

            Console.WriteLine("Director: " + node.data.Director);

            Console.WriteLine("Duration: " + node.data.Duration);

            Console.WriteLine("Genre: " + node.data.genre_getset);

            Console.WriteLine("Classification: " + node.data.class_getset);

            Console.WriteLine("Release Date: " + node.data.ReleaseDate);

            Console.WriteLine("Available Copies: " + node.data.CopiesAvailable.ToString());

            Console.WriteLine();
        }
    }
}
