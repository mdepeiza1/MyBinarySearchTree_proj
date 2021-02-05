using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;

        public void Add(Node nodeToAdd)
        {
            if(rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node focusNode = rootNode;
                while (true)
                {
                    if (nodeToAdd.data.CompareTo(focusNode.data) < 0)
                    {
                        if (focusNode.leftNode == null)
                        {
                            focusNode.leftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.leftNode;
                        }
                    }
                    else if(nodeToAdd.data.CompareTo(focusNode.data) > 0)
                    {
                        if (focusNode.rightNode == null)
                        {
                            focusNode.rightNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            focusNode = focusNode.rightNode;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public Node Search(Node nodeToSearchFor)
        {
            Node focusNode = rootNode;
            while(focusNode != null)
            {
                if(nodeToSearchFor.data.CompareTo(focusNode.data) == 0)
                {
                    return focusNode;
                }
                else if(nodeToSearchFor.data.CompareTo(focusNode.data) < 0)
                {
                    focusNode = focusNode.leftNode;
                }
                else
                {
                    focusNode = focusNode.rightNode;
                }
            }
            return focusNode;
        }
    }
}