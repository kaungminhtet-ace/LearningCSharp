namespace LearningCSharp.FunctionDemo;

public class CallByRef:FunctionDemo
{
    private static void Ref(ref int a)
    {
        a += 10;
    }

    private static int In(in int a)
    {
        return a + 10;
    }

    static void Out(out int a)
    {
        a = 10;
    }
    
    public static void Test()
    {
        var a = 0;
        Ref(ref a);
        Console.WriteLine(a);
        a = In(in a);
        Console.WriteLine(a);
        Out(out a);
        Console.WriteLine(a);
    }
}