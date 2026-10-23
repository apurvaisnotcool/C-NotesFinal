namespace _014Structs;

class Program
{
    static void Main(string[] args)
    {
        // Instantiating a struct
        Point p1 = new Point(10, 20);

        // Copy behavior (Value Type)
        Point p2 = p1; // Creates an independent copy of p1
        p2.X = 99;     // Modifies p2 ONLY

        p1.Display(); // Outputs: Point (10, 20)
        p2.Display(); 
    }
}

// Defining a struct
public struct Point
{
    public int X { get; set; }
    public int Y { get; set; }

    // Constructor
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Display()
    {
        Console.WriteLine($"Point ({X}, {Y})");
    }
}