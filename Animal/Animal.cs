using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal1;

internal abstract class Animal
{
    private string Food;
    private string Location;
    
    public Animal(string food, string location)
    {
        Food = food;
        Location = location;
    }

    public abstract string Eat();
    public abstract string MakeNoise();

    //?
    public string? Sleep()
    {
        return base.ToString();
    }
    
    public class Dog : Animal
    {
        public string Name { get; set; }
        public Dog(string food, string location, string name) : base(food, location)
        {
            Name = name;
        }

        public override string Eat()
        {
            return ("Dog is eating");
        }

        public override string MakeNoise()
        {
            return ("Gaf- gaf- gah");
        }
    }

    public class Cat : Animal
    {
        public string Name { get; set; }
        public Cat(string food, string location, string name) : base(food, location)
        {
            Name = name;
        }


        public override string Eat()
        {
            return ("Cat is eating");
        }

        public override string MakeNoise()
        {
            return ("Miu- miu- miu");
        }
    }

    public class Horse : Animal
    {
        public string Name { get; set; }
        public Horse(string food, string location, string name) : base(food, location)
        {
            Name = name;
        }

        public override string Eat()
        {
            return ("Horse is eating");
        }

        public override string MakeNoise()
        {
            return ("Ii- go- go");
        }
    }
    
    public class Veterinarian
    {
        public static string TreatAnimal(Animal animal)
        {
            return animal.ToString();
        }
    }

}