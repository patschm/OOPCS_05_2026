namespace TheFirm;

// Bokito IMPLEMENTEERT de interface IContract
internal class Bokito : IContract, IContract2
{
    public void DoWork()
    {
        Console.WriteLine("Voor ACME");
        RamtDamesInElkaar();
    }
    // Explicite implementatie
    void IContract2.DoWork()
    {
        Console.WriteLine("Voor AFAS");
        RamtDamesInElkaar();
    }

    public void RamtDamesInElkaar()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }
   }
