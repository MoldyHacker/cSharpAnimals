public class Teacher(int age, string name) : Person(name), ITalkable
{
    public int Age
    {
        get => age;
        set => age = value;
    }

    public string Talk()
    {
        return "Don't forget to do the assigned reading!";
    }

    public string GetName()
    {
        return name;
    }
}
