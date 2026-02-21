namespace LearningCSharp.PropertiesDemo;

class Point(int x, int y)
{
    private int _x;
    private int _y;

    public int X
    {
        get => _x;
        set
        {
            if (value < 0) throw new ArgumentException("value");
            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            if (value < 0) throw new ArgumentException("value");
            _y = value;
        }
    }
}

public class PropertiesDemo
{
    public static void Test()
    {
        var p = new Point(100, 200);
        
        Console.WriteLine(p.X + "  " + p.Y);
        p.X = 5;
        p.Y = 10;
        
        Console.WriteLine(p.X + "  " + p.Y);
    }
}