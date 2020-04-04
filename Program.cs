using System;

namespace cash_counter
{

    public class linkedList//linkedlist class 
    {

        internal node head;
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
        internal void insertAtLast(int value)//insert people in last
        {
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
        class banking
        {


            public int depositCash(int cash, int ubalance)//user deposit cash
            {

                ubalance += cash;
                return ubalance;
            }
            public int withdrawCash(int cash, int ubalance)//user withdraw cash
            {
                if (ubalance <= 0)
                {
                    Console.WriteLine("cash is not available");
                    return 0;
                }
                else
                {
                    ubalance -= cash;
                    return ubalance;
                }
            }

        }
        class Program
        {
            static void Main(string[] args)
            {


                linkedList list = new linkedList();
                int count = 0;
                Console.WriteLine("enter no of people");
                int noOfPeopleInQue = Convert.ToInt32(Console.ReadLine()); ;
                banking bank = new banking();
                do
                {
                    int userBalance = 5000;
                    int ubalance = userBalance;
                    int totalBalanceOfUser = 0;
                    Console.WriteLine("enter cash ");
                    int cash = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("please enter 1 for deposit 2 for withdraw");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            totalBalanceOfUser = bank.depositCash(cash, ubalance);
                            list.insertAtLast(totalBalanceOfUser);
                            Console.WriteLine("balance is .. " + totalBalanceOfUser);
                            list.removeAtFirst();
                            cash = 0;
                            break;

                        case 2:
                            if (ubalance < cash)
                            {
                                Console.WriteLine("not ifficient cash");
                            }
                            else
                            {
                                totalBalanceOfUser = bank.withdrawCash(cash, ubalance);
                                list.insertAtLast(totalBalanceOfUser);
                                Console.WriteLine("balance is .. " + totalBalanceOfUser);
                                list.removeAtFirst();
                                cash = 0;
                            }
                            break;

                    }
                    count++;
                } while (count < noOfPeopleInQue);


            }
        }
    }
}
