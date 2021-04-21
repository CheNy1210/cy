using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist1

{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            tail = head = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add (T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> act)
        {
            Node<T> p = this.Head;
            while (p != null)
            {
                act(p.Data);
                p = p.Next;
            }
        }
    }

   
    public class Program
    {
        public static int Min(int a,int b)
        {
            if (a < b)
                return a;
            else
                return b;
        }
        public static int Max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(random.Next(100));  
            }            
            intlist.ForEach(x => Console.Write(x+ " "));
            int min = 100;
            int max = 0;
            int sum = 0;
            intlist.ForEach(x =>
            {
                min = Min(x, min);
                max = Max(x, max);
                sum += x;

            });
            Console.WriteLine();
            Console.WriteLine($"min={min},max={max},sum={sum}");

        }
    }   
}
