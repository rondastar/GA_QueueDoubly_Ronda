using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_QueueDoubly_Ronda
{
    internal class Queue<T>
    {
        private QueueNode<T> front;
        private QueueNode<T> rear;
        private int count;

        // Constructor to initialize an empty queue
        public Queue()
        {
            front = null;
            rear = null;
            count = 0;
        }


        // Public property to access the count of elements.
        public int Count
        {
            get { return count; }
        }

        // Nested class QueueNode representing elements in the queue
        internal class QueueNode<T>
        {
            public T Value { get; set; }    // Data stored in the node
            public QueueNode<T> Next { get; set; }
            public QueueNode<T> Previous { get; set; }

            // constructor for queue nodes
            public QueueNode(T value)
            {
                Value = value;
                Next = null;
                Previous = null;
            }

        } // class QueueNode

        // Adds element to rear of queue
        internal void Enqueue(T value)
        {
            // Create a new node with the given value
            QueueNode<T> newNode = new QueueNode<T>(value);

            // If the queue is empty, set the new node to be both the front and the rear.
            // Otherwise add the new node to the rear and update references
            if (front == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                newNode.Previous = rear;
                rear.Next = newNode;
                rear = newNode;
            }

            // increment the count
            count++;
        }

        // Remove the element at the front and return its value
        internal T Dequeue()
        {
            // If front is already null, return default
            if (front == null) return default;

            // assign value to be removed from front to temporary variable
            T temp = front.Value;

            // if the second node is empty, reset front and rear to null
            if (front.Next == null)
            {
                front = null;
                rear = null;
            }
            // if the second node is not null, update references so it becomes the front
            else if(front.Next != null)
            {
                front = front.Next;
                front.Previous = null;
            }

            // decrement the count
            count--;

            // return the value that was removed
            return temp;
        }



    } // class Queue
}
