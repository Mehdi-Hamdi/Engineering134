using System.Text;

namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = " C# list fundamentals";
            Console.WriteLine(StringBuilderExercise(myString));
        }

        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.ToUpper().Trim();
            var nPos = trimmedUpperString.IndexOf('N');
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
            return sb.ToString();
        }
    }
}