namespace _004Enums;

public enum OrderStatus
{
    Pending,   // 0
    Processing, // 1
    Shipped,   // 2
    Delivered, // 3
    Canceled   // 4
}
class Program
{
    static void Main(string[] args)
    {
        OrderStatus currentStatus = OrderStatus.Processing;

        // Using enums in control flow
        if (currentStatus == OrderStatus.Processing)
        {
            Console.WriteLine("Your order is being processed.");
        }

        // Enums with switch statements
        switch (currentStatus)
        {
            case OrderStatus.Pending:
                Console.WriteLine("Order received.");
                break;
            case OrderStatus.Shipped:
                Console.WriteLine("Order is on the way.");
                break;
            case OrderStatus.Delivered:
                Console.WriteLine("Order delivered!");
                break;
            default:
                Console.WriteLine($"Status: {currentStatus}");
                break;
        } 
    }
}