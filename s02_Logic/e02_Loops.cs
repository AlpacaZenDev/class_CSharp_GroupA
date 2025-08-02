


partial class Program
{
    static void Loops()
    {
        // WHILE
        int counter = 1;
        while (counter <= 5)
        {
            System.Console.WriteLine($"Iteración {counter}");
            counter++;
        }

        // DO WHILE
        int number = 0;
        do
        {
            System.Console.WriteLine($"Número: {number}");
            number++;
        } while (number < 3);

        // FOR
        for (int i = 0; i <= 5; i++)
        {
            System.Console.WriteLine($"iteración: {i}");
        }

        // FOREACH
        // Arreglo:
        string[] fruits = { "Manzana", "Pera", "Piña" };

        foreach (var fruit in fruits)
        {
            System.Console.WriteLine(fruit);
        }

        // Listas:
        List<string> names = ["Pedro", "Luis", "Nancy"];
        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }

        

    }


}