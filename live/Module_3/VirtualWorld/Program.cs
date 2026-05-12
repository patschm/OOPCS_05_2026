namespace VirtualWorld;

class Program
{
    static void Main(string[] args)
    {
        // l1 is het object ofwel de instantie van de class Lamp
        Lamp l1 = new Lamp();
        //l1._intensiteit = 300;
        l1.Intensiteit = 300;
       // l1.Kleur = ConsoleColor.Yellow;

        l1.Aan();

        System.Console.WriteLine("Tweede lamp");
        Lamp l2 = new Lamp(ConsoleColor.Red, -500);
        //l2.SetIntensiteit(2_000_000_000);
        l2.Intensiteit = 2_000_000_000;
        //l2._kleur = ConsoleColor.Green;
        l2.Aan();

        Lamp l3 = new Lamp { Intensiteit = 500};
        //l3.SetIntensiteit(500);
        l3.Aan();
    }
}

class Lamp
{
    // Eigenschappen leg je vast in fields (veredelde variabelen)
    private int _intensiteit = 200;
    private ConsoleColor _kleur = ConsoleColor.Green;

    // Old School Accessors, zoals in Java, C++
    //public void SetIntensiteit(int inten)
    //{
    //    if (inten >= 0 && inten < 2000)
    //    {
    //        _intensiteit = inten;
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return _intensiteit;
    //}

    // De moderne dotnetter doet het met properties
    public int Intensiteit
    {
        get { return _intensiteit; }
        set
        {
            if (value >= 0 && value < 2000)
            {
                _intensiteit = value;
            }
        }
    }
    // Auto generating property. Genereert zijn eigen private field
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Gedrag leg je vast ion Methods (functions/procedures)
    public void Aan()
    {
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine($"De lamp is aan met intensitei {Intensiteit}lm");
        Console.ResetColor();
    }
    public void Uit()
    {
        Console.BackgroundColor = Kleur;
        System.Console.WriteLine("De lamp is nu uit");
        Console.ResetColor();
    }

    // Constructors zijn bedoeld om fields een initiele waarde te geven. 
    public Lamp() //: this(ConsoleColor.Yellow)
    {
        // _intensiteit = 200;
        // _kleur = ConsoleColor.Yellow;
    }
    public Lamp(ConsoleColor kleur, int intensiteit = 200)
    {
        Kleur = kleur;
        Intensiteit = intensiteit;
    }

}
