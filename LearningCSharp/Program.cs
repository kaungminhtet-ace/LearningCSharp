var s1 = new Student("kaung min htet", 20);

Console.WriteLine(s1.Age);
Console.WriteLine(s1.Name);

s1.Name = "Kaung Min Htet";
Console.WriteLine(s1.Name);

var p1 = new Point(10, 20);
var p2 = new Point(10, 20);

Console.WriteLine(p1 == p2);

record struct Student(string Name, int Age){ }

record class Point(int X, int Y) {}