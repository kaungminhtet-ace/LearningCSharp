namespace LearningCSharp.ArrayDemo;

public class CommandLineArgs
{
    public static void Test(string[] args)
    {
        foreach (var arg in args)
        {
            Console.Write(arg, " ");
        }
    }
}