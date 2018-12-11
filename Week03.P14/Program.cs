using System;

namespace Week03.P14
{
    internal class Program
    {
        /// <summary>
        ///     How to find the 3rd element from end, in a singly linked, in a single pass?
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var list = new SingleLinkedList();

            var node1 = list.AddFirst(1);
            var node2 = list.AddAfter(node1, 2);
            var node3 = list.AddAfter(node2, 3);
            var node4 = list.AddAfter(node3, 4);
            var node5 = list.AddAfter(node4, 5);

            list.Print();

            var last3RdNode = list.Find3RdElementFromEnd();

            Console.WriteLine(last3RdNode.Value);
        }
    }
}