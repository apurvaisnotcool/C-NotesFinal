namespace _005Properties;

// 4. Asymmetric Accessors
public class User
{
    public string PasswordHash { get; private set; }

    public User(string password)
    {
        PasswordHash = HashPassword(password);
    }

    private string HashPassword(string password)
    {
        // Simple mock hash for demonstration
        return $"HASHED_{password}";
    }
}