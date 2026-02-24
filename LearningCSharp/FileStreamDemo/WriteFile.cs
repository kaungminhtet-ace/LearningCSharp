using System.Text;

namespace LearningCSharp.FileStreamDemo;

public class WriteFile
{
    public static void Read()
    {
        var p = "/home/kgkg/tmp/helo.txt";
        using FileStream f = new FileStream(p, FileMode.OpenOrCreate);
        f.Write(Encoding.UTF8.GetBytes("Hello, World"));

    }

    public static void Write()
    {
        var p = "/home/kgkg/tmp/helo.txt";
        using FileStream f = new FileStream(p, FileMode.OpenOrCreate);
        int i;
        while ((i = f.ReadByte()) != -1) 
        {
            Console.Write((char)i);
        }
    }
    
    public static void Test()
    {
        Read();
        Write();
    }
}