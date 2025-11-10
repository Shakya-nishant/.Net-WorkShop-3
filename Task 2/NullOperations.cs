using System;

namespace Task_2;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string? username = null;
        string message = (username == null) ? "Username is not available" : username;
        Console.WriteLine(message);
        Console.WriteLine(username ?? "Username is not available");
        username ??= "Nishant";
        Console.WriteLine("Updated Username: " + username);
    }

}
