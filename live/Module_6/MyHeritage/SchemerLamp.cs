namespace MyHeritage;

sealed class SchemerLamp : Lamp
{
    // Met sealed hef ik het polymorfistische karakter van deze methode op.
    public sealed override void Aan()
    {
        //base._intensiteit =
        Console.BackgroundColor = Kleur;
        Console.WriteLine($"De schemerlamp is aan met intensiteit {Intensiteit}lm");
        Console.ResetColor();
    }
    public override void Uit()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine("De schemerlamp is nu uit");
        Console.ResetColor();
    }
}
