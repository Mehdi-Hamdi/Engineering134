namespace SafariParkApp;
//In C# there is only single inheritance.
public class Hunter : Person, IShootable
{
    public IShootable Shooter { get; set; }
    //You can call to the base class constructor using ': base'
    public Hunter(string firstName, string lastName, IShootable shooter) : base(firstName, lastName)
    {
        Shooter = shooter;
    }

    //You cannot declare an empty constructor on its own if there is no empty constructor in the base class.
    public Hunter() { }

    public string Shoot()
    {
        return Shooter.Shoot();
    }

    public override string ToString()
    {
        return $"{base.ToString()} and a {Shooter} camera";
    }

    //In order to override a method, you must mark it as virtual in the parent class.
    
}
