using System.Diagnostics.Metrics;

namespace SafariParkApp;

public class Program
{
    public static void Main(string[] args)
    {
        Queue<Person> peopleQueue = new();
        peopleQueue.Enqueue(new Person("Alex", "Blunt"));
        peopleQueue.Enqueue(new Person("Mohammed", "Ali"));
        peopleQueue.Enqueue(new Person("Ikra", "Dahir"));

        Console.WriteLine(peopleQueue.Dequeue());
           
        Stack<Person> peopleStack = new();
        peopleStack.Push(new Person("Alex", "Blunt"));
        peopleStack.Push(new Person("Mohammed", "Ali"));
        peopleStack.Push(new Person("Ikra", "Dahir"));

        Console.WriteLine(peopleStack.Pop());

        int[] original = new int[] { 1, 2, 3, 4, 5 };
        int[] reversed = new int[original.Length];
        var stack = new Stack<int>();
        foreach (int i in original)
        {
            stack.Push(i);
        }
        int length = stack.Count;
        for (int i = 0; i < reversed.Length; i++)
        {
            reversed[i] = stack.Pop();
        }

        //hash set
        var planeSet = new HashSet<Airplane>
        {
            new Airplane(5) {Speed = 10, Altitude = 5},
            new Airplane(15) {Speed = 20, Altitude = 50},
            new Airplane(35) {Speed = 30, Altitude = 500},
            new Airplane(35) {Speed = 30, Altitude = 500},
        };

        foreach (var plane in planeSet) Console.WriteLine(plane);

        var plane1 = new Airplane(1);
        var plane2 = new Airplane(1);

        bool addCapacity1Plane = planeSet.Add(plane1);
        bool addCapacity1PlaneAgain = planeSet.Add(plane2);

        //dictionary <key, value>
        var personDict = new Dictionary<string, Person>()
        {
            {"Tashheer", new Person("Mohammed", "Ali") },
            {"Nah", new Person("Mehdi", "Hamdi") },
            {"No", new Person("Scot", "Morrison") }
        };
        Console.WriteLine(personDict["Tashheer"]);
        personDict.Add("Maj", new Person("Maajid", "Ali"));

        var keys = personDict.Keys.ToArray();

        Console.WriteLine(keys[0]);

        foreach (var kvp in personDict) Console.WriteLine(kvp.Key);

        string input = "The cat in the hat comes back";
        var countDict = new Dictionary<char, int>();

        foreach (char c in input.ToLower()) 
        {
            if (c == ' ') { }

            else if (countDict.ContainsKey(c))
            {
                countDict[c]++;
            }
            else
            {
                countDict.Add(c, 1);
            }
        }

        List<Person> people = new()
        {
            new Person("Alex", "Blunt"),
            new Person("Mohammed", "Ali"),
            new Person("Ikra", "Dahir"),
        };

        foreach(Person p in people)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine(people[0]);

        var caner = new Person("Caner", "Dursun");
        people.Add(caner);

        List<int> ints = new() { 5, 4, 3, 9, 0 };
        ints.Add(8);
        ints.Sort();
        ints.Remove(ints[1]);
        ints.Remove(ints[1]);
        ints.Insert(2, 1);
        ints.Reverse();
        ints.Remove(9);

        var bobOne = new Person("Bob", "Builder");
        var bobTwo = new Person("Bob", "Builder");

        Console.WriteLine("BobOne is BobTwo? " + bobOne.Equals(bobTwo));

        bobTwo.Age = 36;

        Console.WriteLine(bobOne.Equals(bobTwo));

        var cesna = new Airplane(5);
        var bushPlane = new Airplane(5);
        bushPlane.Ascend(300);
        bool isTheSame = cesna == bushPlane;


        Console.WriteLine("Cesna is bushPlane? " + isTheSame);

        List<Airplane> planes = new()
        {   
            cesna, 
            bushPlane, 
            new Airplane(15) {Altitude = 200}
        };

        planes.Sort();



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
        Person jasser = new Person("Jasser", "Bawi");
       
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