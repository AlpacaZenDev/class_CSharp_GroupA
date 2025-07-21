

partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime noeWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 01, 01);

        DayOfWeek weekDay = now.DayOfWeek;

        System.Console.WriteLine($"Fecha y hora actual {now}");
        System.Console.WriteLine($"Fecha actual: {today}");
        System.Console.WriteLine($"Fecha de una semana atrás {now} era {noeWeekAgo}");
        System.Console.WriteLine($"Fecha personalizada {customDate}");
        System.Console.WriteLine($"Día de la semana {weekDay}");
    }

}

