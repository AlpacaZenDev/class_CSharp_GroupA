


partial class Program
{
    static void PrintFactorialTable(int limit)
    {
        System.Console.WriteLine($"Tabla del factorial del número {limit}");

        for (int i = 1; i <= limit; i++)
        {
            System.Console.WriteLine($"{i}! = {Factorial(i)}");
        }
        System.Console.WriteLine();
    }

    static int Factorial(int number)
    {
        int result = 1;
        for (int i = 1; i <= number; i++)
        {
            result *= i;
        }
        return result;
    }

    static void FactorialTable()
    {
        PrintFactorialTable(6);
    }

}