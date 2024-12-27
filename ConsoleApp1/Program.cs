using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    abstract class Transport
    {
        public string Name { get; set; }
        public double Speed { get; set; }

        public Transport(string name, double speed)
        {
            Name = name;
            Speed = speed;
        }

        public abstract void Move();

        public void Stop()
        {
            Console.WriteLine($"{Name} остановился.");
        }
    }

    class Car : Transport
    {
        public int NumberOfDoors { get; set; }

        public Car(string name, double speed, int numberOfDoors) : base(name, speed)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} движется со скоростью {Speed} км/ч.");
        }
    }

    class Bicycle : Transport
    {
        public int Gears { get; set; }

        public Bicycle(string name, double speed, int gears) : base(name, speed)
        {
            Gears = gears;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} движется со скоростью {Speed} км/ч с {Gears} передачами.");
        }
    }

    class Airplane : Transport
    {
        public string EngineType { get; set; }

        public Airplane(string name, double speed, string engineType) : base(name, speed)
        {
            EngineType = engineType;
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} летит со скоростью {Speed} км/ч с {EngineType} двигателем.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car("Машина", 120, 4);
            Transport bicycle = new Bicycle("Велосипед", 25, 18);
            Transport airplane = new Airplane("Самолет", 900, "турбовинтовым");

            car.Move();
            car.Stop();

            bicycle.Move();
            bicycle.Stop();

            airplane.Move();
            airplane.Stop();
        }
    }