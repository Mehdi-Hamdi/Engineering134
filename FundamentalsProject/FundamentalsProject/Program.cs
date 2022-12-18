using System.Runtime.ConstrainedExecution;

namespace FundamentalsProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput2 = "";
            string userInput1 = "";
            Console.WriteLine("Enter first integer");
            userInput1 = Console.ReadLine();
            int num1 = 0;
            int num2 = 0;
            bool wholeNumber = Int32.TryParse(userInput1, out num1);

            while (wholeNumber == false)
            {
                Console.WriteLine("Enter whole numbers only");
                userInput1 = Console.ReadLine();
                wholeNumber = Int32.TryParse(userInput1, out num1);
            }
            
            
                Console.WriteLine("Enter second number");
                userInput2 = Console.ReadLine();
                bool wholeNumber2 = Int32.TryParse(userInput2, out num2);

                while (wholeNumber2 == false)
                {
                    Console.WriteLine("Enter whole numbers only");
                    userInput2 = Console.ReadLine();
                    wholeNumber2 = Int32.TryParse(userInput2, out num2);
                }

            int i, count, n;

            var primeNumbers = new List<int>();
            for (n = num1; n <= num2; n++)
            {
                count = 0;

                for (i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        
                    }
                }

                if (count == 0 && n != 1)
                {
                    Console.Write("{0} ", n);
                    primeNumbers.Add(n);
                }
       
            }
            Console.WriteLine(  );
            Console.WriteLine($"The average of the prime numbers is {primeNumbers.Average()}");
            Console.WriteLine($"There are {primeNumbers.Count()} prime numbers");
       
        }
        
        
       
    }
}