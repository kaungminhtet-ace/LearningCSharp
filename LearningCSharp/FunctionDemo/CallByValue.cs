namespace LearningCSharp.FunctionDemo;

public class CallByValue:FunctionDemo
{
    private static int Add(int a, int b)
    {
        return a + b;
    }
    
    public static void Test()
    {
        Console.WriteLine(Add(10, 20));    
    }
}