namespace StringCalculatorKata;

public class Program
{
    static void Main(string[] args)
    {
        
    }

    public static int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var splitNumbers = numbers.Split(',', '\n');
        var sum = 0;
        foreach (var number in splitNumbers)
        {
            sum += int.Parse(number);
        }
        return sum;
    }
}