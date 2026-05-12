using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Wim : Werknemer
{
    public void ViertVerjaardag()
    {
        Console.WriteLine("Wim voer iedere dag zijn verjaardag");
    }
    public override void Werkt()
    {
        ViertVerjaardag();
    }
}
