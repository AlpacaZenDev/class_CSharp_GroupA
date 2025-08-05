


partial class Program
{
    static void Convertions()
    {
        int number = 42;
        decimal decimalNumber = number;
        System.Console.WriteLine(decimalNumber);

        double explicitDecimalNumber = 49.9;
        int integerNumber = (int)explicitDecimalNumber;
        System.Console.WriteLine(integerNumber);


        // Convert o Parse
        string textNumber = "132";
        int parsedNumber = int.Parse(textNumber);
        System.Console.WriteLine(parsedNumber);

        // Convert
        double anotherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        System.Console.WriteLine(convertedNumber);

        int castedNumber = (int)anotherDecimalNumber;
        System.Console.WriteLine(castedNumber);

    }
}