using System.Text;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            Console.WriteLine(StringBuilderExercise(myString));
            StringInterporlation("Mehdi");
            ParsingStrings();
        }

        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.ToUpper().Trim();
            var nPos = trimmedUpperString.IndexOf('N');
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
            return sb.ToString();
        }

        public static void StringInterporlation(string str)
        {
            Console.WriteLine("My name is :" + str + "using +");
            Console.WriteLine($"my name is : {str} using interpolation");
            var num1 = 14;
            var num2 = 7;
            var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
            var fstring2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0.####}";
            var fstring3 = $"That will be {num2 / 3.0:C} please";
        }

        public static void ParsingStrings()
        {
            // parsing strings
            Console.WriteLine("How many apples?");
            string input = Console.ReadLine();
            //int numApples = Int32.Parse(input);
            var success = Int32.TryParse(input, out int parsedApples);
        }

    }
}