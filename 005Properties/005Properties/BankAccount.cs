namespace _005Properties;

// 2. Full Properties (With Backing Fields)
public class BankAccount
{
    private float _balance;

    public float Balance
    {
        get => _balance;
        set
        {
            if (value < 0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Balance cannot be negative.");
            }
            _balance = value;
        }
    }
}