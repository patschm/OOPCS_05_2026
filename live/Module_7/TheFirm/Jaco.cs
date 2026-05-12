using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Jaco:Werknemer
{
    public void SpeeltGitaar()
    {
        Console.WriteLine("Jaco maakt een explosieve gitaar");
    }
    public override void Werkt()
    {
        SpeeltGitaar();
    }
}
