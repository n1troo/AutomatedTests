using System;

namespace BmiProject.Service;

public class Logger
{
    public void LogInformation(string message)
    {
        Console.WriteLine($"Logging information: {message}");
    }

    public void LogError(string message)
    {
        Console.WriteLine($"Logging error: {message}");
    }
}