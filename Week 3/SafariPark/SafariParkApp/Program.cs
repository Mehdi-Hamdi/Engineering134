using System.Diagnostics.Metrics;

namespace SafariParkApp;

public class Program
{
    public static void Main(string[] args)
    {
        List<IShootable> weaponList = new()
        {
            new LaserGun("Nike"),
            new Crossbow("Adidas"),
            new WaterPistol("Puma"),
        };

        foreach (var weapon in weaponList)
        {
            Console.WriteLine(weapon.Shoot());
        }

        Person alex = new Person("Alex", "Blunt", 18);
        Console.WriteLine(alex.FullName());

        Person mehdi = new Person("Mehdi", "Hamdi");
        Console.WriteLine(mehdi.Age);

        Person jassersTwin = new Person("Jasser", "Bawi");
        Person jasser = new Person("Jasser", "Bawii");
       
        List<object> safariObjects = new()
        {
            alex,
            jasser,
            jassersTwin,
            
        };

        foreach (var obj in safariObjects)
        {
         //   Console.WriteLine(obj);
         
            SpartaWrtie(obj);
        }

        IMoveable mover = jasser;
        Console.WriteLine(mover.Move());
        mover = alex;
        Console.WriteLine(mover.Move());
        mover = new Airplane(25);
        Console.WriteLine(mover.Move());

  
    }

    private static void SpartaWrtie(object obj)
    {
        
    }

    private static void SpartaWrtie(IMoveable moveable)
    {
        if (moveable is Person)
        {
            var person = (Person)moveable;
            Console.WriteLine(person.FullName);
        }
        
        Console.WriteLine(moveable.Move());
        Console.WriteLine(moveable.Move(2)); 
    }
}