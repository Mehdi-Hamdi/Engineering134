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
            //ParsingStrings();
            OneDArrays();
            MultiDArrays();
            JaggedArrays();
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

        public static void OneDArrays()
        {
            int[] myIntArray = { 12, 23, 34, 45, 56 };
            // Array.Reverse(myIntArray); can use this method as well
            foreach (var element in myIntArray.Reverse())
            {
                Console.WriteLine(element);
            }
        }

        public static void MultiDArrays()
        {
            //2D Arrays
            int[,] grid = new int[2, 4];
            grid[0, 1] = 6;
            grid[1, 0] = 8;
            grid[1, 3] = 10;

            char[,] gridTwo =
            {
            { 'a', 'b' },
            { 'a', 'b' },
            { 'a', 'b' },
            { 'a', 'b' },
            { 'a', 'b' },
           };
            Console.WriteLine("All of grid two");
            foreach (var element in gridTwo)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("GridTwo row by row");
            for (int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
            {
                for (int j = gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); j++)
                {
                    Console.WriteLine($"({i}, {j}) {gridTwo[i, j]} ");
                }

            }
        }

        public static void JaggedArrays()
        {
            int[][] intJArray = new int[2][];
            intJArray[0] = new int[4];
            intJArray[1] = new int[2];

            intJArray[0][2] = 3;
            intJArray[1][0] = 5;

            string[][] animalJArray = new string[][]
            {
                new string[] { "Hyena", "lion", "cheetah", "Panther" },
                new string[] { "peacock", "canary" }
            };

            Console.WriteLine("Jagged array of animals");
            foreach (var element in animalJArray)
            {
                foreach (var animal in element)
                {
                    Console.WriteLine(animal);
                }
            }
               


        }
           
        
    }
}