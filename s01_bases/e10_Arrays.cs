


partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[5];
        numbers[0] = 1;
        numbers[1] = 3;
        numbers[2] = 10;

        // directa
        int[] numberArrays = [8, 10, 201, 15, 66];

        // Índices
        System.Console.WriteLine($"Primer elemento {numberArrays[0]}");
        System.Console.WriteLine($"Tercer elemento {numberArrays[2]}");

        // Tamaño de arreglo
        System.Console.WriteLine($"El número de elementos es: {numberArrays.Length}");

        // Desde el  final del arreglo:
        System.Console.WriteLine($"Último elemento {numberArrays[^1]}");
        System.Console.WriteLine($"Penúltimo elemento {numberArrays[^3]}");

        // Rangos para obtener subarreglos ..
        int[] firstThree = numberArrays[..3];
        int[] fromIndexTwo = numberArrays[2..];
        foreach (var number in fromIndexTwo)
        {
            System.Console.WriteLine(number);
        }



    }
}