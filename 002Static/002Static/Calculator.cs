namespace _002Static;

public static class Calculator
{
    // Static property
    public static double Pi { get; } = 3.14159;

    // Static method
    public static int Add(int a, int b) => a + b;

    public static double CalculateCircleArea(double radius) 
        => Pi * radius * radius; 
}