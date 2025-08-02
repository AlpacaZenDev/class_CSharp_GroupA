

partial class Program
{
    static void FizzBuzz()
    {
        for (int num = 1; num <= 100; num++)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine($"{num}: FizzBuzz");
            }
            else if (num % 5 == 0)
            {
                System.Console.WriteLine($"{num}: Buzz");
            }
            else if (num % 3 == 0)
            {
                System.Console.WriteLine($"{num}: Fizz");
            }
            else
            {
                System.Console.WriteLine(num);
            }

        }

    }
}