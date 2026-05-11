namespace EigenTypes
{

    class Program
    {
        static void Main(string[] args)
        {
            //int dagvanweed = 3;
            WeekDag dagvanweek = WeekDag.Dinsdag;
            System.Console.WriteLine(dagvanweek);
            System.Console.WriteLine((int)dagvanweek);
            WeekDag dag2 = (WeekDag)5;
            System.Console.WriteLine(dag2);

            //Enum.Parse<WeekDag>("Dinsdag")

        }
    }

    // Custom type.
    // Duiding geven aan het getal
    enum WeekDag : long
    {
        Zondag = 0,
        Maandag = 1,
        Dinsdag = 2,
        Woensdag = 4,
        Donderdag = 8,
        Vrijdag = 16,
        Zaterdag = 32
    }
}
