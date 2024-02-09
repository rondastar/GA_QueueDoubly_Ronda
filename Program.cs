namespace GA_QueueDoubly_Ronda
{
    // Ronda Rutherford
    // GA Queue Doubly
    // 2-6-24
    internal class Program
    {
        static void Main(string[] args)
        {
            StringTest();
        }

        public static void StringTest()
        {
            // test string queue
            Queue<string> stringQueue = new Queue<string>();

            // test enqueue
            stringQueue.Enqueue("Apple");
            stringQueue.Enqueue("Banana");
            stringQueue.Enqueue("Cherry");
            stringQueue.Enqueue("Dragonfruit");

            // test count
            Console.WriteLine(stringQueue.Count); // 4

            // test dequeue
            Console.WriteLine(stringQueue.Dequeue()); // Apple

            // test peek
            Console.WriteLine(stringQueue.Peek()); // Banana

            // test clear
            stringQueue.Clear();

            // test dequeue
            Console.WriteLine(stringQueue.Dequeue()); // empty

            // test peek
            Console.WriteLine(stringQueue.Peek()); // empty

            // test count
            Console.WriteLine(stringQueue.Count); // 0
        }
    }
}
