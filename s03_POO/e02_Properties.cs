


partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Species = "lobo";
        animal.Age = -5;
        System.Console.WriteLine($"donde vive: {animal.Habitat} {animal.Species} {animal.Species}");
    }

}


class Animal
{
    public string Species { get; set; } = "Descononida";
    public string Category { get; set; } = "Vertebrado";
    private int age;
    public int Age
    {
        get { return Age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa");
            }
            age = value;
        }
    }
    public string Habitat { get; }
    public Animal(string habitat)
    {
        Habitat = habitat;
    }
}