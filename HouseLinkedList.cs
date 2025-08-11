using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6._1._1
{
    internal class HouseLinkedList
    {
        private House? head;
        private House? tail;
        private int size;
        public int Size { get { return size; } }
        public HouseLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public bool IsEmpty() => size == 0;
        public void AddFirst(House house)
        {
            if (IsEmpty())
                tail = house;
            else
                house.next = head;
            head = house;
            size++;
        }
        public House? RemoveFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Cannot remove from empty list!");
            House house = head;
            if (size == 1)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
            }
            size--;
            return house;
        }
        public House? Search(int houseNumber)
        {
            if (IsEmpty())
                return null;
            House cur = head;
            while (cur != null)
            {
                if (cur.number == houseNumber)
                    return cur;
                cur = cur.next;
            }
            return null;
        }
        public void Display()
        {
            if (!IsEmpty())
            {
                House cur = head;
                while (cur != null)
                {
                    Console.Write(cur);
                    if (cur.next != null)
                        Console.Write(" --> ");
                    cur = cur.next;
                }
                Console.WriteLine();
                Console.WriteLine($"Head is {head}");
                Console.WriteLine($"Tail is {tail}");
            }
            else
            {
                Console.WriteLine("There are no houses!");
            }
        }
    }
}
