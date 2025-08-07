
partial class Program
{
    static void AnonymousFunctions()
    {
        System.Console.WriteLine(square(5));
        System.Console.WriteLine(lambdaSquare(10));
        List<int> numbers = [1, 2, 3, 4, 5];
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        foreach (var even in evenNumbers)
        {
            System.Console.WriteLine(even);
        }

    }

    // Versíon legada
    static Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    // Versión moderna (más limpia)
    static Func<int, int> lambdaSquare = x => x * x;
}