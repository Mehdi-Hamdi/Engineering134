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

        Console.WriteLine("Enter password");
        string userInput = Console.ReadLine();

        while (PasswordCheck(userInput) == false)
        {
            Console.WriteLine("Try again");
            userInput = Console.ReadLine();
        }

        string[,] chessBoard = MakeAChessBoard();
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
        string newString = "";
        foreach (char i in input)
        {
            if (i == 'e')
            {
                newString += '3';
            }
            else if (i == 'a')
            {
                newString += 4;
            }
        }
        
        return input;
    }

    private static bool PasswordCheck(string password)
    {
        return (password == "Password!");
    }

    private static string[,] MakeAChessBoard()
    {
        List<char> columns = new() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        string[,] chessPositions = new string[8, 8];
        for (int y = 0; y < 8; y++)
        {
            for (int x = 0; y < 8; x++)
            {
                chessPositions[x,y] = $"{columns[x]}{8-y}";
            }
        }
        return chessPositions;
    }
}





