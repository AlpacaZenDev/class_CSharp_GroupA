


using System.Dynamic;

partial class Program
{
    static void Operators()
    {
        int number = 7;
        bool isEven = number % 2 == 0;
        bool isGreaterThanTen = number > 10;

        if (isEven && isGreaterThanTen)
        {
            System.Console.WriteLine($"El número {number} es par y mayor que 10");
        }
        else if (!isEven && isGreaterThanTen)
        {
            System.Console.WriteLine($"El número {number} es impar y mayor que 10");
        }
        else
        {
            System.Console.WriteLine($"El número {number} no cumple con las condiciones");
        }

        // Operador ternario (?:)
        int age = 17;
        string category = age > 18 ? "Adulto" : "Menor";
        System.Console.WriteLine(category);

    }
}