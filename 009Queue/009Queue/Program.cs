namespace _009Queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("kira");
        queue.Enqueue("apurva");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("............");
        Console.WriteLine(queue.Dequeue());//removes the first element in the queue
        Console.WriteLine("............");
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}