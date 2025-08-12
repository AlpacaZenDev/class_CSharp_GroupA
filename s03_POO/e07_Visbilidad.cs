


using System.Runtime.ConstrainedExecution;

partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new Jedi();
        jedi.PowerLevel = 5000;
        jedi.LightsaberColor = "azul";

        // jedi.UseForce();
        // System.Console.WriteLine(jedi.PublicField);
        // System.Console.WriteLine(jedi.PrivateField);
        // System.Console.WriteLine(jedi.ProtectedField);

        Sith sith = new Sith();
        // sith.ShowProtected();
        sith.UseForce();
    }
}

interface IForceUse
{
    int PowerLevel { get; set; }
    string? LightsaberColor { get; set; }

    void UseForce();

}

class Jedi: IForceUse
{
    public string PublicField = "Mi poder es conocido";
    private string PrivateField = "Mis pensamientos son privados";
    protected string ProtectedField = "Nadie conoce mis secretos";

    public int PowerLevel { get; set; }
    public string? LightsaberColor { get; set; }

    public void UseForce()
    {
        System.Console.WriteLine($"Soy un jedi con un sable de luz color {LightsaberColor} y mi poder es: {PowerLevel}");
    }

    private void Meditate()
    {
        System.Console.WriteLine("Estoy en profunda meditación");
    }

    protected void Train()
    {
        System.Console.WriteLine("Estoy entrrenando para ser el mejor");
    }

    public void RevealSecret()
    {
        System.Console.WriteLine(ProtectedField);
        System.Console.WriteLine(PrivateField);
        Meditate();
    }
}


class Sith : Jedi, IForceUse
{
    public void UseForce
    public void ShowProtected()
    {
        System.Console.WriteLine(ProtectedField);
        Train();
    }
}