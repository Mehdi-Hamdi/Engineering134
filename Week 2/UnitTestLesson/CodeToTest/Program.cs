using System.Security.Cryptography.X509Certificates;

namespace CodeToTest;

public class Program
{
    static void Main(string[] args)
    {
        int timeOfDay = 33;
        Console.WriteLine(GetGreeting(timeOfDay));
    }

    public static string GetGreeting(int timeOfDay)
    { 
        
       
        string message;
        if (timeOfDay < 0 || timeOfDay > 23) 
        {
            throw new ArgumentOutOfRangeException("time cannot be out of the range 0-23");
        }
        

        if (timeOfDay >= 5 && timeOfDay < 12)
        {
            message = "Good Morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            message = "Good Afternoon!";
        }
        else
        {
            message = "Good Evening!";
        }
        return message;
    }
}



