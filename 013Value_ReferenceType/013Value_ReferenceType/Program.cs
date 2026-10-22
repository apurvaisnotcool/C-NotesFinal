namespace _013Value_ReferenceType;

class Program
{
    static void Main(string[] args)
    {
        //value type
        int x = 10;
        int y = x;
        Console.WriteLine($"y = {y}");
        y = 20;
        Console.WriteLine("Changing the value of y");
        Console.WriteLine($"y = {y}");
        Console.WriteLine("y changes the value but x remains the same value");
        Console.WriteLine($"x = {x}");

        Console.WriteLine("..............");
        Console.WriteLine("Class");
        //reference type
        Person p1 = new Person();
        p1.Name = "kira";
        Console.WriteLine($"We created a Person Object p1 with name {p1.Name}");
        Console.WriteLine("We create Person Object p2 that is a direct reference to p1");
        Person p2 = p1;
        p2.Name = p1.Name;
        Console.WriteLine($"We created a Person Object p2 with p1.name copied {p2.Name}");
        Console.WriteLine("We Now change the value of p2.name to john");
        p2.Name = "John";
        Console.WriteLine(p1.Name);
        Console.WriteLine("Since p2 is directly referenced from p1 and class is a reference type.\n" +
                          "Changing value of p2.Name to john changes the value of p1.Name\n" +
                          "Since class is a reference type.\n" +
                          "And they point to the exact same place of the memory\n");
        Console.WriteLine("..................");
        Console.WriteLine("Struct");
        //value type struct
        PlayerAge p1Age = new PlayerAge();
        p1Age.Age = 20;
        PlayerAge p2Age = p1Age;
        p2Age.Age = 27;
        Console.WriteLine(p1Age.Age);
        Console.WriteLine("Since struct is a value type when we created p2Age and assigned p1Age to it\n" +
                          "We created a completely Separate copy of it.\n" +
                          "Unlike Classes changing Value of p2Age doesn't affect the value of p1Age");

        Console.WriteLine("..................");
        Person p3 = new Person();
        p3.Name = "Madhu";
        PlayerAge p4Age = new PlayerAge();
        p4Age.Age = 27;
        MyFunction(p3,p4Age);
        Console.WriteLine($"Class Name: {p3.Name}, struct age: {p4Age.Age}");
        
        /*  Why p3.Name Changed (Class = Reference Type)
            When passing p3 into MyFunction, C# makes a copy of the reference pointer, not the object itself.
            Inside MyFunction, the parameter variable points to the exact same Person instance on the heap as p3.
            Changing Name inside the function modifies the shared object in heap memory.
            When MyFunction finishes, p3.Name reflects that modification.*/
        
        /*  Why p4Age.Age Didn't Change (Struct = Value Type)
            When passing p4Age into MyFunction, C# makes a complete, independent copy of the struct data itself.
            Inside MyFunction, a completely separate instance of PlayerAge is created in 
            local function stack memory containing Age = 27. 
            Modifying Age inside MyFunction updates only that temporary, isolated copy.
            The original p4Age variable outside the function remains untouched at 27.
            */
        
    }

    public static void MyFunction(Person p1, PlayerAge p2)
    {
        p1.Name = "Apurva";
        p2.Age = 40;

    }
    
    
    
    //reference type
    public class Person
    {
        public string Name { get; set; }
    }

    //value type
    public struct PlayerAge
    {
        public int Age { get; set; }
    }
}