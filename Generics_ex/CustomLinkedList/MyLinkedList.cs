using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomLinkedList
{
    class MyLinkedList<T> : IEnumerable<T>
    {
        /// <summary>
        /// First Node in the Linked List
        /// </summary>
        public Node<T> First { get; set; }
        /// <summary>
        /// Last Node in the Linked List
        /// </summary>
        public Node<T> Last { get; set; }
        /// <summary>
        /// Shows the numbers elements in the Linked List
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Default constructor of Linked List
        /// </summary>
        public MyLinkedList()
        {
            this.Count = 0;
        }
        /// <summary>
        /// Overloaded Constructor of Linked List
        /// </summary>
        /// <param name="collection"></param>
        public MyLinkedList(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                AddLast(new Node<T>(item));
            }
        }


        /// <summary>
        /// Adds Node at the beginning of the Linked List 
        /// </summary>
        /// <param name="newNode"></param>
        public void AddFirst(Node<T> newNode)
        {
            if (newNode == null)
            {
                throw new ArgumentException();
            }
            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            Count++;

        }
        /// <summary>
        /// Adds Node at the beginning of the Linked List 
        /// </summary>
        /// <param name="item"></param>
        public void AddFirst(T item)
        {
            var newNode = new Node<T>(item);
            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                newNode.Next = First;
                First = newNode;
            }
            Count++;

        }
        /// <summary>
        /// Adds Node at the end of the Linked List 
        /// </summary>
        /// <param name="newNode"></param>
        public void AddLast(Node<T> newNode)
        {
            if (newNode == null)
            {
                throw new ArgumentException();
            }
            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;

        }
        /// <summary>
        /// Adds Node at the end of the Linked List 
        /// </summary>
        /// <param name="item"></param>
        public void AddLast(T item)
        {
            var newNode = new Node<T>(item);
            if (Count == 0)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                Last = newNode;
            }
            Count++;

        }


        /// <summary>
        /// Adds node before a specified Node
        /// </summary>
        /// <param name="specifiedNode"></param>
        /// <param name="newNode"></param>
        public void AddBefore(Node<T> specifiedNode, Node<T> newNode)
        {
            if (specifiedNode == null)
            {
                throw new ArgumentException();
            }
            var currentNode = First;

            while (currentNode.Next != null)
            {
                if (currentNode.Next == specifiedNode)
                {
                    newNode.Next = specifiedNode;
                    currentNode.Next = newNode;
                    Count++;
                    break;
                }
                currentNode = currentNode.Next;
            }
        }
        /// <summary>
        /// Adds node before a specified Node
        /// </summary>
        /// <param name="specifiedNode"></param>
        /// <param name="item"></param>
        public void AddBefore(Node<T> specifiedNode, T item)
        {
            if (specifiedNode == null)
            {
                throw new ArgumentException();
            }
            var currentNode = First;
            var newNode = new Node<T>(item);

            while (currentNode.Next != null)
            {
                if (currentNode.Next == specifiedNode)
                {
                    newNode.Next = specifiedNode;
                    currentNode.Next = newNode;
                    Count++;
                    break;
                }
                currentNode = currentNode.Next;
            }
        }
        /// <summary>
        /// Adds node after a specified Node
        /// </summary>
        /// <param name="specifiedNode"></param>
        /// <param name="newNode"></param>
        public void AddAfter(Node<T> specifiedNode, Node<T> newNode)
        {
            if (specifiedNode == null)
            {
                throw new ArgumentException();
            }
            var currentNode = First;

            newNode.Next = specifiedNode.Next;
            specifiedNode.Next = newNode;
            Count++;
        }
        /// <summary>
        /// Adds node after a specified Node
        /// </summary>
        /// <param name="specifiedNode"></param>
        /// <param name="item"></param>
        public void AddAfter(Node<T> specifiedNode, T item)
        {
            if (specifiedNode == null)
            {
                throw new ArgumentException();
            }
            var currentNode = First;
            var newNode = new Node<T>(item);

            newNode.Next = specifiedNode.Next;
            specifiedNode.Next = newNode;
        }



        /// <summary>
        /// Removes the First node in the Linked List
        /// </summary>
        public void RemoveFirst()
        {
            First = First.Next;
        }
        /// <summary>
        /// Removes the Last node in the Linked List
        /// </summary>
        public void RemoveLast()
        {
            var current = First;

            while (current.Next != Last)
            {
                if (current.Next.Equals(Last))
                {
                    current.Next = null;
                    Last = current;
                    break;
                }
                current = current.Next;
            }
        }
        /// <summary>
        /// Removes the specified node
        /// </summary>
        /// <param name="node"></param>
        public void Remove(Node<T> node)
        {
            if (node == null)
            {
                throw new ArgumentException();
            }
            var current = First;

            while (current.Next != null)
            {
                if (current.Next.Equals(node))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    break;
                }
                current = current.Next;
            }
        }
        /// <summary>
        /// Removes the node with the specified item
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            var current = First;

            while (current.Next != null)
            {
                if (current.Next.Value.Equals(item))
                {
                    current.Next = current.Next.Next;
                    Count--;
                    break;
                }
                current = current.Next;
            }
        }


        /// <summary>
        /// Searches for a node with the given value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Node<T> Find(T item)
        {
            var current = First;
            Node<T> found = new Node<T>();
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    found = current;
                    break;
                }
                current = current.Next;
            }
            return found;
        }
        /// <summary>
        /// Checks if the Linked List contains the given item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(T item)
        {
            bool contains = false;

            var current = First;
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    contains = true;
                    break;
                }
                current = current.Next;
            }
            return contains;
        }

        /// <summary>
        /// Removes all elements in the Linked List
        /// </summary>
        public void Clear()
        {
            First = null;
            Last = null;
            Count = 0;
        }


        /// <summary>
        /// Gets Enumerator for Linked List
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = First;

            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        /// <summary>
        /// Gets Enumerator for Linked List
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
