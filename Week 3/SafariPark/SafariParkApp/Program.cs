namespace SafariParkApp;

public class Program
{
    public static void Main(string[] args)
    {
        Person alex = new Person("Alex", "Blunt", 18);
        Console.WriteLine(alex.FullName());

        Person mehdi = new Person("Mehdi", "Hamdi");
        Console.WriteLine(mehdi.Age);

    }
}