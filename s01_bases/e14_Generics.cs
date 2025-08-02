


partial class Program
{

    static void Generics()
    {
        string[] names = { "Juan", "Luis", "Diana", "Jonh" };
        int[] numbers = { 1, 2, 3 };
        WriteLine($"Longitud del arreglo numérico: {GetIntArrayLength(numbers)}");
        WriteLine($"Longitud del arreglo nombres: {GetStringArrayLength(names)}");

        WriteLine($"Longitud del arreglo genérico {GetArrayLength(numbers)}");
        WriteLine($"longitud del arreglo genérico {GetArrayLength(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Texto" };
        numberBox.Show();
        stringBox.Show();
     }

    // MÉTODOS SIN EL USO DE GENÉRICOS

    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    // MÉTODOS CON EL USO DE GENÉRICOS

    static int GetArrayLength<T>(T[] array)
    {
        return array.Length;
    }

    class Box<T>
    {
        public T? Content { get; set; }
        public void Show()
        {
            WriteLine($"Contenido: {Content}");
        }
    }


}