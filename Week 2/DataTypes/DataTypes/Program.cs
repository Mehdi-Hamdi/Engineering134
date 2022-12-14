namespace DataTypesApp;

public class Program
{
    static void Main(string[] args)
    {
        int number = 5;

        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 4;

        var greeting = "Hello there";
        string greeting2;
        var age = 33;
        var height = 182.5f;
        var ageOfTheUniverse = 13_135_463_746uL;
        var makessense = true;
        var grade = 'A';

        //implicit usings
        List<int> nums;
        var prices = new List<decimal>();

        float sum = 0;
        for (int i =0; i < 100_000; i++)
        {
            sum += 1 / 7f;
        }
        Console.WriteLine(sum);
        Console.WriteLine(700_000 * (1 / 7f));

        if (700_000 * (1 / 7f) == 100_000)
        {
            Console.WriteLine("700,000 is divided by 7!");

        }
        else
        {
            Console.WriteLine("700,000 is not divided by 7!");
        }

        var a = 12;
        var b = 7.0;
        var c = a / b;

        unchecked
        {
            int bigNumber = Int32.MaxValue + 1;
            Console.WriteLine(bigNumber);

            int smallNumber = Int32.MinValue - 1;
            Console.WriteLine(smallNumber);
        }

        int trees = 5000;
        short greenery = (short)trees;

        double pi = 3.14159265359;
        float piFloat = (float)pi;
        Console.WriteLine(piFloat);
        Console.WriteLine(pi);

        int bankBalance = -2;
        uint postCovidBalance = (uint)bankBalance;
        Console.WriteLine(Convert.ToString(postCovidBalance, 2));
        Console.WriteLine(Convert.ToString(bankBalance, 2));

        string six = "6";
        var numberSix = Convert.ToInt32(six);
        Console.WriteLine(numberSix);
    }
}