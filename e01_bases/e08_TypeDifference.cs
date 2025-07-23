

partial class Program
{
    static void TypeDifference()
    {
        int x = 5;
        int y = x;
        y = 15;
        System.Console.WriteLine($"x: {x} | y: {y}");

        Person person1 = new Person { Name = "Carlos" };
        Person person2 = person1;
        person2.Name = "Alicia";
        System.Console.WriteLine($"person1.name {person1.Name}");
        System.Console.WriteLine($"person2.name {person2.Name}");
    }
}

class Person {
    public string? Name { get; set;  }
}