using System;

namespace OOPs.Inheritance
{
    public class Vehicle
    {
        protected string _make;
        protected string _model;
        protected int _year;

        public Vehicle(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {_make} {_model} ({_year})");
        }
    }

    public class Car : Vehicle
    {
        private int _speed;

        public Car(string make, string model, int year, int speed) : base(make, model, year)
        {
            _speed = speed;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Speed: {_speed} km/h");
        }
    }

    public class Truck : Vehicle
    {
        private int _cargoCapacity;

        public Truck(string make, string model, int year, int cargoCapacity) : base(make, model, year)
        {
            _cargoCapacity = cargoCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Cargo Capacity: {_cargoCapacity} kg");
        }
    }

    public class Employee
    {
        private string _name;
        private string _department;
        private int _salary;

        public Employee(string name, string department, int salary)
        {
            _name = name;
            _department = department;
            _salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {_name}");
            Console.WriteLine($"Department: {_department}");
            Console.WriteLine($"Salary: {_salary}");
        }
    }

    public class Manager : Employee
    {
        private string _name;
        private string _department;
        private int _salary;

        public Manager(string name, string department, int salary) : base(name, department, salary)
        {
            _name = name;
            _department = department;
            _salary = salary;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"My name is {_name} and my role is {_department}. I currently make about {_salary} per year.");
        }
    } 

    public class InheritanceExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Inheritance Example ---");

            Car myCar = new Car("Toyota", "Camry", 2020, 120);
            myCar.DisplayInfo();

            Console.WriteLine();

            Truck myTruck = new Truck("Volvo", "VNR", 2018, 4000);
            myTruck.DisplayInfo();

            Manager myManager = new Manager("John Doe", "Sales", 100000);
            myManager.DisplayInfo();
        }
    }
}
