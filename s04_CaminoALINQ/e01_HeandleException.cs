

partial class Program
{

    static void HandleException()
    {
        try
        {
            int number = 10;
            int result = number / 0;
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Error: División entre cero");


        }
    }
}