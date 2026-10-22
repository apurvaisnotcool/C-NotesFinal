namespace _011FunctionParams;

class Program
{
    static void Main(string[] args)
    {
        SayName("kira", "apurva");
    }

    private static void SayName(params string[] names)
    {
        Console.WriteLine(names.Length);
        Console.WriteLine(names[0]);//prints kira
        Console.WriteLine(names[1]);//prints apurva
    }
}