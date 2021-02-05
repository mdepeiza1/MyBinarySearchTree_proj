using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(new Node(3));
            bst.Add(new Node(5));
            bst.Add(new Node(1));
            bst.Add(new Node(4));
            bst.Add(new Node(7));

            bst.Search(new Node(7));
            bst.Search(new Node(9));
        }
    }
}
