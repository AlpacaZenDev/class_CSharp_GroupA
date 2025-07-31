

partial class Program
{
    static void ShowStringType()
    {
        string name = "Juan";
        string message = "Hola " + name;
        string interpolatedMessage = $"Hola {name}";
        System.Console.WriteLine(name);
        System.Console.WriteLine(message);
        System.Console.WriteLine(interpolatedMessage);
        System.Console.WriteLine($"Tu nombre tiene {name.Length} letras");
        System.Console.WriteLine($"Tu nombre es mayúsculas es {name.ToUpper()}");
        System.Console.WriteLine($"Tu nombre es mayúsculas es {name.ToLower()}");

    }
}