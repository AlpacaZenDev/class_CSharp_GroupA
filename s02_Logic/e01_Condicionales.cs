

partial class Program
{
    static void Conditional()
    {
        int age = 9;

        if (age >= 18)
        {
            System.Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            System.Console.WriteLine("Eres menor de edad");
        }


        // IF TERNARIO:
        string message = (age >= 18) ? "Mayor de edad" : "Menor de edad";
        System.Console.WriteLine(message);

        // CONDICIONAL MÚLTIPLE:
        int temperature = 30;
        string message2 = (temperature >= 35) ? "Hace mucho calor" : ((temperature >= 20) ? "Es agradable" : "Hace frío");
        System.Console.WriteLine(message2);


        // SWITCH
        int day = 4;

        switch (day)
        {
            case 1:
                System.Console.WriteLine("Lunes");
                break;
            case 2:
                System.Console.WriteLine("Martes");
                break;
            case 3:
                System.Console.WriteLine("Miércoles");
                break;
            default:
                System.Console.WriteLine("Día no válido");
                break;
        }

        // SWITCH CON EXPRESIONES LAMBDA
        string messageDay = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            _ => "Día no válido"
        };
        System.Console.WriteLine(messageDay);

    }



}