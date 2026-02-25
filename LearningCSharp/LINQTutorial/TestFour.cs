namespace LearningCSharp.LINQTutorial;

public enum GradeLevel
{
    FirstYear = 1,
    SecondYear,
    ThirdYear,
    FourthYear
};

public class Student
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required int ID { get; init; }

    public required GradeLevel Year { get; init; }
    public required List<int> Scores { get; init; }

    public required int DepartmentID { get; init; }
}

public class Teacher
{
    public required string First { get; init; }
    public required string Last { get; init; }
    public required int ID { get; init; }
    public required string City { get; init; }
}

public class Department
{
    public required string Name { get; init; }
    public int ID { get; init; }

    public required int TeacherID { get; init; }
}

public class TestFour
{
    public static void Test1()
    {
        string sentence = "the quick brown fox jumps over the lazy dog";
        string[] words = sentence.Split(' ');

        var query = from word in words
            group word.ToUpper() by word.Length
            into gr
            orderby gr.Key
            select new { Length = gr.Key, Words = gr };

        var query2 = words.GroupBy(w => w.Length, w => w.ToUpper()).Select(g => new { Length = g.Key, Words = g })
            .OrderBy(o => o.Length);

        foreach (var obj in query)
        {
            Console.WriteLine($"Words of length {obj.Length}:");
            foreach (string word in obj.Words)
                Console.WriteLine(word);
        }
    }

    public static void Test2()
    {
        
    }
}