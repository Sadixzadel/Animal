using Animal1;
using static Animal1.Animal;

internal class Program
{
    public static void Main(string[] args)
    {
        Animal[] animals = new Animal[3];
        animals[0] = new Dog( "Bones", "Yard", "Rex");
        animals[1] = new Cat("Fish", "Flat", "Kity");
        animals[2] = new Horse( "Hay", "Horse farm", "Dora");

        for (int i = 0; i < animals.Length; i++)
        {
            
            Veterinarian.TreatAnimal(animal);
        }
    }
}
