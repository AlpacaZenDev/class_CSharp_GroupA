

using System.Globalization;

partial class Program
{
    static void DayOfLife()
    {
        DateTime birthDate = new DateTime(1980, 11, 30);
        TimeSpan difference = DateTime.Now - birthDate;

        System.Console.WriteLine($"Has vivido {difference.Days} días");
    }

    static void DaysUntilNextBirthday()
    {
        System.Console.Write("Introduce tu fecha de nacimiento (dd/mm/aaaa): ");
        string birthDateString = Console.ReadLine()!;

        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

        DateTime currentDate = DateTime.Now.Date;
        DateTime nextBirthday = new DateTime(currentDate.Year, birthDate.Month, birthDate.Day);

        if (nextBirthday < currentDate)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        int daysRemaining = (nextBirthday - currentDate).Days;

        System.Console.WriteLine($"Faltan {daysRemaining} hasta tu próximo cumpleaños");
    }

}

