using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace MethodsApp;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Methods App!");
        int result = DoThis(10, "hungry");


        //an optional parameter
        int result2 = DoThis(5);

        //named parameter
        DoThis(x: 5, y: "sleepy");
        string pizza = OrderPizza(tuna: false, sweetcorn: true, jalapenos: true, chicken: true, peppers: true);

        string outVariable = "I'm feeling hungry";
        int result3 = DoThisOut(1, "not hungry", out outVariable);

        //tuples
        var person = ("Joe", "Bloggs", 25);
        Console.WriteLine($"{person.Item1} {person.Item2} is {person.Item3} years old.");

        int age = 24;
        var student = (fName: "Mehdi", lName: "Hamdi", age);
        Console.WriteLine($"{student.fName} {student.lName} is {student.age} years old.");

        //tuples as a return type
        var weight = ConverstPoundsToStonesAndPounds(156);
        Console.WriteLine(weight.stones + " " + weight.pounds);
    }

    public static int DoThis(int x, string y = "happy")
    {
        Console.WriteLine($"I'm feeling {y}");
        return x * x;
    }
    public static int DoThisOut(int x, string y, out string result)
    {
        result = ($"I'm feeling {y}");
        return x * x;
    }

    public static string OrderPizza(bool tuna, bool sweetcorn, bool jalapenos, bool peppers, bool chicken)
    {
        var pizza = "Pizza with tomato sauce, cheese, ";
        if (tuna) pizza += "tuna, ";
        if (sweetcorn) pizza += "sweetcorn, ";
        if (jalapenos) pizza += "jalapenos, ";
        if (peppers) pizza += "peppers, ";
        if (chicken) pizza += "chicken, ";
        return pizza;
    }

    public static (int stones, int pounds) ConverstPoundsToStonesAndPounds(int pounds)
    {
        const int poundsInAStone = 14;
        var st = pounds / poundsInAStone;
        var lbs = pounds % poundsInAStone;
        return (st, lbs);
    }


}