namespace _012OptionalParameter;

class Program
{
    static void Main(string[] args)
    {
        // Calling the method:
        LogMessage("System started");                       // Uses default category and logToConsole
        LogMessage("Database error", "Database");            // Overrides category, uses default logToConsole
        LogMessage("Disk full", "Storage", false); // Overrides all default parameters
        LogMessage("System restarted", logToConsole: false); //overriding just the bool logToConsole
    }
    static void LogMessage(string message, string category = "General", bool logToConsole = true)
    {
        Console.WriteLine($"[{category}] {message} (Console: {logToConsole})");
    }

    
}