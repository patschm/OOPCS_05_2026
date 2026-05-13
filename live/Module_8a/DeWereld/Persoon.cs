using System;
using System.Collections.Generic;
using System.Text;

namespace DeWereld;

class Persoon
{
    public int Id { get; set; }
    public string? Voornaam { get; set; }
    public string? Achternaam { get; set; }
    public int Leeftijd { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Voornaam} {Achternaam} ({Leeftijd})";
    }
}
