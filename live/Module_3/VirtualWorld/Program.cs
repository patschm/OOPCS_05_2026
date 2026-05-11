namespace VirtualWorld;

class Program
{
    static void Main(string[] args)
    {
        // l1 is het object ofwel de instantie van de class Lamp
        Lamp l1 = new Lamp();
        l1._intensiteit = 300;
        l1._kleur = ConsoleColor.Yellow;

        l1.Aan();

        System.Console.WriteLine("Tweede lamp");
        Lamp l2 = new Lamp(ConsoleColor.Red);
        //l2._kleur = ConsoleColor.Green;
        l2.Aan();

        Lamp l3 = new Lamp {_intensiteit = 500};
        l3.Aan();
    }
}

class Lamp
{
    // Eigenschappen leg je vast in fields (veredelde variabelen)
    public int _intensiteit = 200;
    public ConsoleColor _kleur = ConsoleColor.Yellow;

    // Gedrag leg je vast ion Methods (functions/procedures)
    public void Aan()
    {
        Console.BackgroundColor = _kleur;
        System.Console.WriteLine($"De lamp is aan met intensitei {_intensiteit}lm");
        Console.ResetColor();
    }
    public void Uit()
    {
        Console.BackgroundColor = _kleur;
        System.Console.WriteLine("De lamp is nu uit");
        Console.ResetColor();
    }

    // Constructors zijn bedoeld om fields een initiele waarde te geven. 
    public Lamp() : this(ConsoleColor.Yellow)
    {
        // _intensiteit = 200;
        // _kleur = ConsoleColor.Yellow;
    }
    public Lamp(ConsoleColor kleur, int intensiteit = 200)
    {
        _kleur = kleur;
        _intensiteit = intensiteit;
    }

}
