using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the NOde Class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }
    // a Node class consists of three things, the information, references to the right child, and references


    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; //initializing ROOT to null
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            //This function searchs the currentNode of the specified Node as well as the current Node of parentss 
            currentNode = ROOT;
            parent = null;
            while((currentNode != null ) && (currentNode.info != element))
            {
                parent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string element) //Insert a node in the binary sesarch tree
        {
            Node tmp, parent = null, currentNode = null;
            search(element, ref parent, ref currentNode);
            if (currentNode != null) // check if the node to be inserted already inserted or not
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else // if the specified node is not present 
            {
                tmp = new Node(element, null, null); //creates a Node
                if (parent == null) //if the trees is empty
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
            
        }
        public void inorder(Node ptr)
        {
            if(ROOT == null)
            {
                Console.WriteLine("Tree is empty");

            }
        }
        public void preorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is Empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + " ");
                preorder(ptr.leftchild);
                preorder(ptr.rightchild);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
