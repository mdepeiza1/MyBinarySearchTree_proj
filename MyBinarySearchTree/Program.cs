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

            bool search1;
            bool search2;
            search1 = bst.Search(7);
            search2 = bst.Search(9);
        }
    }
}
