

partial class Program
{
    static void SalaryCalc()
    {

        System.Console.WriteLine("######### Calculo de Salario #########");
        System.Console.Write($"Ingrese su nombre: ");
        string? name = Console.ReadLine();
        System.Console.Write($"Horas trabajadas: ");
        double hoursWorked = double.Parse(Console.ReadLine()!);
        System.Console.Write($"Salario por hora: ");
        double hourlyWage = double.Parse(Console.ReadLine()!);
        double totalSalary = hoursWorked * hourlyWage;
        System.Console.WriteLine($"El salario para {name} es de: {totalSalary:c}");
    }
}