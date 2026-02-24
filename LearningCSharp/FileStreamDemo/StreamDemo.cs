namespace LearningCSharp.FileStreamDemo;

public class StreamDemo
{
    public static void Write(string path)
    {
        using var f = new FileStream(path, FileMode.Create);
        using var bs = new BufferedStream(f);
        using var w = new StreamWriter(bs);
        w.WriteLine("Hello, World with stream writer!");
    }
    
    public static void Read(string path)
    {
        using var f = new FileStream(path, FileMode.Open);
        using var bs = new BufferedStream(f);
        using var r = new StreamReader(bs);
        Console.WriteLine("File Contains: \n" + r.ReadToEnd());  
    }
    
    public static void Test()
    {
        String path = "/home/kgkg/tmp/hello.txt";
       Write(path);
       Read(path);
    }
}