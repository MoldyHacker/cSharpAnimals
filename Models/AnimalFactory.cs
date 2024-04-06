public class AnimalFactory
{
    public static IAnimal CreateAnimal(AnimalType type, string name)
    {
      switch (type)
      {
          case AnimalType.Dog:
              return new Dog(true, name);
          case AnimalType.Cat:
              return new Cat(true, name);
          default:
              throw new ArgumentException("Unknown animal type");
      }
    }
}