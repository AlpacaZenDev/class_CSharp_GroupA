

using System.Runtime.InteropServices;

partial class Program {


    static void InventoryManagerMenu()
    {
        System.Console.WriteLine("\nMenú de opciones");
        System.Console.WriteLine("1. Comprar producto");
        System.Console.WriteLine("2. Salir");
        System.Console.Write("Opción elegida? ");
        int option = int.Parse(Console.ReadLine()!);
        if (option == 1)
        {
            InventoryManager();
        }
        else if (option == 2)
        {
            System.Console.WriteLine("Gracias por si visita!");
        }
        else
        {
            InventoryManagerMenu();
        };
    }

    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Keyboard"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 89.90];

        System.Console.WriteLine("Inventario de Productos");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Producto: {products[i]}, Cantidad: {stock[i]}, Precio: {prices[i]:c}");
        }

        System.Console.WriteLine("\nIngrese el producto que desea comprar: ");
        string? searchProduct = Console.ReadLine();

        System.Console.WriteLine("Ingrese la cantidad que desea comprar: ");
        int quantity = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < products.Length; i++)
        {
            if (products[i].Equals(searchProduct, StringComparison.OrdinalIgnoreCase))
            {
                if (quantity <= stock[i])
                {
                    double total = quantity * prices[i];
                    stock[i] -= quantity;
                    System.Console.WriteLine($"Total compra: {total:c}");
                    System.Console.WriteLine($"Quedan {stock[i]} unidades");
                    InventoryManagerMenu();
                }
                else
                {
                    System.Console.WriteLine("Sin stock disponible");
                    InventoryManagerMenu();
                }
            }
        }
    }


}
