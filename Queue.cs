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

        } // class QueueNode

        // Public property to access the count of elements.


    } // class Queue
}
