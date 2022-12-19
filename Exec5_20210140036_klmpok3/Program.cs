using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exec5_20210140036_klmpok3
{
    internal class node
    {
        public int rollNumber;
        public string name;
        public node next;
    }

    class List
    {
        node tw;
        public List()
        {
            tw = null;
        }

        public void insert() 
        {
            int rollNo;
            string nm;
            Console.Write("\nEnter the roll number of the student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the roll name of the student: ");
            nm = Console.ReadLine();
            node newnode = new node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            //if the node to be inserted is the first node
            if ((tw == null) || (rollNo == tw.rollNumber))
            {
                if ((tw != null) && (rollNo == tw.rollNumber))
                {
                    Console.WriteLine();
                    return;
                }
                newnode.next = tw;
                tw = newnode;
                return;
            }
            node previous, current;
            previous = tw;
            current = tw;

            while ((current != null) && (rollNo == current.rollNumber))
            {
                if (rollNo == current.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = current;
                previous.next = newnode;
            }
            newnode.next = current;
            previous.next = newnode;
        }
        static void Main(string[] args)
        {
        }
    }
}
