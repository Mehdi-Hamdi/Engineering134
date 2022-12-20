using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp;

public abstract class Vehicle : IMoveable
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

}
 public class Airplane : Vehicle
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
}    
