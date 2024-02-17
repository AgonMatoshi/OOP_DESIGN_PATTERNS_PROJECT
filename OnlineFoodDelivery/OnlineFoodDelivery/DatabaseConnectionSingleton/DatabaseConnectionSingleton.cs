namespace OnlineFoodDelivery.DatabaseConnection;

// Singleton pattern
public class DatabaseConnection
{
    private static DatabaseConnection instance;
    private static readonly object padlock = new object();

    
    private DatabaseConnection()
    {
        
    }

    // Public property to access the instance with thread safety
    public static DatabaseConnection Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
    }

    public void Connect()
    {
        // Simulate database connection
        Console.WriteLine("Database connection established.");
    }
}