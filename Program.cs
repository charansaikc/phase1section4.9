using System;

namespace Phase1Section4._7c
{
    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = Convert.ToString(i);
                list.add(node);
            }

            Console.WriteLine("length of singly linked list=" + list.getLengthOfList());
            Console.WriteLine("Traversing forward..");
            n = list.getRoot();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getNext();
            }

            Console.WriteLine("Traversing backwards..");
            n = list.getPrev();
            while (n != null)
            {
                Console.WriteLine(n.Data);
                n = list.getPrev();
            }

        }
    }
    public class DoubleLinkedList
    {
        private Node root;
        private Node lastNode;

        public void add(Node node)
        {
            if (root == null)
            {
                root = node;
            }
            else
            {
                lastNode.Next = node;
                node.Previous = lastNode;
            }

            lastNode = node;
        }

        public int getLengthOfList()
        {
            int count = 0;
            Node n = root;
            while (n != null)
            {
                count++;
                n = n.Next;
            }

            return count;
        }

        public Node getRoot()
        {
            return root;
        }

        public Node getNext()
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                return root.Next;
            }
        }

        public Node getPrev()
        {
            if (root == null)
            {
                return null;
            }
            else
            {
                return root.Previous;
            }
        }
    }
    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }
}
