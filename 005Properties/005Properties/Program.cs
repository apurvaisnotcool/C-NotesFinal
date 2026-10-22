namespace _005Properties;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("=== C# Properties Demonstration ===\n");

            // 1. Auto-Implemented Properties
            Console.WriteLine("--- 1. Auto-Implemented Properties ---");
            var person = new Person { Name = "Alice" };
            Console.WriteLine($"Person Name: {person.Name}");
            Console.WriteLine($"Person Id (Default): {person.Id}\n");

            // 2. Full Properties (With Backing Field & Validation)
            Console.WriteLine("--- 2. Full Properties ---");
            var account = new BankAccount();
            account.Balance = 250.75f;
            Console.WriteLine($"Account Balance: {account.Balance:C}");

            try
            {
                Console.WriteLine("Attempting to set a negative balance...");
                account.Balance = -50.00f;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Caught Expected Exception: {ex.Message}");
            }
            Console.WriteLine();

            // 3. Expression-Bodied Properties
            Console.WriteLine("--- 3. Expression-Bodied Properties ---");
            var circle = new Circle { Radius = 5.0 };
            Console.WriteLine($"Circle Radius: {circle.Radius}");
            Console.WriteLine($"Circle Area (Computed): {circle.Area:F2}\n");

            // 4. Asymmetric Accessors
            Console.WriteLine("--- 4. Accessors & Modifiers ---");
            var user = new User("Secret123!");
            Console.WriteLine($"User PasswordHash: {user.PasswordHash}");
            // user.PasswordHash = "new"; // Compile Error: setter is private
            Console.WriteLine();

            // 5. Init-Only Setters
            Console.WriteLine("--- 5. Init-Only Setters ---");
            var car = new Car { VIN = "1HGCR2F83HA000000" };
            Console.WriteLine($"Car VIN: {car.VIN}");
            // car.VIN = "NEW_VIN_123"; // Compile Error: Property 'VIN' is init-only
            Console.WriteLine();

            // 6. Required Properties
            Console.WriteLine("--- 6. Required Properties ---");
            var student = new Student 
            { 
                StudentId = "S98765", 
                Name = "Bob" 
            };
            Console.WriteLine($"Student ID: {student.StudentId}");
            Console.WriteLine($"Student Name: {student.Name}\n");

            Console.WriteLine("=== End of Demonstration ==="); 
    }
}