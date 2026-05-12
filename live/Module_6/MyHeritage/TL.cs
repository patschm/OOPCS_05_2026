using System;
using System.Collections.Generic;
using System.Text;

namespace MyHeritage;

// TL erft nu van Lamp
// Bevordert hergebruik
class TL : Lamp
{
    public int KnipperCount { get; set; } = 4;

    // Met override activeer ik nu polymorfisme
    public override void Aan()
    {
        for (int i = 0; i < KnipperCount; i++)
        {
            Console.BackgroundColor = Kleur;
            Console.WriteLine($"Knipperdeknipper");
            Task.Delay(200).Wait();
        }
        Console.WriteLine($"De TL is aan met intensiteit {Intensiteit}lm");
        Console.ResetColor();
    }
    public override void Uit()
    {
        Console.BackgroundColor = Kleur;
        Console.WriteLine("De TL is nu uit");
        Console.ResetColor();
    }
}
