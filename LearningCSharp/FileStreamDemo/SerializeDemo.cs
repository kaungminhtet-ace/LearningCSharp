using System.Security.Cryptography;
using System.Text.Json;

namespace LearningCSharp.FileStreamDemo;

enum Color
{
    RED,
    GREEN,
    BLUE,
}

class Student
{
    public  int Id { get; set; }
    public string Name { get; set; }
    public string[]? Hobbies { get; set; }

    public Student? StudentOne { get; set; }

    public Color C { get; set; }
}

public class SerializeDemo
{
    public static void Test()
    {
        var s3 = new Student
        {
            Id = 001,
            Name = "Student 1",
            C = Color.BLUE
        };
        
        var s1 = new Student
        {
            Id = 0,
            Name = "Kaung Min Htet",
            Hobbies = ["sleep", "eat", "sleep"],
            StudentOne = s3,
            C = Color.GREEN
        };
        string jsonString = JsonSerializer.Serialize(s1);
        
        Console.WriteLine(jsonString);

        Student? s2 = JsonSerializer.Deserialize<Student>(jsonString);
        Console.WriteLine(s2?.Id);
        Console.WriteLine(s2?.Name);
        foreach (var hobby in s2?.Hobbies!)
        {
            Console.WriteLine(hobby);
        }
    }
}