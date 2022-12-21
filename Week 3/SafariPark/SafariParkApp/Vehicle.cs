
namespace SafariParkApp;

public abstract class Vehicle : IMoveable, IEquatable<Vehicle?>
{
    private int _capacity;
    private int _numPassengers;

    public int NumPassengers
    {
        get
        {
            return _numPassengers;
        }
        set
        {
            if (value >= 0 && value <= _capacity) _numPassengers = value;
        }
    }

    public int Position { get; set; }

    public int Speed { get; init; }

    public virtual string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public virtual string Move(int times)
    {
        Position += times * Speed;
        return $"Moving along {times} times";
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Vehicle);
    }

    public bool Equals(Vehicle? other)
    {
        return other is not null &&
               _capacity == other._capacity &&
               Speed == other.Speed;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_capacity, Speed);
    }

    //Constructors
    public Vehicle()
    {
        Speed = 10;
    }

    public Vehicle(int capacity, int speed = 10)
    {
        _capacity = capacity;
        Speed = speed;
    }

    public static bool operator ==(Vehicle? left, Vehicle? right)
    {
        return EqualityComparer<Vehicle>.Default.Equals(left, right);
    }

    public static bool operator !=(Vehicle? left, Vehicle? right)
    {
        return !(left == right);
    }
}
 public class Airplane : Vehicle, IEquatable<Airplane?>, IComparable<Airplane>
{
    private string _airline;
    private int _altitude;
    public int Altitude 
    {
        get
        {
        return _altitude;
        }
        set
        {
            if (value >= 0) 
            {
                _altitude = value;
            }
            else
            throw new ArgumentException("Plane crashed");
        }
    }

    public Airplane(int capacity) : base(capacity) { }
    
    public Airplane(int capacity, int speed, string airline) : base(capacity, speed) { }

    public void Ascend(int distance) 
    {
        Altitude += distance;
    }
    public void Descend(int distance)
    {
        Altitude -= distance;
    }

    public override string Move()
    {
        Position += Speed;
        return "Moving along";
    }

    public override string Move(int times)
    {
        Position += Speed * times;
        return "Moving along";
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as Airplane);
    }

    public bool Equals(Airplane? other)
    {
        return other is not null &&
               NumPassengers == other.NumPassengers &&
               base.Equals(other);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(NumPassengers, Speed);
    }

    public int CompareTo(Airplane? other)
    {
        if (Altitude > other.Altitude)
        {
            return 1;
        }
        else if (Altitude == other.Altitude)
        {
            return 0;
        }
        else
        {
            return -1; 
        }
    }

    public static bool operator == (Airplane left, Airplane right)
    {
       return EqualityComparer<Airplane>.Default.Equals(left, right);
    }

    public static bool operator != (Airplane left, Airplane right)
    {
        return !(left == right);
    }
}    

