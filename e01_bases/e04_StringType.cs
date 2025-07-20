

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
    }
}