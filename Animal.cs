using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    public class Animal
    {
        public Animal(string name, int age, int weight, string food, string habitat)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Food = food;
            Habitat = habitat;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string Food { get; set; }
        public string Habitat { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine($"The {Name} eats {Food}");
        }
        public virtual void Move()
        {
            Console.WriteLine($"The {Name} moves by walking");
        }
        public virtual void Hunt()
        {
            Console.WriteLine($"The {Name} does hunting");
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"The animal is a {Name}, it's {Age} years old, it's weight is {Weight} kg, it eats {Food} and lives {Habitat}");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"The {Name} makes a sound");
        }
    }
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string name, int age, int weight, string food, string habitat, string breed) : base(name, age, weight, food, habitat)
        {
            Breed = breed;
        }
        public override void Hunt()
        {
            Console.WriteLine($"The {Name} does not hunt but gets the food of his owner");
        }
        public void DoTrick()
        {
            Console.WriteLine($"The {Name} jumps, sits down and give you the paw!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} does WOOF WOOF");
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The animal is a {Name} that is of breed {Breed}, it's {Age} years old, the weight is {Weight} kg, it eats {Food} and lives {Habitat}");

        }
    }
    public class Lion : Animal
    {
        public string RoleInTheKingdom { get; set; }
        public Lion(string name, int age, int weight, string food, string habitat, string role) : base(name, age, weight, food, habitat)
        {
            RoleInTheKingdom = role;
        }
        public virtual void TheKing()
        {
            Console.WriteLine($"The {Name}s are known to be {RoleInTheKingdom}");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} does ROOOOAR");
        }
    }
    public class Shark : Animal
    {
        public Shark(string name, int age, int weight, string food, string habitat, bool hasFeet) : base(name, age, weight, food, habitat)
        {
            HasFeet = hasFeet;
        }

        public bool HasFeet { get; set; }
        public override void Move()
        {
            Console.WriteLine($"The {Name} moves by swimming because it doesn't have {HasFeet}");
        }
        public string TextHasFeet()
        {
            return HasFeet ? "feet" : "no feet"; 
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The animal is a {Name}, it's {Age} years old, the weight is {Weight} kg, it eats {Food} and lives {Habitat} and has no {TextHasFeet()} ");

        }
        public string CantBreath()
        {
            return $"Did you know that the {Name} can't breath on the Earth? That's why it lives in the {Habitat}";
        }
        public override void MakeSound()
        {
            Console.WriteLine($"The {Name} does WHOOSH WHOOSH but you will probably never hear it in your life! (Let's hope so)");
        }
    }
    public class ShihTzu : Dog
    {
        public ShihTzu(string name, int age, int weight, string food, string habitat, string breed, string size) : base(name, age, weight, food, habitat, breed)
        {
            Size = size;
        }

        public string Size { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The animal is a {Name} that is of breed {Breed}, it's {Size}, it's {Age} years old, it eats {Food} and lives {Habitat}");
        }
        public virtual string Sleep()
        {
            return $"The {Name} loves to sleep and won't bother you every minute";
        }
        public override void Hunt()
        {
            Console.WriteLine("The Shih-Tzus are peaceful and just wants to love you");
        }
    }
    public class JackRussel : Dog
    {
        public JackRussel(string name, int age, int weight, string food, string habitat, string breed, string size, bool runningFast) : base(name, age, weight, food, habitat, breed)
        {
            RunningFast = runningFast;
            Size = size;
        }
        public bool RunningFast { get; set; }
        public string Size { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"The animal is a {Name} that is of breed {Breed}, it's {Size}, it's {Age} years old, it eats {Food} and lives {Habitat}");
        }
        public virtual string OutdoorDog()
        {
            return $"{Breed} is a perfect dog for someone who loves to spend time outside! It's {BoolRunningFast()} and loves to play!";
        }
        public virtual string BoolRunningFast()
        {
            return RunningFast ? "running fast" : "not running fast";
        }
    }
}

