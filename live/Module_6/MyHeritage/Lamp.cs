namespace MyHeritage;



// Overervingg is bedoeld om FAMILIES van classen te groeperen.
// IS HET EEN. Is TL een Lamp
// Is-a relatie
abstract class Lamp
{
    protected int _intensiteit = 200;
    
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
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;

    // Met virtual maak ik dit gedrag polymorf-ready. Dit is OPTIONEEL
    public virtual void Aan()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De lamp is aan met intensiteit {Intensiteit}lm");
        Console.ResetColor();
    }
    // Het optionele kan ik verplichten door ipv virtual abstract
    public abstract void Uit();
    //{
    //    Console.BackgroundColor = Kleur;
    //    Console.WriteLine("De lamp is nu uit");
    //    Console.ResetColor();
    //}
}
