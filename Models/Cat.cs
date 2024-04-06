public class Cat(int mousesKilled, string name) : Pet(name), ITalkable
{
    public int MousesKilled => mousesKilled;
    
    public void AddMouse()
    {
        mousesKilled++;
    }

    public string Talk()
    {
        return "Meow";
    }

    public string GetName()
    {
        return name;
    }

    public override string ToString()
    {
        return $"Cat: name={Name} mousesKilled={mousesKilled}";
    }
}
