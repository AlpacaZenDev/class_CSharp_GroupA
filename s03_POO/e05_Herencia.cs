

using System.ComponentModel;

partial class Program
{

    public static void Inheritance()
    {
        HowgartsStudent student = new HowgartsStudent() { Name = "Harry P.", House = "Gryffindor" };
        HowgartsProfessor professor = new HowgartsProfessor() { Name = "Severus Snape", Subject = "Pociones" };

        student.Greet();
        student.ShowHouse();
        professor.Greet();
        professor.MySubject();

    }
}

class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        System.Console.WriteLine($"Hola, soy {Name}");
    }
}

class HowgartsStudent : Character
{
    public string? House { get; set; }

    public override void Greet()
    {
        System.Console.WriteLine($"Hola, soy {Name} y soy estudiante");
    }

    public void ShowHouse()
    {
        System.Console.WriteLine($"Pertenezco a la casa  {House} en Howgarts");
    }
}
class HowgartsProfessor : Character
{
    public string? Subject { get; set; }
    public override void Greet()
    {
        System.Console.WriteLine($"Hola, soy {Name} y soy profesor");
    }

    public void MySubject()
    {
        System.Console.WriteLine($"Enseño {Subject} en Howgarts");
    }
}