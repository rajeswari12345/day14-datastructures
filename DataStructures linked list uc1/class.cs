using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataStructuresDemo
{
    internal class linked_list_add
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data)
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = head;
            }
            Console.WriteLine("{0} inserted into linkedlist()", Node.data);
        }
    }
}
