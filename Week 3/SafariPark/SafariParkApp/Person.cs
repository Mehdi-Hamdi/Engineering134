using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        //fields
        private string _firstName = "";
        private string _lastName = "";

        //property
        public int Age { get; set; } = 18;

        private int _height = 0;

        public int Height 
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < _height) _height = value;
            }
        }
        

        //method
        public string FullName()
        {
            return _firstName + " " + _lastName;
        }

        public string Move()
        {
            Position += Speed;
            return "Walking along";
        }

        public string Move(int times)
        {
            Position += times * Speed;
            return Move() + $" {times} times";
        }

        //constructor
        public Person (string firstName, string lastName, int age = 21)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }

        //method overloading
        //constructor overloading
        public Person(string firstName, string lastName)
        {
            _firstName = firstName; 
            _lastName = lastName;
        }

        public Person() { }

        public int Position { get; set; }

        public int Speed { get; init; }

    }
}