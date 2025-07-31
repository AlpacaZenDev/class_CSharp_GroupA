

partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 75099;
        double totalAmount = quantitySold * unitPrice;

        System.Console.WriteLine($"Producto: {product}");
        System.Console.WriteLine($"Cantidad vendidad: {quantitySold}");
        System.Console.WriteLine($"Total generado: {totalAmount:c}");


    }
}