

using System.Globalization;

partial class Program
{
    static void ConvertionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int totalFriends = int.Parse("101");
        double cost = 25.50;
        DateTime birthDay = DateTime.Parse("2 March 2025");

        System.Console.WriteLine($"Tengo {totalFriends} amigos para invitar a mi fiesta");
        System.Console.WriteLine($"La celebración de mi cumpleaños será el {birthDay}");
        System.Console.WriteLine($"Formato largo: {birthDay:D}");
        System.Console.WriteLine($"El costo de la entrada será {cost:C}");
    }
}