namespace TheFirm;

internal class ACME
{
    private List<IContract> werknemers = new List<IContract>();

    public void Hire(IContract en)
    {
        werknemers.Add(en);
    }

    public void StartProduction()
    {
        Console.WriteLine("ACME gaat nu produceren");
        foreach (var werknemer in werknemers)
        {
            werknemer.DoWork();
        }
    }
}
