using System.ComponentModel.DataAnnotations;

namespace Flows;

class Program
{
    static void Main(string[] args)
    {
        int age = 42;

        // Gebruik deze dingen voor range checks
        if (age > 18 && age < 65)
        {
            System.Console.WriteLine("Groter dan 18");
        }
        else if (age >= 65)
        { }

        // Voor concrete waarden
        age = 20;
        switch (age)
        {
            case 17:
            case 18:
                System.Console.WriteLine("18");
                break;
            default:
                System.Console.WriteLine("Alles anders");
                break;
            case 20:
                System.Console.WriteLine("Twintig");
                break;

        }

        // Loops
        // Gebruik for als je weet HOE VAAK je moet herhalen
        int x = 0;
        for (Console.WriteLine("Begin loop");; Console.WriteLine("Einde iteratie"))
        {
            x += 2;
            if (x >= 10) break;
            if (x == 6) continue;
            Console.WriteLine($"Waarde {x}");
        }
        System.Console.WriteLine(x);

        // While loop wordt 0 of meer keer uitgevoerd.
        // Je weet niet hoe vaak.
        while(x <30)
        {
            System.Console.WriteLine($"While {x++}");
        }

        // Wordt een of meer keer uitgevoerd
        do
        {
            System.Console.WriteLine($"do {x++}");
        }
        while(x < 40);



    }
}
