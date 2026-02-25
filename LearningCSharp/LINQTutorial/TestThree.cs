namespace LearningCSharp.LINQTutorial;

record Product(string Name, int CategoryID);
record Category(string Name, int ID);

public class TestThree
{
    public static void Test1()
    {
        int[] numbers = [5, 10, 8, 3, 6, 12];

        var query1 =
            from num in numbers
            where num is > 7 or < 3
            orderby num descending 
            select num;

        foreach (var i in query1)
        {
            Console.WriteLine($"num is {i}");
        }
        
//Query syntax:
        IEnumerable<int> numQuery1 =
            from num in numbers
            where num % 2 == 0
            orderby num
            select num;

//Method syntax:
        IEnumerable<int> numQuery2 = numbers
            .Where(num => num % 2 == 0)
            .OrderBy(n => n);

        foreach (int i in numQuery1)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine(System.Environment.NewLine);
        foreach (int i in numQuery2)
        {
            Console.Write(i + " ");
        }
    }

    public static void Test2()
    {
        string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];
        IEnumerable<IGrouping<char, string>> queryFoodGroups =
            from item in groupingQuery
            group item by item[0];

        foreach (var group in queryFoodGroups)
        {
            Console.WriteLine($"key {group.Key} ");
            foreach (var se in group)
            {
                Console.WriteLine($"{se}");
            }
        }
    }

    public static void Test3()
    {
        List<int> numbers1 = [ 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 ];
        List<int> numbers2 = [ 15, 14, 11, 13, 19, 18, 16, 17, 12, 10 ];

// Query #4.
        double average = numbers1.Average();

// Query #5.
        IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);
        
        Console.WriteLine(average);
        
        foreach (var i in concatenationQuery)
        {
            Console.WriteLine(i);
        }
    }
    
    static Category?[] categories =
    [
        new ("brass", 1),
        null,
        new ("winds", 2),
        default,
        new ("percussion", 3)
    ];

    static Product?[] products =
    [
        new Product("Trumpet", 1),
        new Product("Trombone", 1),
        new Product("French Horn", 1),
        null,
        new Product("Clarinet", 2),
        new Product("Flute", 2),
        null,
        new Product("Cymbal", 3),
        new Product("Drum", 3)
    ];

    public static void Test4()
    {
        var query1 = from c in categories
            where c != null
            join p in products on c.ID equals p?.CategoryID
            select new
            {
                Category = c.Name,
                Name = p.Name
            };

        var query2 = categories.Where(c => c is not null)
            .Join(products, c => c?.ID, p => p?.CategoryID, (c, po) => new
            {
                Category = c?.Name,
                Name = po?.Name
            });
        
        foreach (var x1 in query1)
        {
            Console.WriteLine($"{x1.Name}, {x1.Category}");
        }
    }
}