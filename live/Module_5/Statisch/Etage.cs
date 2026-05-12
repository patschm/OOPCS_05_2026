using System.Runtime.CompilerServices;

namespace Statisch;

class Etage
{
    public int EtageNummer { get; set; }
    // Een gedeeld member van de Etage class.
    // Het is niet langer een INSTANCE member.
    // Het is nu een CLASS member
    public static Lift elevator = new Lift();

    public void RoepLift()
    {
        elevator.Call(EtageNummer);
    }
    public static void ShowStatus()
    {
        Console.WriteLine($"De lift is nu op de {elevator.HuidigeVerdieping}e verdieping");
    }

}
