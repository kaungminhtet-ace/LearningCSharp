namespace LearningCSharp;

public abstract class Command
{
    protected void Register(CommandStore store)
    {
        store.Add(this);
    }
}