public class Dog(bool friendly, string name) : Pet(name), ITalkable
{
    public bool Friendly => friendly;
    
    public string Talk()
    {
        return "Bark";
    }

    public string GetName()
    {
        return name;
    }

    public override string ToString()
    {
        return $"Dog: name={Name} friendly={friendly}";
    }
}
