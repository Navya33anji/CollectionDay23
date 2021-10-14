using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("\n doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Navya");
            dictionary.Add(103, "Anji");
            dictionary.Add(104, "Sai");
            dictionary.Add(105, "Chintu");
            Console.WriteLine("Access value using Key(key=100):" + dictionary[100]);

            Console.WriteLine("\n iterating the Dictionary:");
            foreach (var element in dictionary)
            {
                Console.WriteLine("key=" + element.Key + "& value=" + element.Value);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\n doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Navya");
            set.Add("Anji");
            set.Add("Sai");
            set.Add("Chintu");
            set.Add("Puppy");
            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        private static void doListDemo()
        {
            Console.WriteLine("n In doListDemo");
            List<string> list = new List<string>();

            list.Add("Navya");
            list.Add("Anji");
            list.Add("Sai");
            list.Add("Chintu");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\n In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Navya");
            stack.Push("Anji");
            stack.Push("Sai");
            stack.Push("Chintu");

            string pop = stack.Pop();
            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("popped element:" + pop);
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\n In doQueueDemo");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Navya");
            queue.Enqueue("Anji");
            queue.Enqueue("Sai");
            queue.Enqueue("Chintu");
            queue.Enqueue("Puppy");
            Console.WriteLine("Head:" + queue.Peek());
            Console.WriteLine("\n Iterating the queue elements:");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("\n Dequeue element:" + dequeue);
            Console.WriteLine("\n Iterating the queue elements after dequeue one element:");
            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }
    }
}
