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
        }
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
