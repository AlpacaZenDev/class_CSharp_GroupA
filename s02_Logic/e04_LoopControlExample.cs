


partial class Program
{

    static void LoopControlExamples()
    {

        for (int i = 0; i < 10; i++)
        {
            if (i == 5) break;
            System.Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i == 5 || i == 7) continue;
            System.Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            // if (i == 3) return;
            System.Console.WriteLine(i);
        }


        // BUCLES INIFINITOS
        // while (true)
        // {
        //     System.Console.WriteLine("Esto siempre se ejecutará!");
        // }

        for (; ; )
        {
            System.Console.WriteLine("Esto siempre se ejecutará!");
            break;
        }


    }
}