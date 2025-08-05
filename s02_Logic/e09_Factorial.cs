


partial class Program
{
    static void PrintMultiplicationTable(int number = 1, int tableLimit = 12)
    {
        System.Console.WriteLine($"Tabla de multiplicar del número {number} desde el 1 hasta {tableLimit}");

        for (int i = 0; i <= tableLimit; i++)
        {
            System.Console.WriteLine($"{number} x {i} = {number * i}");
        }


    }

    static void MultiplicationTable()
    {
        PrintMultiplicationTable(12, 11);
    }
}