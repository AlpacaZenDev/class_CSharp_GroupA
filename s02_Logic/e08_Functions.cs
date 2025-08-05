

using System.ComponentModel;

partial class Program
{
    static string EvaluateNumber(int number)
    {
        return number == 0 ? "Cero" 
                    : (number > 0) ? "Positivo" : "Negativo";
    }
    
    static double CalculateArea(double witdth, double height)
    {
        return witdth * height;
    }
    static void Functions()
    {
        var area = CalculateArea(12.10, 14.50);
        System.Console.WriteLine($"El área calculada es {area}");

        var evaluateNumber = EvaluateNumber(-1);
        System.Console.WriteLine($"El número evaluado es: {evaluateNumber}");
    }
}