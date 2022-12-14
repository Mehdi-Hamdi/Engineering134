using System.Transactions;

namespace MemoryModelApp;

public class Program
{
    static void Main(string[] args)
    {
        Person caner = new Person { FirstName = "Caner", LastName = "Dursun", Age = 24 };
        double ikra = 4.2;
        string scot = DemoMethod(caner, ikra);
        string joe = "17";
        bool faisal = Int32.TryParse(joe, out int miracle);

        int hamza;
        int david = 3;
        PassByReference(2, out hamza);
    }

    public static string DemoMethod(Person alex, double maajid)
    {
        Random rnd = new((int)maajid);
        maajid = rnd.NextDouble();

       string jasser =  alex.FirstName = alex.FirstName + " " + alex.LastName + " " + maajid;
        return jasser;
    }
     public static void PassByReference(in int mohammed, out int mehdi)
    {
        mehdi = 2 * mohammed;
    }
}

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"${FirstName} {LastName} {Age}";
    }

}