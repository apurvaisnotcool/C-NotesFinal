namespace _001Class;

class Program
{
    static void Main(string[] args)
    {
        Player kiraPlayer = new Player("Kira");//First Instance of the Player Class
        Player punpunPlayer = new Player("PunPun");//Second Instance of the Player Class
        Console.WriteLine(kiraPlayer.GetHashCode()+ " " + punpunPlayer.GetHashCode());
        //GetHashCode() is a function that generates a hash code for the specific value or object instance
        Console.WriteLine(kiraPlayer);
        Console.WriteLine(punpunPlayer);
        
        kiraPlayer.SayHello();
        punpunPlayer.SayHello();
    }

    public class Player
    {
        string name="-"; //Local Field
        public Player(string name)
        {
            this.name = name; //Assigning Class Field 'name' to the local Player Constructor parameter 'name'
            Console.WriteLine($"{name} object created");
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello! {name}");
        }
    }
}