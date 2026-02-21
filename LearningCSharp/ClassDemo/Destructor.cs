namespace LearningCSharp.ClassDemo;

public class Destructor
{
    public Destructor()
    {
        Console.WriteLine("Construciton " + nameof(Destructor));
    }

    ~Destructor()
    {
        Console.WriteLine("Destring " + nameof(Destructor));
    }
}