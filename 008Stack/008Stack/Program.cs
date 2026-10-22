namespace _008Stack;

class Program
{
    static void Main(string[] args)
    {
        Stack<string> stack = new Stack<string>();
        
        stack.Push("kira");
        stack.Push("aadrija");
        stack.Push("apurva");
        
        //Cycle Through the stack
        
        // Iterates top-to-bottom: "apurva", "aadrija", "kira"
        foreach (string name in stack)
        {
            Console.WriteLine(name);
        }
        
        stack.Pop();//Pop(): Removes and returns the top item. Throws InvalidOperationException if empty.
        Console.WriteLine("..........");
        // Iterates top-to-bottom:  "aadrija", "kira"
        foreach (string name in stack)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine("..........");
        Console.WriteLine(stack.Peek());//Peek(): Returns the top item without removing it.
                                        //Throws InvalidOperationException if empty.
    }
}