using System;
using System.Collections.Generic;
using System.Linq;
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


    internal class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null; //initializing ROOT to null
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
