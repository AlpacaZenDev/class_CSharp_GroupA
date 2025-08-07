


partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corolla";
        toyota.Year = 2021;
        toyota.ShowInfo();

        Vehicle honda = new Vehicle { Brand = "Honda", Model = "Civic", Year = 2019 };
        // honda.Model = "Civic";
        // honda.Brand = "Honda";
        // honda.Year = 2023;
        honda.ShowInfo();


        Vehicle renault = new Vehicle("Renault", "Duster", 2018);
        renault.ShowInfo();


    }

    class Vehicle
    {
        // Propiedades
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }

        // Métodos
        public void ShowInfo()
        {
            System.Console.WriteLine($"Este vehículo es un {Brand} {Model} del año {Year}");
        }

        // Método constructor
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public Vehicle()
        {
            
        }

    }
}