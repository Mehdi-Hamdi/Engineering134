using System.Security.Cryptography.X509Certificates;

namespace ControlFlowApp
{
    internal class program
    {

        static void Main(string[] args)
        {
            int mark = 90;
            var grade = mark >= 65 ? (mark >= 85 ? "distinction" : "Pass") : "Fail";

            Console.WriteLine(Priority(1));
            Console.WriteLine(CanDrive(18));

            List<int> nums = new List<int> { 10, 6, 22, -17, 3, };
            Console.WriteLine("Highest foreach loop: " + Looptypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + Looptypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + Looptypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + Looptypes.HighestDoWhileLoop(nums));
        }

        List<int> nums = new List<int> { 10, 6, 22, -17, 3, };  
        public static string Priority(int level)
        {
            string priority = "code";
            switch (level)
            {
                case 3:
                    priority = priority + " Red";
                    break;
                case 2:
                    priority = priority + " Amber";
                    break;
                case 1:
                    priority = priority + " Green";
                    break;
            }
            return priority;
        }
            public static bool CanDrive(int age)
            {
                switch (age)
                {
                    case >= 17:
                        return true;
                        default: return false;
                }
            }
        }
    }
