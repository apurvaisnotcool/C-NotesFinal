namespace _002Static;
public static class AppSettings
{
    public static string AppName;
    public static string Version;

    // Static Constructor
    static AppSettings()
    {
        // Used to run initialization logic or load global defaults
        AppName = "My Awesome App";
        Version = "1.0.0";
        Console.WriteLine("AppSettings initialized!");
    }
}