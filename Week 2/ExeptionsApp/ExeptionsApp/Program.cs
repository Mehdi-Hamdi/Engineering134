using System.IO;

namespace ExeptionsApp

{
    public class Program
    {
        static void Main(string[] args)
        {


            //{
            //    string textfile;
            //    try
            //    {
            //       textfile = File.ReadAllText("SuperSecretDiary.txt");
            //        Console.WriteLine(textfile);
            //    }
            //catch (FileNotFoundException e) 
            //    { 
            //        Console.WriteLine("sorry, I cant find the file");
            //        Console.WriteLine(e.Message);
            //    }
            //    catch (NotImplementedException e)
            //    {
            //        Console.WriteLine("Write the method!");
            //        Console.WriteLine(e.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine("I am always run!");

            Console.WriteLine("Alex's grade was " + Grade(81));
            Console.WriteLine("Jasser's grade was " + Grade(-75));
        }    
            public static string Grade(int mark)
            {
            if (mark < 1 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark cannot be out of the range 1 - 100");
            }

                return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
            }
    }

    
}