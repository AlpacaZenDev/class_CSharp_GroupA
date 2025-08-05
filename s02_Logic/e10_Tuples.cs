


partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hola");
        System.Console.WriteLine($"Número: {myTuple.Item1}, Texto: {myTuple.Item2}");


        (int Number, string Text) myOtherTuple = (33, "Nombrado");
        System.Console.WriteLine($"Número {myOtherTuple.Number}, Texto {myOtherTuple.Text}");

        var operations = Operations(20, 10);
        System.Console.WriteLine($"Suma: {operations.Sum}, Resta: {operations.Sustraction}");

        (int sum, int sustraction) = Operations(25, 15);
        System.Console.WriteLine($"Suma: {sum}, Resta: {sustraction}");


    static (int Sum, int Sustraction) Operations(int a, int b)
        {
            return (a + b, a - b);
        }

    }
}