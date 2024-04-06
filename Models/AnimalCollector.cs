namespace cSharpAnimals.Models;

public class AnimalCollector
{
    private List<Object> animals = new List<Object>();
    // public static void AddAnimalToZoo()
    // {
    //     int animalSelection = UserInput.GetAnimalSelection();
    //     string name = UserInput.GetAnimalName();
    //     IAnimal animal = AnimalFactory.CreateAnimal(animalSelection, name);
    //     Zoo.AddAnimal(animal);
    // }

    public void StartCollecting()
    {
        Console.WriteLine("Animal Collection Program");
        Console.WriteLine("Type '0' at any point to finish.");

        while (true)
        {
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Teacher");
            Console.Write("Your choice: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice == 0) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter dog's name: ");
                    var dogName = Console.ReadLine();
                    Console.Write("Is the dog friendly? (yes/no): ");
                    bool isFriendly = Console.ReadLine().Trim().ToLower() == "yes";
                    animals.Add(new Dog(isFriendly, dogName));
                    break;
                case 2:
                    Console.Write("Enter cat's name: ");
                    var catName = Console.ReadLine();
                    Console.Write("How many mice has the cat killed?: ");
                    int miceKilled;
                    while (!int.TryParse(Console.ReadLine(), out miceKilled))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.Write("How many mice has the cat killed?: ");
                    }
                    animals.Add(new Cat(miceKilled, catName));
                    break;
                case 3:
                    Console.Write("Enter teacher's name: ");
                    var teacherName = Console.ReadLine();
                    Console.Write("What is the teacher's age?: ");
                    int age;
                    while (!int.TryParse(Console.ReadLine(), out age))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                        Console.Write("What is the teacher's age?: ");
                    }
                    animals.Add(new Teacher(age, teacherName));
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("You've added the following animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine($"- {animal.GetType().Name}: {animal.Name}");
        }

        Console.WriteLine("You've added the following people:");
        foreach (var person in people)
        {
            Console.WriteLine($"- {person.GetType().Name}: {person.Name}, Age: {person.Age}");
        }
    }
}