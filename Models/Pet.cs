public abstract class Pet(string name) : IAnimal
{
  public string Type => "throw new NotImplementedException()";

  protected string Name { get; set; } = name;

  string IAnimal.Name => throw new NotImplementedException();
}