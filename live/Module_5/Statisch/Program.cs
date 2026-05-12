namespace Statisch;

internal class Program
{
    static void Main(string[] args)
    {
        Etage.elevator = new Lift();

        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage {EtageNummer = i };
        }

        flat[43].RoepLift();

        foreach(Etage etage in flat)
        {
           // Etage.ShowStatus();
        }

        Point p1 = new Point { X = 10, Y = 20 };
        p1.Display();
        Point p2 = new Point { X = 100, Y = 200 };
        p2.Display();

        Point p3= p1 + p2;
        p3.Display();

        Console.WriteLine(p1 == p2);

        double d1 = (double)p1;

        Console.WriteLine(d1);



    }
}
