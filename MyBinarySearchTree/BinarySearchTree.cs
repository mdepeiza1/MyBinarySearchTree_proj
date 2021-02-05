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
                    if (nodeToAdd.data < focusNode.data)
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
                    else if(nodeToAdd.data > focusNode.data)
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
        public bool Search(int whatToSearchFor)
        {
            Node focusNode = rootNode;
            while(focusNode != null)
            {
                if(whatToSearchFor == focusNode.data)
                {
                    return true;
                }
                else if(whatToSearchFor < focusNode.data)
                {
                    focusNode = focusNode.leftNode;
                }
                else
                {
                    focusNode = focusNode.rightNode;
                }
            }
            return false;
        }
    }
}