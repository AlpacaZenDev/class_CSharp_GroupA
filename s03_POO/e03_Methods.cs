

partial class Program
{

    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        System.Console.WriteLine(car.ShowInfo());

        // car.ShowMessage();
        // car.ShowMessage("Cambiando el modelo");
        // car.ChangeModel("Patrol");
        // System.Console.WriteLine(car.ShowInfo());

        // Car.GeneralInfo();
        // car.ShowInfo();

        Car sportCar = new Car("Ferrari", 2020);
        System.Console.WriteLine(sportCar.ShowInfo());

        // Sintaxis simplificada:
        Car collectionCar = new Car { Model = "Cadillac", Year = 1980 };
        System.Console.WriteLine(collectionCar.ShowInfo());


        // Lista de objetos:
        List<Car> cars = new()
        {
            new Car(){Model = "Duster", Year=2021},
            new Car(){Model = "StephWay", Year=2019},
            new Car(){Model = "Captur", Year=2000},
        };
        foreach (var item in cars)
        {
            System.Console.WriteLine(item.ShowInfo());
        }
    }
}

class Car
{
    public string? Model { get; set; }

    public int? Year { get; set; }

    // Constructor con parámetros;
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }
    // Constructor por defecto:
    public Car() { }

    // Destructor ( ~ )
    ~Car()
    {
        System.Console.WriteLine("Destructor llamado. Recurso liberado");
        
    }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    public string ShowInfo()
    {
        return $"Automóvil: {Model}, Año: {Year}";
    }

    public void ShowMessage() => System.Console.WriteLine("Este es un automóvil");

    public void ShowMessage(string message) => System.Console.WriteLine(message);

    public static void GeneralInfo()
    {
        System.Console.WriteLine("El automóvil es uno de los transportes más utilizados");
    }


}