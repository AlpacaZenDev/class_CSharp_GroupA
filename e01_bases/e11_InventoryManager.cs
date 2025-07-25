

partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Keyboard"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.50, 20.50, 89.90];

        System.Console.WriteLine("Inventario de Productos");
        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Producto: {products[i]}, Cantidad: {stock[i]}, Precio: {prices[i]}");
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
                    System.Console.WriteLine($"Total compra: {total}");
                }
                else
                {
                    System.Console.WriteLine("Sin stock disponible");
                }
            }
        }
    }
}