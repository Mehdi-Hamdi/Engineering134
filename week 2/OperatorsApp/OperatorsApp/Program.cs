

internal class program
{

    static void Main(string[] args)
    {
        int x = 5;
        int y = 5;
        x++;
        ++y;

        int a = x++;
        int b = ++y;
        for (int i = 1; i <= 5; ++i)
        {
            Console.WriteLine(i);
        }
        var c = 5 / 2;
        var d = 5.0 / 2;
        var e = 5 / 3;
        double f = 5 / 2;

        var daysInAWeek = 7;
        var totalDaysToBirthday = 23;
        var weeksToBirthday = totalDaysToBirthday / daysInAWeek;
        var days = totalDaysToBirthday % daysInAWeek;

        Console.WriteLine(EvenOdd(5));
    }
    public static bool EvenOdd(int num)
    {
        return num % 2 == 0;
    }
        




    


}