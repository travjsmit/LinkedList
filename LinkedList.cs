using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    public class LinkedList
    {
         public Node? Head {  get; set; }

        // INSERT
        public void InsertHead(int data)
        {
            //Create the node
            Node newNode = new Node();
            //Put the data in the node
            newNode.Data = data;
            // Put the old node in next
            newNode.Next = Head;
            // Make the head the new node
            Head = newNode;
        }

        // DELETE
        public Node DeleteHead()
        {
            // Assign the temporary variable
            Node temp = Head;
            // Assign the next head
            Head = Head.Next;
            return temp;
        }

        // ITERATE
        public void DisplayList()
        {
            Console.WriteLine("Iterating through list...");
            Node current = Head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next; // Iterating
            }
        }

        public void InsertLast(int data)
        {
            Node current = Head;
            while(current.Next  != null)
            {
                current = current.Next; // Iteration
            }
            Node newNode = new Node();
            newNode.Data = data;        // Populate new data
            current.Next = newNode;
        }
    }
}