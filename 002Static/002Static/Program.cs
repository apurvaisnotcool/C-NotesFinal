namespace _002Static;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("..........Static Field & Class Example..........");
        Player kiraPlayer = new Player("Kira");
        //First Instance of the Player Class
        Player punpunPlayer = new Player("PunPun");
        //Second Instance of the Player Class
        
        Console.WriteLine(kiraPlayer.GetHashCode()+ " " + punpunPlayer.GetHashCode());
        //GetHashCode() is a function that generates a hash code for the specific value or object instance
        
        Console.WriteLine(kiraPlayer);
        Console.WriteLine(punpunPlayer);
        
        kiraPlayer.SayHello();
        punpunPlayer.SayHello();
        
        Console.WriteLine($"Total Player Created were {Player.TotalPlayerCount}");
        //To access the Static Field we Call Directly from
        //Player Class Instead of an Instance of the class "kiraPlayer.TotalPlayerCount" will show an error
        
        Player.TotalPlayerCount += 1;
        Console.WriteLine($"We added one More number to the static Field {Player.TotalPlayerCount}");
        
        //This is an Example of the Static field being so that if we change the value of Static field anywhere it
        //It is affected all across
        Player.TotalPlayerCount -= 1;
        //It Goes back to 2
        Console.WriteLine($"Total Player Count: {Player.TotalPlayerCount}");


        Console.WriteLine("........Example of Static Method MathHelper..........");
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());
        int sum = MathHelper.Add(a, b);
        Console.WriteLine($"Sum we got by Directly accessing the static function is {sum}");
        
        //Another example of a Static Method is Math.Abs which gives the absolute value of the Number
        Console.WriteLine(Math.Abs(-42));

        Console.WriteLine("..............Example of Static Class............");
        //We access the Add Method in Calculator Directly from the class itself
        int result = Calculator.Add(10, 20);
        //we access the CalculateCircleArea directly from the class itself
        double area = Calculator.CalculateCircleArea(5);

        Console.WriteLine($"Result: {result}"); // Output: 30
        Console.WriteLine($"Area: {area}");

        Console.WriteLine("............Example to use Static Constructor..........");
        Console.WriteLine($"App: {AppSettings.AppName}"); //How you access the static constructor
        Console.WriteLine($"Version: {AppSettings.Version}");
        
        // Accessing it a second time does NOT run the constructor again
        Console.WriteLine($"App again: {AppSettings.AppName}");
        
    }

    

    public class Player
    {
        string name = "-"; //Local Field
        public static int TotalPlayerCount = 0;// Static Field
        public Player(string name)
        {
            this.name = name; //Assigning Class Field 'name' to the local Player Constructor parameter 'name'
            
            Console.WriteLine($"{name} object created");
            TotalPlayerCount++;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello! {name}");
        }
    }

}