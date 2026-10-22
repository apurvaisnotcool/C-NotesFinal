namespace _010HashSet;

class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();//Defining a Hashset
        //Adding to the hashset
        set.Add("kira");
        set.Add("apurva");
        Console.WriteLine(set.Count);//Counting Hashset
        set.Add("apurva");
        Console.WriteLine(set.Count);//This returns 2 because even tho we added "apurva" twice hashset stored it only
        //once. Hashset stores only unique elements
        set.Remove("apurva");//removing element
        
        bool exists = set.Contains("kira");
        Console.WriteLine(exists);//Contains(): Checks if an element exists in the set.
        Console.WriteLine("..........");
        
        // Iteration (Order is not guaranteed)
        set.Add("Aadrija");
        foreach (string name in set)
        {
            Console.WriteLine(name);
        }
    }
}