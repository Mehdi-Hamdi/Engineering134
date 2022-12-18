using System.Xml.Schema;

namespace AdventOfCodeDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ElfCarryingCalories()); 
        }

        public static string ElfCarryingCalories()
        {
            var listOfCalories = File.ReadAllLines("C:/Users/Mahdi/Documents/Engineering134/AdventOfCodeDay1/DataFromAdventOfCode1.txt");
            
            List<int> individualElfSumCalories= new List<int>();

            int Sum = 0;
            foreach (string kcal in listOfCalories)
            {
                if (Int32.TryParse(kcal, out int result)) 
                {
                    Sum += result;
                }
                else
                {
                    individualElfSumCalories.Add(Sum);
                    Sum = 0;
                }
            }

            int highestCalories = 0;

            foreach (int i in individualElfSumCalories)
            {
            if (i > highestCalories) 
                { 
                    highestCalories= i;
                }

            }

            return $"The elf with the highest total calories has {highestCalories} calories";

            

        }
    }
}