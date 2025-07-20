

partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416d;
        float floatingNumber = 274f;
        long longNumber = 300_200_100L;
        decimal decimalNumber = 99.99m;

        System.Console.WriteLine($"Integer: {integerNumber}");
        System.Console.WriteLine($"Double: {doubleNumber}");
        System.Console.WriteLine($"Float: {floatingNumber}");
        System.Console.WriteLine($"Long: {longNumber}");
        System.Console.WriteLine($"Decimal: {decimalNumber}");
    }

}