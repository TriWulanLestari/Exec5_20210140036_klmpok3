using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            node previous, lt;
            previous = tw;
            lt = tw;

            while ((lt != null) && (rollNo == lt.rollNumber))
            {
                if (rollNo == lt.rollNumber)
                {
                    Console.WriteLine();
                    return;
                }
                previous.next = lt;
                previous.next = newnode;
            }
            newnode.next = lt;
            previous.next = newnode;
        }

        public bool delete(int rollNo)
        {
            node previous, current;
            previous = current = null;
            if (Display(rollNo, ref previous, ref current) == false)
                return false;
            previous.next = current.next;
            if (current == tw)
                tw = tw.next;
            return true;
        }

        public bool Display(int rollNo, ref node previous, ref node lt)
        {
            previous = tw;
            lt = tw;
            while ((lt != null) && (rollNo != lt.rollNumber))
            {
                previous = lt;
                lt = lt.next;
            }
            if (lt == null)
                return false;
            else
                return true;
        }

        public void Traverse()
        {
            if (listEmpty())
                Console.WriteLine("\nThe records in the list are: ");
            else
            {
                Console.WriteLine("\nThe records in the list are: ");
                node ltNode;
                for (ltNode = tw; ltNode != null; ltNode = ltNode.next)
                    Console.Write(ltNode.rollNumber + " " + ltNode.name + "\n");
                Console.WriteLine();
            }
        }

        public bool listEmpty()
        {
            if (tw == null)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
        }
    }
}
