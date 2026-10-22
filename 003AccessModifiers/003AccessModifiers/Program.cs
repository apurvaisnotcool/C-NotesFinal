namespace _003AccessModifiers;

public class Parent
{
    public int PublicField = 1;              // Accessible anywhere
    private int PrivateField = 2;            // Accessible ONLY inside Parent
    protected int ProtectedField = 3;        // Accessible inside Parent & Child classes
    internal int InternalField = 4;          // Accessible anywhere inside AccessModifierDemo assembly
    protected internal int ProtIntField = 5; // Accessible inside assembly OR external derived classes
    private protected int PrivProtField = 6; // Accessible inside assembly AND derived classes only

    public void PrintPrivate()
    {
        // Private is accessible inside the defining class
        Console.WriteLine($"PrivateField: {PrivateField}");
    }
}

public class Child : Parent
{
    public void TestAccessFromChild()
    {
        Console.WriteLine("--- Accessing from Child class ---");
        Console.WriteLine($"PublicField: {PublicField}");      // OK
        // Console.WriteLine(PrivateField);                     // ERROR: Inaccessible due to protection level
        Console.WriteLine($"ProtectedField: {ProtectedField}"); // OK (inherited)
        Console.WriteLine($"InternalField: {InternalField}");   // OK (same assembly)
        Console.WriteLine($"ProtIntField: {ProtIntField}");     // OK
        Console.WriteLine($"PrivProtField: {PrivProtField}");   // OK (same assembly + derived)
    }
}

class Program
{
    static void Main(string[] args)
    {
        Child child = new Child();

        // 1. Run methods inside Child and Parent to show internal member access
        child.TestAccessFromChild();

        Console.WriteLine("\n--- Accessing from Parent (internal method) ---");
        child.PrintPrivate();

        // 2. Access members directly from Main (an external non-derived class)
        Console.WriteLine("\n--- Direct access from Main (Non-Derived Class) ---");
        Console.WriteLine($"PublicField: {child.PublicField}");      // OK
        Console.WriteLine($"InternalField: {child.InternalField}");  // OK (same assembly)
        Console.WriteLine($"ProtIntField: {child.ProtIntField}");    // OK (same assembly)
            
        // The lines below will cause compile errors if uncommented:
        // Console.WriteLine(child.PrivateField);   // ERROR: Inaccessible
        // Console.WriteLine(child.ProtectedField); // ERROR: Inaccessible outside child/parent
        // Console.WriteLine(child.PrivProtField);  // ERROR: Inaccessible outside child hierarchy 
    }
}


