using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LibraryManagement
{
    public class MovieCollection
    {
        private static TreeNode root; // global variable root for the BST root
        public static int index = 0; // index to keep track of index when traversing the BST (and adding to array)

        // getter and setter
        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }

        public static bool AddMovieToTree(MovieCollection movCol, Movie movie)
        {
            // adds movie to BST according to alphabetical order of title
            // input: movie collection that the movie will be added to, the movie that will be added
            // output: boolean value indicating whether the movie was successfully added to the tree or not

            string movieNodeName = movie.Title;

            // using the root as the starting point
            TreeNode before = null;
            TreeNode after = movCol.Root;

            // traversing to find its spot in the tree
            // note that if there is no root, then this while loop does not run (as after == null)
            while (after != null)
            {
                before = after;
                if (string.Compare(movieNodeName, after.data.Title) == -1) 
                {
                    after = after.left; // movieNodeName is first alphabetically, so move to the left of the BST
                } 
                else if (string.Compare(movieNodeName, after.data.Title) == 1) 
                { 
                    after = after.right; // after.data.Title is first alphabetically, so move to the right of the BST
                } 
                else // movies have the same title and are rejected (no duplicate titles allowed)
                {
                    return false;
                }
            }

            TreeNode insertedNode = new TreeNode(); // create new tree node
            insertedNode.data = movie; // giving new treenode the new movie as its data

            if (movCol.Root == null) // if this is the beginning of the tree (i.e. there is no previous root)
            {
                movCol.Root = insertedNode; // the new node becomes the root
            } 
            else 
            {
                if (string.Compare(movieNodeName, before.data.Title) == -1) 
                {
                    before.left = insertedNode; // movieNodeName is first alphabetically, so place it to the left of the BST
                } else {
                    before.right = insertedNode; // after.data.Tile is first alphabetically, so place it to the right of the BST
                }
            }
            return true;
        }


        public static void RemoveMovieFromTree(Movie movie)
        {
            // public method to remove movie from BST
            // input: movie that will be removed from tree

            root = RemoveMovieFromTree(root, movie); // calling the private method with the root specified
        }

        private static TreeNode RemoveMovieFromTree(TreeNode parent, Movie movie)
        {
            // private method to remove movie from BST
            // input: parent of the tree (in this case, the root), the movie that will be removed from the tree

            if (parent == null)
            {
                return parent;
            }

            if (string.Compare(movie.Title, parent.data.Title) == -1) // if movie comes first alphabetically
            {
                parent.left = RemoveMovieFromTree(parent.left, movie);
            }
            else if (string.Compare(movie.Title, parent.data.Title) == 1) // if parent comes first alphabetically
            {
                parent.right = RemoveMovieFromTree(parent.right, movie);
            }
            else // if value is same as parent's value, then this is the node to be deleted  
            {
                // node with only one child or no child  
                if (parent.left == null)
                    return parent.right;
                else if (parent.right == null)
                    return parent.left;

                // node with two children: get the first alphabetically in the right subtree
                parent.data = FirstAlph(parent.right);

                // delete the first alphabetically in the right subtree  
                parent.right = RemoveMovieFromTree(parent.right, parent.data);
            }

            return parent;
        }

        private static Movie FirstAlph(TreeNode node)
        {
            // method to determine which movie is first alphabetically in the tree
            // input: specified TreeNode
            // this method is called in RemoveMovieFromTree()

            Movie FAlph = node.data;

            while (node.left != null)
            {
                FAlph = node.left.data;
                node = node.left;
            }
            return FAlph;
        }

        public static TreeNode FindMovieInTree(string title)
        {
            // public method to find movie in BST
            // input: title of movie that is searched for in BST

            return FindMovieInTree(title, root); // calling the private method with the root specified
        }

        private static TreeNode FindMovieInTree(string title, TreeNode parent)
        {
            // private method to find movie in BST
            // input: title of movie that is searched for in BST, parent of the tree (in this case, the root)

            if (parent != null)
            {
                if (title == parent.data.Title) // if title is equal to the parent title then we are done (i.e. we have found the movie)
                {
                    return parent;
                }
                if (string.Compare(title, parent.data.Title) == -1) // if title is earlier than the parent alphabetically 
                {
                    return FindMovieInTree(title, parent.left);
                }
                else 
                {
                    return FindMovieInTree(title, parent.right);
                }
            }
            return null;
        }

        public static void DisplayAllMoviesInTree()
        {
            // private method for in-order tree traversal to display movies alphabetically

            DisplayAllMoviesInTree(root); // calling private method with root specified
        }

        private static void DisplayAllMoviesInTree(TreeNode Root)
        {
            // public method for in-order tree traversal to display movies alphabetically
            // input: root of the tree

            if (Root == null)
            {
                return;
            }
            
            DisplayAllMoviesInTree(Root.left);
            TreeNode.DisplayData(Root); // calls a TreeNode method which prints relevant movie information to the screen
            DisplayAllMoviesInTree(Root.right);
        }

        public static Movie[] PutAllMoviesInArray(Movie[] movies)
        {
            // public method to add all movies to an array from BST based on an in-order traversal
            // input: the movie array that the movies are being added to

            return PutAllMoviesInArray(root, movies); // calling the private method with the root specified
        }

        private static Movie[] PutAllMoviesInArray(TreeNode Root, Movie[] movies)
        {
            // private method to add all movies to an array from BST based on an in-order traversal
            // input: the root of the tree/subtree, the movie array that the movies are being added to

            if (Root == null)
            {
                return null;
            }

            PutAllMoviesInArray(Root.left, movies);
            movies[index++] = Root.data; // incrementing the global variable index so the Root is added to the next position in the array
            PutAllMoviesInArray(Root.right, movies);

            return movies;
        }

        public static Movie[] SortByPopularity(Movie[] movArray)
        {
            // implementing bubble sort to sort the movie array in descending order
            // input: unsorted movie array (with no null elements)
            // output: sorted movie array (in descending order according to borrow history)

            for (int i = 0; i < movArray.Length; i++)
            {
                for (int j = 0; j < movArray.Length; j++)
                {
                    if (movArray[i].BorrowHistory > movArray[j].BorrowHistory)
                    {
                        Movie temporarySwap = movArray[i];
                        movArray[i] = movArray[j];
                        movArray[j] = temporarySwap;
                    }
                }
            }
            return movArray;  
        }



    }
}




        
