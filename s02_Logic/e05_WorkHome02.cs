

partial class Program
{

    static void LoopGame()
    {

        int counter = 0;
        System.Console.WriteLine("Pulse una tecla para incrementar");
        System.Console.WriteLine("Pulse ESC para salir!\n");

        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                System.Console.WriteLine("Se pulsó ESC");  
                System.Console.WriteLine($"Total pulsaciones antes de ESC: {counter}");
                System.Console.WriteLine("Programa terminado!");
                break;
            } 
            counter++;
        }


    }


}