using System;
using System.Linq;
using Iterator.Models;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            //      1
            //    /   \
            //   2     3
            //  / \   / \ 
            // 4   5 6   7
            // in-order: 4251637

            var root = new Node<int>(1, new Node<int>(2, new Node<int>(4), new Node<int>(5)), new Node<int>(3, new Node<int>(6), new Node<int>(7)));
            var iterator = new InOrderItemartor<int>(root);

            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current?.Value);
                Console.Write(",");
            }
            Console.WriteLine();

            var tree = new BinaryTree<int>(root);

            Console.WriteLine(string.Join(",", tree.InOrder.Select(t => t.Value)));
        }
    }
}
