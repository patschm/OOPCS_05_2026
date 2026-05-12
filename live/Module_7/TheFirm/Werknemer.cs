using System;
using System.Collections.Generic;
using System.Text;

namespace TheFirm;

internal class Werknemer:Person, IContract
{
    public void DoWork()
    {
        Werkt();
    }

    public virtual void Werkt()
    {
        Console.WriteLine("Hij doet iets");
    }
}
