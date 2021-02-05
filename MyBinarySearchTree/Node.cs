using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinarySearchTree
{
    class Node
    {
        public Node rightNode;
        public Node leftNode;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
