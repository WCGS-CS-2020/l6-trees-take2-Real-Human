using System;
using System.Text;

namespace L6Trees
{
    // Print out the tree using the different tree traversal metods

    class Node
    {
        private Node left;
        private Node right;
        private string itom;

        public Node(string item)
        {
            itom = item;
        }
        public void addNode(string item)
        {
            if (sortAlphabet(item, itom) == true)
            {
                if (left == null)
                    left = new Node(item);
                else
                    left.addNode(item);
            }
            else if (sortAlphabet(item, itom) == false)
            {
                if (right == null)
                    right = new Node(item);
                else
                    right.addNode(item);
            }
        }
        public bool findNode(string item)
        {
            if (item == itom)
                return true;
            else if (sortAlphabet(item, itom) == true)
                return left.findNode(item);
            else if (sortAlphabet(item, itom) == false)
                return right.findNode(item);
            else
                return false;
        }
        //Doesn't work yet
        public bool deleteNode(string item)
        {
            if (item == itom)
            {
                itom = "";
                return true;
            }
            else if (sortAlphabet(item, itom) == true)
            {
                left.deleteNode(item);
            }
            else if (sortAlphabet(item, itom) == false)
            {
                right.deleteNode(item);
            }
            else
            {
                return false;
            }
            return false;
        }
        //Doesn't work yet
        public void printTree(Node next)
        {
            /*if (left != null)
            {
                printTree(left);
            }
            if (right != null)
            {
                printTree(right);
            }
            Console.WriteLine(next);*/
        }

        bool sortAlphabet(string item, string itom)
        {

            byte[] itemAscii = Encoding.ASCII.GetBytes(item);
            byte[] itomAscii = Encoding.ASCII.GetBytes(_item);

            /*if (itemAscii[0] < itomAscii[0])
                return true;
            else if (itemAscii[0] > itomAscii[0])
                return false;
            */

            return itemAscii[0] < itomAscii[0] ? true : false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;

            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };


            // process all the nodes on the array
            //
            foreach (var mon in months)
            {
                if (root == null)
                    root = new Node(mon);
                else
                    root.addNode(mon);
            }

            // print out the tree using different traversal methods
            //

            // Test the findNote() and deleteNode()
        }
    }
}
