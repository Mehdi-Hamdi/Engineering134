namespace TestDrivenDevelopmentApp;

public class Program
{
    public static string FizzBuzz(int maxValue)
    {
        string outputString = "";
        for (int i = 1; i <=maxValue; i++)
        {
            if (i % 5 == 0 && i % 3 == 0)
            {
                outputString += "FizzBuzz "; 
            }
            else if (i % 5 == 0)
            {
                outputString += "Buzz ";
            }
            else if (i % 3 == 0)
            {
                outputString += "Fizz ";
            }
            else
            {
                outputString += i + " ";
            }
                
        }
        return outputString.TrimEnd();
    }

    static void Main(string[] args)
    {
        
    }
}