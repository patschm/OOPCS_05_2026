namespace MyHeritage;

internal class Program
{
    static void Main(string[] args)
    {
        //Lamp l1 = new Lamp();
        //l1.Uit();

        // Generalisatie van de TL
        TL t1 = new TL();
        //t1.Aan();
        ZetAan(t1);

        SchemerLamp s1 = new SchemerLamp();
        // s1.Aan();
        ZetAan(s1);
    }

    static void ZetAan(Lamp lamp)
    {
        //if (lamp is TL tl)
        //{
        //    tl.Aan();
        //}
        //else
        //{
        lamp.Aan();
        Console.WriteLine("De lamp is aan");
        lamp.Uit();
        //}
         
    }
    //static void ZetAan(SchemerLamp lamp)
    //{
    //    lamp.Aan();
    //}
}
