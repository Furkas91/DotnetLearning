using System;

namespace List
{
    internal class Node<T>
    {
        public Node<T> Next { set; get; }
        
        public T Data { set; get; }
        public Node(T data)
        {
            Data = data;
        }
    }

    public class LinkedList<T>
    {
        Node<T> Head;
        Node<T> Tail;
        int count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Tail = node;
            count++;
        }

        public void Add(int pos, T data)
        {
            Node<T> node = new Node<T>(data);
            Node<T> current;
            if (Head == null && pos == 0)
            {
                Head = node;
                Tail = node;
                return;
            }
            else
            {
                current = Head;
            }
            if (pos == 0)
            {
                node.Next = Head;
                Head = node;
                return;
            }
            if (pos <= count)
            {
                for(int i=0; i < pos-1; i++)
                {
                    current = current.Next;
                }
            } 
            else
            {
                Console.WriteLine("Error");
                return;
            }

            node.Next = current.Next.Next;
            current.Next = node;

        }

        public void Remove(int pos)
        {
            Node<T> current = Head;
            if (pos > count)
            {
                Console.WriteLine("Error");
                return;
            }
            for( int i = 0; i < pos - 1; i++)
            {
                current = current.Next;
            }

            current.Next = current.Next.Next;
        }
        
        public object Get(int pos)
        {
            Node<T> current = Head;
            if (pos > count)
            {
                Console.WriteLine("Error");
                return null;
            }
            for( int i = 0; i < pos; i++)
            {
                current = current.Next;
            }

            return current.Data;
        }

        public void Reverse()
        {
            Node<T> current = Head;
            Node<T> next = Head.Next;
            Tail = Head;
            for(int i = 0; i < count-1; i++)
            {
                Head = next;
                next = Head.Next;
                Head.Next = current;
                current = Head;
            }
            Tail.Next = next;
        }

        /*public void Print()
        {
            Node<T> current = Head;
            for(int i = 0; i < count; i++)
            {
                Console.Write(current.Data, " ");
            }
        }*/

    }
}