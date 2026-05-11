using System.Text;

namespace MyFirst;

class Program
{
    static void Main()
    {
        // Variables
        // Typenaam variablenaam
        // Moeten geinitialiseerd zijn
        int age = 42;
        age = age + 1;
        age += 1;
        Console.WriteLine(++age);


        string name = "Patrick";
        DateTime vandaag = DateTime.Now;

        Console.WriteLine($"{name}, {age}, {vandaag}");

        // Expressies
        // Operands (literals, vairaible) operators (+, -)
        // Het resultaat van een operatie is altijd van het type van een operand.
        double result1 = 2D / 4;
        System.Console.WriteLine(result1);
        int tmp = 257;
        byte result2 = (byte)tmp;

        System.Console.WriteLine(result2);

        bool result3 = tmp > 300 && age < 10;

        int result4 = 1 | 2;
        System.Console.WriteLine(result4);

        string? naam = null;

        System.Console.WriteLine(naam);

        int? leeftijd = null;
        int result5 = leeftijd ?? 1;

        System.Console.WriteLine(naam??"");

        StringBuilder bld = new StringBuilder();
        var bld2 = new StringBuilder();
        StringBuilder bld3 = new();
    }
}
