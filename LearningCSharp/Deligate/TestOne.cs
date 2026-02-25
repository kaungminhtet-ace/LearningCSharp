namespace LearningCSharp.Deligate;

public delegate void CallBack(string message);
public delegate TOutput ResultUnaryFn<TInput, TOutput>(TInput input);
public delegate ResultUnaryFn<TInput, TOutput> UniaryFn<TInput, TOutput>(TInput arg);


class ExportPDF
{
    public static void Export(string text)
    {
        Console.WriteLine($"{text} is successfully exported as pdf.");
    }
}

class ExportHTML
{
    public static void Export(string text)
    {
        Console.WriteLine($"{text} is successfully exported as HTML.");
    }
}

public class TestOne
{
    public static void Test()
    {
        UniaryFn<int, int> add = a => b => a + b;

        var res = add(20)(20);
        Console.WriteLine(res);
        
        CallBack pdf = ExportPDF.Export;
        CallBack html = ExportHTML.Export;
        CallBack both = pdf + html;
        both("I need you!!!!!!!!!!!!");

        both -= pdf;
        both("I need you still!!!!!!!!!!!!!");

        both += (msg) => { Console.WriteLine($"{msg} is extened."); };
        both("I need you still still!!!!!!!!!!!!!");
    }
}