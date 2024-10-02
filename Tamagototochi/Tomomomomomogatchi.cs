
public class Tomomomomomogatchi
{
    private int hunger;
    private int boredom;
    private List<string> words = new();
    private bool isAlive = true;
    private Random generator;
    public string name;


    public void Feed()
    {
        hunger -= 1;
        Console.WriteLine("NOM NOM NOM");
    }

    public void Hi()
    {
        if (words.Count > 0)
        {
            Console.WriteLine(words[Random.Shared.Next(words.Count)]);
            ReduceBoredom();
        }

        if (words.Count < 0)
        {
            Console.WriteLine("Du kan inte. Måste använda Teach först");
        }
    }

    public void Teach()
    {
        Console.WriteLine("What word do you want to teach?");
        string learnword = Console.ReadLine();

        words.Add(learnword);

    }

    public void Tick()
    {
        hunger += 1;
        boredom += 1;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
        else isAlive = true;
    }

    public void PrintStats()
    {
        Console.WriteLine("Stats:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");

    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        boredom -= 1;
    }

}
