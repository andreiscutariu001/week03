using System;

namespace Week03.P14
{
    internal class SingleLinkedList
    {
        private Node _first;

        public Node AddFirst(int value)
        {
            var node = new Node {Value = value, Next = null};

            _first = node;

            return node;
        }

        public Node AddAfter(Node node, int val)
        {
            var newNode = new Node {Value = val};

            node.Next = newNode;

            return newNode;
        }

        public void Print()
        {
            var currentNode = _first;

            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");

                currentNode = currentNode.Next;
            }
        }

        public Node Find3RdElementFromEnd()
        {
            var currentNode = _first;

            while (currentNode != null)
            {
                if (currentNode.Next.Next.Next == null) // Check 3rd node to be null
                {
                    return currentNode;
                }

                currentNode = currentNode.Next;
            }

            return _first;
        }
    }
}