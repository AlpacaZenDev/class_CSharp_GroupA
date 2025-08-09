

partial class Program
{
    static void AbstractClassExamples()
    {
        HomeAppliance myWasher = new WashingMachine { Brand = "Samsung" };
        HomeAppliance myMicrowave = new Microwave { Brand = "LG" };
        myWasher.ShowBrand();
        myWasher.TurOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurOn();
    }


}


abstract class HomeAppliance
{
    public string? Brand { get; set; }

    public abstract void TurOn();

    public void ShowBrand()
    {
        System.Console.WriteLine($"La marca del electrodoméstico es {Brand}");
    }
}

class WashingMachine : HomeAppliance
{
    public override void TurOn()
    {
        System.Console.WriteLine("La lavadora a inicializado el ciclo de lavado");
    }
}

class Microwave : HomeAppliance
{
    public override void TurOn()
    {
        System.Console.WriteLine("El microhondas está calentando la comida");
    }
}
