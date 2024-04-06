public class UserInput
{
    public static int GetAnimalSelection()
    {
        int animalSelection;
        Console.Write("What animal would you like added to the zoo? (1. Dog, 2. Cat, or 3. Teacher): ");
        animalSelection = int.Parse(Console.ReadLine());
        return animalSelection;
    }

    public static string GetAnimalName()
    {
        Console.Write("Enter the name of the animal: ");
        string name = Console.ReadLine();
        return name;
    }
    public static string GetAnimalData()
    {
        Console.Write("Enter the data for the animal: ");
        string data = Console.ReadLine();
        return data;
    }
}