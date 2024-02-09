# GA_QueueDoubly_Ronda

Explanation of a queue and its utility.


Differences between a queue and a doubly linked list.
- A queue is less flexible. It is a FIFO data structure, so it is built to be easy to add elements to the rear and view and remove elements from the front, but the values of elements in the middle or rear are not accessed.
- A doubly linked list is meant to be traversed in both directions, and elements can easily be added/removed/accesssed from the front, end, or even the middle.
Discuss scenarios where a queue is preferable over other data structures.
- A queue could be preferable over other data structures when it is important that elements are accessed in a FIFO order, such as customer service requests.
Considerations for choosing between a queue and other data structures.
- Someone might choose a queue as a data structure if they need to access the data in a FIFO order. It would not be a good choice for any other order.
- Queues do use less memory than arrays, since they are dynamic in size, but they use more memory than singly linked lists and stacks because they have two reference pointers.
Thoughts on implementing a queue using different approaches (array vs. linked list).
- All of the things you can do with a queue can be done with an array, but since the queue structure uses relatively less memory and is efficient for its intended use, it is a great data structure for FIFO lists.