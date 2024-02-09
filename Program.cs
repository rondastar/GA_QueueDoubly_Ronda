namespace GA_QueueDoubly_Ronda
{
    // Ronda Rutherford
    // GA Queue Doubly
    // 2-6-24
    internal class Program
    {
        static void Main(string[] args)
        {
            // test string queue
            Queue<string> stringQueue = new Queue<string>();

            // test enqueue
            stringQueue.Enqueue("Apple");
            stringQueue.Enqueue("Banana");
            stringQueue.Enqueue("Cherry");
            stringQueue.Enqueue("Dragonfruit");

            // test dequeue
            Console.Write(stringQueue.Dequeue());

        }
    }
}
