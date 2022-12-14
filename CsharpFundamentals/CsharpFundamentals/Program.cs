using Microsoft.VisualBasic;
using System;

public class Program
{
    public static void Main()
    {
        string result = DeclaringTemperatureOutside(20);
        Console.WriteLine(result);

        string convert = LoopDemonstration("leetspeak");
        Console.WriteLine(convert);


    }
    private static string DeclaringTemperatureOutside(int temperatureOutside)
    {
        string message = "";

        if (temperatureOutside <= 0)
        {
            message = "Literally freezing";
        }
        else if (temperatureOutside <= 17)
        {
            message = "Sweater weather";
        }
        else if (temperatureOutside <= 33)
        {
            message = "Outdoor meal time";
        }
        else
        {
            message = "Nah, too hot to be outside";
        }
        return message;
    }

    

    private static string LoopDemonstration(string input)
    {
        
        
        foreach (char x in input)
        {
            input = input.ToUpper().Replace('E', '3').Replace('A', '4').Replace('I', '1').Replace('O', '0');
        }
        return input;
    }
}





