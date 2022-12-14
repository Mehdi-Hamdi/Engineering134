using System;

namespace Methods_Lib
{
    public class Methods
    {
        static void Main(string[] args)
        {
            var totalDays = DaysAndWeeks(156);
            Console.WriteLine(totalDays.weeks + " " + totalDays.days);

            var nums = Powersroot(4);
            Console.WriteLine(nums);
        }
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            

            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            else
            {
                const int DaysInAweek = 7;
                var weeks = totalDays / DaysInAweek;
                var days = totalDays % DaysInAweek;
                return (weeks, days);
            }
            

        }

        public static (int square, int cube, double squareRoot) Powersroot(int nums)
        {
            var square = nums * nums;
            var cube = nums * nums * nums;
            var squareRoot = Math.Sqrt(nums);
            return (square, cube, squareRoot);
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

    }
}
