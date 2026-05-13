namespace MoreInteract;

delegate void OpdrachtDel();

class Program
{
    static void Main(string[] args)
    {
        Patrick p = new Patrick();
        Herman h = new Herman();

        //p.Opdracht();
        h.Execute(p.Opdracht);
        h.Execute(Explode);

        OpdrachtDel opdracht = Explode;
        opdracht();
    }
    static void Explode()
    {
        Console.WriteLine("BOOM!");
    }
}

internal class Herman
{
    public void Execute(OpdrachtDel opdracht)
    {
        Console.WriteLine("Herman is executing the opdracht...");
        opdracht();
    }
}

internal class Patrick
{
    public void Opdracht()
    {
        Console.WriteLine("1 Ginger beer");
        Console.WriteLine("2 Vodka");
        Console.WriteLine("3 Whiskey"); 
        Console.WriteLine("4 Rum");
    }
     
}