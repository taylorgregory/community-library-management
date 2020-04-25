using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class MovieCollection
    {
        // member binsearchtree? 
        // establishing the initial node or head 
        // buildable

        // `` methods ``

        // add a movie
        static TreeNode AddMovie(Movie movie){ // not sure if this method is complete

            TreeNode temp = new TreeNode
            {
                movie = movie,
                left = null,
                right = null
            };
            return temp;
        }

}

        // create an object of TreeNode 
        // insert the node into binary search tree at correct location

        // remove a movie
        // search binary search tree to find corresponding tree node 
        // remove the node from the tree

        // display all information about all movies
        // tree traversal - displaying only once without missing any out
        // use getters when visiting each node
        // which traversal algorithm to use? (there are 3)

        // display the top 10 most frequently borrowed movies
        // use tree traversal to transform tree into array
        // sort array based on no. of times borrowed


    }
}
