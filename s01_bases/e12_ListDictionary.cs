

partial class Program
{

    static void ListDictionary()
    {
        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
        // Agregar un item a la lista
        names.Add("Lucia");
        names.Add("Marifer");

        System.Console.WriteLine($"Total de nombres: {names.Count}");

        // Mostrar elementos de la lista:
        foreach (var name in names)
        {
            System.Console.WriteLine(name);
        }

        // Remover items de la lista
        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        System.Console.WriteLine($"Ana está en la lista? {isPresent}");

        // * DICTIONARY
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "Felipe"},
            {3, "Elena"}
        };

        foreach (var student in students)
        {
            // System.Console.WriteLine(student);
            System.Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }


    }


}