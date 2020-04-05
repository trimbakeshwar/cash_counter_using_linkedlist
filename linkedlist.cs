using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter
{
    public class linkedList//linkedlist class 
    {

        internal node head;
        /*crete a structur node and address of next node
         * intialize by using constructor
         * */
        internal class node//node class create node , next structur
        {
            internal int data;//data
            internal node next;//address of next node
            public node(int value)//constructor for initialization
            {
                data = value;
                next = null;
            }
        }
        /*
         * if linkedlist empty then add at head 
         * no need to any loop
         * if any node available at start then
         * add node at last
         * 
         */
        internal void insertAtLast(int value)//insert people in last
        {
            //   Console.WriteLine("linkedlist called");
            node newNode = new node(value);
            newNode.next = null;
            if (head == null)
            {

                head = newNode;
            }
            else
            {
                node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        internal void removeAtFirst()// remove people first and shows remaining mony
        {
            node temp = head.next;
            head = temp;
        }
        internal void printList()//print the data 
        {
            node currentNode = head;
            while (currentNode.next != null)
            {
                Console.WriteLine(currentNode.data + " ");
                currentNode = currentNode.next;
            }
        }
    }
}
