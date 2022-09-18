using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelPlanner
{
    public class Node<T>
    {
        public Node(T data, string name)
        {
            this.data = data;
            next = null;
            this.name = name;
            
        }

        public string name;
        public T data;
        public Node<T> next;
    }

    public class List<T>
    {
        public List()
        {
            this.head = null;
            this.tail = null;
        }

        //Insert at start
        public void insertStart(T data, string name)
        {
            Node<T> newNode = new Node<T>(data, name);
            newNode.next = head;
            head = newNode;

            if (tail == null)
            {
                tail = head;
            }
        }

        //Insert at end
        public void insertEnd(T data, string name)
        {
            Node<T> newNode = new Node<T>(data, name);

            if (tail == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }

            tail.next = newNode;
            tail = newNode;
        }

        //delete key
        void delete(T key)
        {
            //if list is  empty
            if (head == null)
            {
                return;
            }


            //if head is only node and it doesn't equal key
            if (head == tail && !head.data.Equals(key))
            {
                return;
            }

            //if head is only node and equals key
            if (head == tail && head.data.Equals(key))
            {
                head = null;
                tail = null;
                return;
            }

            //Searching previous node
            Node<T> current = head;

            while (current.next != null && !current.next.data.Equals(key))
            {
                current = current.next;
            }

            //if not found
            if (current.next == null)
            {
                return;
            }

            //deleting if it is tail
            if (current.next == tail)
            {
                tail = current;
                current.next = null;
                return;
            }

            //deleting 
            current.next = current.next.next;
        }

        public Node<T> iterator()
        {
            return head;
        }

        public List<T> clone()
        {
            List<T> newList = new List<T>();

            Node<T> it = head;

            while (it != null)
            {
                newList.insertEnd(it.data, it.name);
                it = it.next;
            }

            return newList;
        }

        public T getT(string name)
        {
            T data = default(T);
            
            Node<T> it = head;

            while (it != null)
            {
                if (it.name.Equals(name))
                {
                    data = it.data;
                }

                it = it.next;
            }
            return data;
        }

        public Node<T> getNode(string name)
        {
            Node<T> it = head;
                
            while (it != null)
            {
                if (it.name.Equals(name))
                {
                    return it;
                }

                it = it.next;
            }
            return null;
        }
        
        public bool search(string name)
        {
            Node<T> it = head;

            while (it != null)
            {
                if (it.name.Equals(name))
                {
                    return true;
                }
                it = it.next;
            }

            return false;
        }

        //Dequeue
        public Node<T> dequeueLast()
        {
            Node<T> it = head;

            if (it == tail)
            {
                tail = null;
                head = null;
                return it;
            }

            while (it.next != tail)
            {
                it = it.next;
            }
            it.next = null;
            tail = it;
            return it;
        }

        //check if empty
        public bool isEmpty()
        {
            if (tail == null)
            {
                return true;
            }

            return false;
        }

        //make empty
        public void makeEmpty()
        {
            head = null;
            tail = null;
        }

        public T lastValue()
        {
            T last = default(T);

            if (tail != null)
            {
                last = tail.data;
            }

            return last;
        }

        //remove duplicates
        public void removeDuplicates()
        {
            Node<T> it = head;

            if (it == null)
            {
                return;
            }

            while (it.next != null)
            {
                Node<T> it2 = it.next;

                while (it2 != null)
                {
                    if (it.name.Equals(it2.name))
                    {
                        this.delete(it2.data);
                    }

                    it2 = it2.next;
                }

                it = it.next;
            }
        }

        Node<T> head;        
        Node<T> tail;        
    }
}
