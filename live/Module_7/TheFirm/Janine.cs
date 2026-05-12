using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Janine : Werknemer
{
    public void PlayDungeonAndDragond()
    {
        Console.WriteLine("Janine speel Dungeon and Dragons");
    }
    public override void Werkt()
    {
        PlayDungeonAndDragond();
    }
}
